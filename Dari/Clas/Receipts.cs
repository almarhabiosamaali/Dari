using System;
using System.Data;
using System.Data.SqlClient;

namespace Dari.Clas
{
    /// <summary>
    /// السندات - جدول Receipts
    /// يتطلب: sp_Receipt_Add، sp_Receipt_SelectAll (وعرض)، sp_Receipt_Update، sp_Receipt_Delete (إن وُجدت)
    /// </summary>
    public class Receipts
    {
        public string GET_NEXT_ReceiptNo()
        {
            return AutoNumberHelper.GetNextNumber("Receipts", "ReceiptNo");
        }

        public DataTable GET_ALL_Receipts()
        {
            var dal = new DataAccessLayer();
            dal.Open();
            DataTable dt = dal.SelectData("sp_Receipt_SelectAll", null);
            dal.Close();
            return dt;
        }

        public void ADD_Receipt(
            string ReceiptNo,
            string ReceiptType,
            DateTime ReceiptDate,
            string TenantNo,
            decimal Amount,
            string ReferenceNo = null,
            string Narration = null,
            byte BillMonth = 1,
            int? BillYear = null)
        {
            var dal = new DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@ReceiptNo", SqlDbType.NVarChar, 50) { Value = ReceiptNo };
            param[1] = new SqlParameter("@ReceiptType", SqlDbType.NVarChar, 30) { Value = ReceiptType };
            param[2] = new SqlParameter("@ReceiptDate", SqlDbType.Date) { Value = ReceiptDate };
            param[3] = new SqlParameter("@TenantNo", SqlDbType.NVarChar, 50) { Value = TenantNo };
            param[4] = new SqlParameter("@Amount", SqlDbType.Decimal) { Precision = 18, Scale = 2, Value = Amount };
            param[5] = new SqlParameter("@ReferenceNo", SqlDbType.NVarChar, 50) { Value = string.IsNullOrWhiteSpace(ReferenceNo) ? (object)DBNull.Value : ReferenceNo };
            param[6] = new SqlParameter("@Narration", SqlDbType.NVarChar, 500) { Value = string.IsNullOrWhiteSpace(Narration) ? (object)DBNull.Value : Narration };
            param[7] = new SqlParameter("@BillMonth", SqlDbType.TinyInt) { Value = BillMonth };
            param[8] = new SqlParameter("@BillYear", SqlDbType.Int) { Value = BillYear.HasValue ? (object)BillYear.Value : DBNull.Value };

            dal.ExecuteCommand("sp_Receipt_Add", param);
            dal.Close();
        }

        public void UPDATE_Receipt(
            string ReceiptNo,
            string ReceiptType,
            DateTime ReceiptDate,
            string TenantNo,
            decimal Amount,
            string ReferenceNo = null,
            string Narration = null,
            byte BillMonth = 1,
            int? BillYear = null)
        {
            var dal = new DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@ReceiptNo", SqlDbType.NVarChar, 50) { Value = ReceiptNo };
            param[1] = new SqlParameter("@ReceiptType", SqlDbType.NVarChar, 30) { Value = ReceiptType };
            param[2] = new SqlParameter("@ReceiptDate", SqlDbType.Date) { Value = ReceiptDate };
            param[3] = new SqlParameter("@TenantNo", SqlDbType.NVarChar, 50) { Value = TenantNo };
            param[4] = new SqlParameter("@Amount", SqlDbType.Decimal) { Precision = 18, Scale = 2, Value = Amount };
            param[5] = new SqlParameter("@ReferenceNo", SqlDbType.NVarChar, 50) { Value = string.IsNullOrWhiteSpace(ReferenceNo) ? (object)DBNull.Value : ReferenceNo };
            param[6] = new SqlParameter("@Narration", SqlDbType.NVarChar, 500) { Value = string.IsNullOrWhiteSpace(Narration) ? (object)DBNull.Value : Narration };
            param[7] = new SqlParameter("@BillMonth", SqlDbType.TinyInt) { Value = BillMonth };
            param[8] = new SqlParameter("@BillYear", SqlDbType.Int) { Value = BillYear.HasValue ? (object)BillYear.Value : DBNull.Value };

            dal.ExecuteCommand("sp_Receipt_Update", param);
            dal.Close();
        }

        public void DELETE_Receipt(string ReceiptNo)
        {
            var dal = new DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ReceiptNo", SqlDbType.NVarChar, 50) { Value = ReceiptNo };
            dal.ExecuteCommand("sp_Receipt_Delete", param);
            dal.Close();
        }
    }
}
