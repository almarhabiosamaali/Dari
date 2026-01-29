using System;
using System.Data;
using System.Data.SqlClient;

namespace Dari.Clas
{
    /// <summary>
    /// فواتير المستأجرين - جدول TenantInvoices
    /// يتطلب: sp_TenantInvoice_Add، sp_TenantInvoice_SelectAll (وعرض)، sp_TenantInvoice_Update، sp_TenantInvoice_Delete (إن وُجدت)
    /// </summary>
    public class TenantInvoices
    {
        public string GET_NEXT_InvoiceNo()
        {
            return AutoNumberHelper.GetNextNumber("TenantInvoices", "InvoiceNo");
        }

        public DataTable GET_ALL_TenantInvoices()
        {
            var dal = new DataAccessLayer();
            dal.Open();
            DataTable dt = dal.SelectData("sp_TenantInvoice_SelectAll", null);
            dal.Close();
            return dt;
        }

        public void ADD_TenantInvoice(
            string InvoiceNo,
            string TenantNo,
            int BillYear,
            byte BillMonth,
            DateTime InvoiceDate,
            decimal? ElectricityUsage = null,
            decimal? ElectricityAmount = null,
            decimal? WaterUsage = null,
            decimal? WaterAmount = null,
            decimal? OtherFees = null,
            string Narration = null)
        {
            var dal = new DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("@InvoiceNo", SqlDbType.NVarChar, 50) { Value = InvoiceNo };
            param[1] = new SqlParameter("@TenantNo", SqlDbType.NVarChar, 50) { Value = TenantNo };
            param[2] = new SqlParameter("@BillYear", SqlDbType.Int) { Value = BillYear };
            param[3] = new SqlParameter("@BillMonth", SqlDbType.TinyInt) { Value = BillMonth };
            param[4] = new SqlParameter("@InvoiceDate", SqlDbType.Date) { Value = InvoiceDate };
            param[5] = new SqlParameter("@ElectricityUsage", SqlDbType.Decimal) { Precision = 18, Scale = 2, Value = ElectricityUsage ?? (object)DBNull.Value };
            param[6] = new SqlParameter("@ElectricityAmount", SqlDbType.Decimal) { Precision = 18, Scale = 2, Value = ElectricityAmount ?? (object)DBNull.Value };
            param[7] = new SqlParameter("@WaterUsage", SqlDbType.Decimal) { Precision = 18, Scale = 2, Value = WaterUsage ?? (object)DBNull.Value };
            param[8] = new SqlParameter("@WaterAmount", SqlDbType.Decimal) { Precision = 18, Scale = 2, Value = WaterAmount ?? (object)DBNull.Value };
            param[9] = new SqlParameter("@OtherFees", SqlDbType.Decimal) { Precision = 18, Scale = 2, Value = OtherFees ?? (object)DBNull.Value };
            param[10] = new SqlParameter("@Narration", SqlDbType.NVarChar, 500) { Value = string.IsNullOrWhiteSpace(Narration) ? (object)DBNull.Value : Narration };

            dal.ExecuteCommand("sp_TenantInvoice_Add", param);
            dal.Close();
        }

        public void UPDATE_TenantInvoice(
            string InvoiceNo,
            string TenantNo,
            int BillYear,
            byte BillMonth,
            DateTime InvoiceDate,
            decimal? ElectricityUsage = null,
            decimal? ElectricityAmount = null,
            decimal? WaterUsage = null,
            decimal? WaterAmount = null,
            decimal? OtherFees = null,
            string Narration = null)
        {
            var dal = new DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("@InvoiceNo", SqlDbType.NVarChar, 50) { Value = InvoiceNo };
            param[1] = new SqlParameter("@TenantNo", SqlDbType.NVarChar, 50) { Value = TenantNo };
            param[2] = new SqlParameter("@BillYear", SqlDbType.Int) { Value = BillYear };
            param[3] = new SqlParameter("@BillMonth", SqlDbType.TinyInt) { Value = BillMonth };
            param[4] = new SqlParameter("@InvoiceDate", SqlDbType.Date) { Value = InvoiceDate };
            param[5] = new SqlParameter("@ElectricityUsage", SqlDbType.Decimal) { Precision = 18, Scale = 2, Value = ElectricityUsage ?? (object)DBNull.Value };
            param[6] = new SqlParameter("@ElectricityAmount", SqlDbType.Decimal) { Precision = 18, Scale = 2, Value = ElectricityAmount ?? (object)DBNull.Value };
            param[7] = new SqlParameter("@WaterUsage", SqlDbType.Decimal) { Precision = 18, Scale = 2, Value = WaterUsage ?? (object)DBNull.Value };
            param[8] = new SqlParameter("@WaterAmount", SqlDbType.Decimal) { Precision = 18, Scale = 2, Value = WaterAmount ?? (object)DBNull.Value };
            param[9] = new SqlParameter("@OtherFees", SqlDbType.Decimal) { Precision = 18, Scale = 2, Value = OtherFees ?? (object)DBNull.Value };
            param[10] = new SqlParameter("@Narration", SqlDbType.NVarChar, 500) { Value = string.IsNullOrWhiteSpace(Narration) ? (object)DBNull.Value : Narration };

            dal.ExecuteCommand("sp_TenantInvoice_Update", param);
            dal.Close();
        }

        public void DELETE_TenantInvoice(string InvoiceNo)
        {
            var dal = new DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@InvoiceNo", SqlDbType.NVarChar, 50) { Value = InvoiceNo };
            dal.ExecuteCommand("sp_TenantInvoice_Delete", param);
            dal.Close();
        }
    }
}
