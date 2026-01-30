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
        /// جلب جميع سجلات الاحتساب الرئيسية عبر sp_RentCalculationMst_SelectAll
        /// </summary>
        public DataTable GetAllMst()
        {
            var dal = new DataAccessLayer();
            dal.Open();
            DataTable dt = dal.SelectData("sp_RentCalculationMst_SelectAll", null);
            dal.Close();
            return dt;
        }

        /// <summary>
        /// جلب تفاصيل الاحتساب برقم الماستر عبر sp_RentCalculationDtl_SelectByCalculationNo
        /// </summary>
        public DataTable GetDtlByCalculationNo(string CalculationNo)
        {
            var dal = new DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CalculationNo", SqlDbType.NVarChar, 50) { Value = CalculationNo };
            DataTable dt = dal.SelectData("sp_RentCalculationDtl_SelectByCalculationNo", param);
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

        /// <summary>
        /// تحديث سجل رئيسي في RentCalculation_mst عبر sp_RentCalculationMst_Update
        /// </summary>
        public void UpdateMst(
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
            dal.ExecuteCommand("sp_RentCalculationMst_Update", param);
            dal.Close();
        }

        /// <summary>
        /// حذف سجل رئيسي من RentCalculation_mst عبر sp_RentCalculationMst_Delete
        /// </summary>
        public void DeleteMst(string CalculationNo)
        {
            var dal = new DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CalculationNo", SqlDbType.NVarChar, 50) { Value = CalculationNo };
            dal.ExecuteCommand("sp_RentCalculationMst_Delete", param);
            dal.Close();
        }

        /// <summary>
        /// حذف تفاصيل الاحتساب برقم الماستر عبر sp_RentCalculationDtl_Delete
        /// </summary>
        public void DeleteDtlByCalculationNo(string CalculationNo)
        {
            var dal = new DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CalculationNo", SqlDbType.NVarChar, 50) { Value = CalculationNo };
            dal.ExecuteCommand("sp_RentCalculationDtl_Delete", param);
            dal.Close();
        }

        /// <summary>
        /// إضافة سطر تفصيلي في RentCalculation_dtl عبر sp_RentCalculationDtl_Add
        /// </summary>
        public void AddDtl(
            string CalculationNo,
            string TenantNo,
            string ApartmentNo,
            string ContractNo,
            decimal RentAmount,
            decimal OtherAmount,
            decimal TotalLineAmount)
        {
            var dal = new DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@CalculationNo", SqlDbType.NVarChar, 50) { Value = CalculationNo };
            param[1] = new SqlParameter("@TenantNo", SqlDbType.NVarChar, 50) { Value = TenantNo ?? (object)DBNull.Value };
            param[2] = new SqlParameter("@ApartmentNo", SqlDbType.NVarChar, 50) { Value = ApartmentNo ?? (object)DBNull.Value };
            param[3] = new SqlParameter("@ContractNo", SqlDbType.NVarChar, 50) { Value = ContractNo ?? (object)DBNull.Value };
            param[4] = new SqlParameter("@RentAmount", SqlDbType.Decimal) { Precision = 18, Scale = 2, Value = RentAmount };
            param[5] = new SqlParameter("@OtherAmount", SqlDbType.Decimal) { Precision = 18, Scale = 2, Value = OtherAmount };
            param[6] = new SqlParameter("@TotalLineAmount", SqlDbType.Decimal) { Precision = 18, Scale = 2, Value = TotalLineAmount };
            dal.ExecuteCommand("sp_RentCalculationDtl_Add", param);
            dal.Close();
        }
    }
}
