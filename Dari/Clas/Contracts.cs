using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dari.Clas
{
    class Contracts
    {
        // دالة للحصول على الرقم التالي للعقد
        public string GET_NEXT_CONTRACT_CODE()
        {
            return AutoNumberHelper.GetNextNumber("Contracts", "ContractNo");
        }

        public void ADD_Contracts(string ContractNo, string TenantNo, string ApartmentNo, 
            DateTime StartDate, DateTime EndDate, decimal MonthlyRent, decimal DepositAmount, 
            decimal? OtherFees = null, string ContractStatus = null, string Note = null)
        {
            Clas.DataAccessLayer DAL = new Clas.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@ContractNo", SqlDbType.NVarChar, 50);
            param[0].Value = ContractNo;

            param[1] = new SqlParameter("@TenantNo", SqlDbType.NVarChar, 50);
            param[1].Value = TenantNo;

            param[2] = new SqlParameter("@ApartmentNo", SqlDbType.NVarChar, 50);
            param[2].Value = ApartmentNo;

            param[3] = new SqlParameter("@StartDate", SqlDbType.Date);
            param[3].Value = StartDate;

            param[4] = new SqlParameter("@EndDate", SqlDbType.Date);
            param[4].Value = EndDate;

            param[5] = new SqlParameter("@MonthlyRent", SqlDbType.Decimal);
            param[5].Precision = 18;
            param[5].Scale = 2;
            param[5].Value = MonthlyRent;

            param[6] = new SqlParameter("@DepositAmount", SqlDbType.Decimal);
            param[6].Precision = 18;
            param[6].Scale = 2;
            param[6].Value = DepositAmount;

            param[7] = new SqlParameter("@OtherFees", SqlDbType.Decimal);
            param[7].Precision = 18;
            param[7].Scale = 2;
            param[7].Value = OtherFees.HasValue ? (object)OtherFees.Value : DBNull.Value;

            param[8] = new SqlParameter("@ContractStatus", SqlDbType.NVarChar, 30);
            param[8].Value = ContractStatus;

            param[9] = new SqlParameter("@note", SqlDbType.NVarChar, -1);
            param[9].Value = string.IsNullOrWhiteSpace(Note) ? (object)DBNull.Value : Note;

            DAL.ExecuteCommand("sp_Contract_Add", param);
            DAL.Close();
        }
    }
}
