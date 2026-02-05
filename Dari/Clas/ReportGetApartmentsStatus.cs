using System;
using System.Data;
using System.Data.SqlClient;

namespace Dari.Clas
{
    /// <summary>
    /// جلب بيانات تقرير حالة المباني والشقق عبر sp_ReportGetApartmentsStatus.
    /// </summary>
    public class ReportGetApartmentsStatus
    {
        /// <summary>
        /// يستدعي sp_ReportGetApartmentsStatus بمعامل @P_Whr فقط.
        /// </summary>
        public DataTable GetApartmentsStatus(string P_Whr)
        {
            var DAL = new DataAccessLayer();
            DAL.Open();
            try
            {
                var param = new SqlParameter[1];
                param[0] = new SqlParameter("@P_Whr", SqlDbType.NVarChar, 500) { Value = string.IsNullOrWhiteSpace(P_Whr) ? (object)DBNull.Value : P_Whr };
                return DAL.SelectData("sp_ReportGetApartmentsStatus", param);
            }
            catch (SqlException)
            {
                return null;
            }
            finally
            {
                DAL.Close();
            }
        }
    }
}
