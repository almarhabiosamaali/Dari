using System;
using System.Data;
using System.Data.SqlClient;

namespace Dari.Clas
{
    /// <summary>
    /// احتساب الإيجار - استدعاء sp_GetRentSummaryByProperty (من vw_RentSummary)، sp_RentCalculationMst_Add
    /// </summary>
    public class RentCalculation
    {
        public DataTable GetRentSummaryByProperty(string PropertyNo)
        {
            var dal = new DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@PropertyNo", SqlDbType.NVarChar, 50) { Value = PropertyNo };
            DataTable dt = dal.SelectData("sp_GetRentSummaryByProperty", param);
            dal.Close();
            return dt;
        }

        /// <summary>
        /// الحصول على رقم الاحتساب التالي (من جدول RentCalculation_mst).
        /// </summary>
        public string GET_NEXT_CalculationNo()
        {
            return AutoNumberHelper.GetNextNumber("RentCalculation_mst", "CalculationNo");
        }

        /// <summary>
        /// إضافة سجل رئيسي في RentCalculation_mst عبر sp_RentCalculationMst_Add
        /// </summary>
        public void AddMst(
            string CalculationNo,
            string PropertyNo,
            int BillYear,
            byte BillMonth,
            DateTime CalculationDate,
            decimal TotalAmount)
        {
            var dal = new DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@CalculationNo", SqlDbType.NVarChar, 50) { Value = CalculationNo };
            param[1] = new SqlParameter("@PropertyNo", SqlDbType.NVarChar, 50) { Value = PropertyNo };
            param[2] = new SqlParameter("@BillYear", SqlDbType.Int) { Value = BillYear };
            param[3] = new SqlParameter("@BillMonth", SqlDbType.TinyInt) { Value = BillMonth };
            param[4] = new SqlParameter("@CalculationDate", SqlDbType.Date) { Value = CalculationDate };
            param[5] = new SqlParameter("@TotalAmount", SqlDbType.Decimal) { Precision = 18, Scale = 2, Value = TotalAmount };
            dal.ExecuteCommand("sp_RentCalculationMst_Add", param);
            dal.Close();
        }
    }
}
