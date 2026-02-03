using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Dari.Clas
{
    /// <summary>
    /// جلب بيانات تقرير كشف الحساب (مستأجر أو عقار).
    /// يحاول أولاً استدعاء sp_Report_AccountStatement، وإذا لم يكن موجوداً يستخدم استعلاماً مباشراً.
    /// </summary>
    public class ReportAccountStatement
    {
        /// <summary>
        /// ReportType: 1 = كشف حساب مستأجر, 2 = كشف حساب عقار
        /// MovementTypeFilter: null أو "" = الكل, "1" = إيجار, "2" = فاتورة, "3" = سندات
        /// </summary>
        public DataTable GetAccountStatement(string P_Whr)
        {
            var DAL = new DataAccessLayer();
            DAL.Open();
            try
            {
                var param = new SqlParameter[1];
                
                param[0] = new SqlParameter("@P_Whr", SqlDbType.NVarChar, 500) { Value = string.IsNullOrWhiteSpace(P_Whr) ? (object)DBNull.Value : P_Whr };
            

                return DAL.SelectData("sp_Report_AccountStatement", param);
            }
            catch (SqlException)
            {
                // الإجراء المخزن غير موجود أو خطأ في التنفيذ — استخدام استعلام مباشر
                return null;
            }
            finally
            {
                DAL.Close();
            }
        }

        /// <summary>
        /// جلب كشف الحساب باستعلام SQL مباشر (بديل عند عدم وجود SP).
        /// </summary>
        private DataTable GetAccountStatementByQuery(
            DataAccessLayer DAL,
            int reportType,
            string tenantNo,
            string propertyNo,
            string apartmentNo,
            int? year,
            int? fromMonth,
            int? toMonth,
            string movementTypeFilter)
        {
            var sb = new StringBuilder();
            sb.Append(@"
                SELECT
                    fm.DocumentNo        AS [رقم المستند],
                    CASE fm.MovementType
                        WHEN N'1' THEN N'إيجار'
                        WHEN N'2' THEN N'فاتورة'
                        WHEN N'3' THEN N'سندات'
                        ELSE fm.MovementType
                    END                  AS [نوع المستند],
                    fm.DocumentDate      AS [التاريخ],
                    fm.BillYear          AS [سنة],
                    fm.BillMonth         AS [شهر],
                    fm.TenantNo          AS [رقم المستأجر],
                    fm.ApartmentNo       AS [رقم الشقة],
                    ISNULL(fm.Debit, 0)  AS [مدين],
                    ISNULL(fm.Credit, 0) AS [دائن],
                    fm.Notes             AS [ملاحظات]
                FROM FinancialMovements fm
                LEFT JOIN Apartments a ON a.ApartmentNo = fm.ApartmentNo
                WHERE 1 = 1 ");
            var paramList = new System.Collections.Generic.List<SqlParameter>();

            if (reportType == 1 && !string.IsNullOrWhiteSpace(tenantNo))
            {
                sb.Append(" AND fm.TenantNo = @TenantNo ");
                paramList.Add(new SqlParameter("@TenantNo", SqlDbType.NVarChar, 50) { Value = tenantNo });
            }
            if (reportType == 2 && !string.IsNullOrWhiteSpace(propertyNo))
            {
                sb.Append(" AND a.PropertyNo = @PropertyNo ");
                paramList.Add(new SqlParameter("@PropertyNo", SqlDbType.NVarChar, 50) { Value = propertyNo });
            }
            if (!string.IsNullOrWhiteSpace(apartmentNo))
            {
                sb.Append(" AND fm.ApartmentNo = @ApartmentNo ");
                paramList.Add(new SqlParameter("@ApartmentNo", SqlDbType.NVarChar, 50) { Value = apartmentNo });
            }
            if (year.HasValue)
            {
                sb.Append(" AND fm.BillYear = @Year ");
                paramList.Add(new SqlParameter("@Year", SqlDbType.Int) { Value = year.Value });
            }
            if (fromMonth.HasValue)
            {
                sb.Append(" AND fm.BillMonth >= @FromMonth ");
                paramList.Add(new SqlParameter("@FromMonth", SqlDbType.Int) { Value = fromMonth.Value });
            }
            if (toMonth.HasValue)
            {
                sb.Append(" AND fm.BillMonth <= @ToMonth ");
                paramList.Add(new SqlParameter("@ToMonth", SqlDbType.Int) { Value = toMonth.Value });
            }
            if (!string.IsNullOrWhiteSpace(movementTypeFilter))
            {
                sb.Append(" AND fm.MovementType = @MovementType ");
                paramList.Add(new SqlParameter("@MovementType", SqlDbType.NVarChar, 50) { Value = movementTypeFilter });
            }

            sb.Append(" ORDER BY fm.DocumentDate, fm.DocumentNo ");

            var paramArray = paramList.Count > 0 ? paramList.ToArray() : null;
            return DAL.SelectDataFromQuery(sb.ToString(), paramArray);
        }
    }
}
