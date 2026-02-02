using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dari.Clas
{
    class FinancialMovements
    {
        public void ADD_FinancialMovements(
    string MovementType,
    string DocumentNo,
    string DocumentType,
    DateTime DocumentDate,
    int BillYear,
    int BillMonth,
    string TenantNo,
    string ApartmentNo,
    decimal? Debit,
    decimal Credit,
    string Notes = null
)
        {
            Clas.DataAccessLayer DAL = new Clas.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@MovementType", SqlDbType.NVarChar, 50);
            param[0].Value = MovementType;

            param[1] = new SqlParameter("@DocumentNo", SqlDbType.NVarChar, 50);
            param[1].Value = DocumentNo;

            param[2] = new SqlParameter("@DocumentType", SqlDbType.NVarChar, 50);
            param[2].Value = DocumentType;

            param[3] = new SqlParameter("@DocumentDate", SqlDbType.Date);
            param[3].Value = DocumentDate;

            param[4] = new SqlParameter("@BillYear", SqlDbType.Int);
            param[4].Value = BillYear;

            param[5] = new SqlParameter("@BillMonth", SqlDbType.Int);
            param[5].Value = BillMonth;

            

            

            param[6] = new SqlParameter("@TenantNo", SqlDbType.NVarChar, 50);
            param[6].Value = TenantNo;

            param[7] = new SqlParameter("@ApartmentNo", SqlDbType.NVarChar, 50);
            param[7].Value = ApartmentNo;
            

            // 👇 بدون Precision و Scale
            param[8] = new SqlParameter("@Debit", SqlDbType.Decimal);
            param[8].Value = Debit;

            param[9] = new SqlParameter("@Credit", SqlDbType.Decimal);
            param[9].Value = Credit;

            param[10] = new SqlParameter("@Notes", SqlDbType.NVarChar, 255);
            param[10].Value = string.IsNullOrWhiteSpace(Notes)
                                ? (object)DBNull.Value
                                : Notes;

            DAL.ExecuteCommand("sp_FinancialMovements_Add", param);
            DAL.Close();
        }


        public void DELETE_FinancialMovements(string MovementType, string DocumentNo)
        {
            Clas.DataAccessLayer DAL = new Clas.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@MovementType", SqlDbType.NVarChar, 50);
            param[0].Value = MovementType;

            param[1] = new SqlParameter("@DocumentNo", SqlDbType.NVarChar, 50);
            param[1].Value = DocumentNo;

            DAL.ExecuteCommand("sp_FinancialMovements_Delete", param);
            DAL.Close();
        }

    }
}
