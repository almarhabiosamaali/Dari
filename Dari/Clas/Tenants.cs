using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dari.Clas
{
    class Tenants
    {
        // دالة للحصول على الرقم التالي للمستأجر
        public string GET_NEXT_TENANT_CODE()
        {
            return AutoNumberHelper.GetNextNumber("Tenants", "TenantNo");
        }

        // دالة للحصول على جميع بيانات المستأجرين
        public DataTable GET_ALL_Tenants()
        {
            Clas.DataAccessLayer DAL = new Clas.DataAccessLayer();
            DAL.Open();
            DataTable dt = DAL.SelectData("sp_Tenant_SelectAll", null);
            DAL.Close();
            return dt;
        }

        public void ADD_Tenants(string TenantNo, string TenantName, string NationalIdNo, string MobileNo,
            DateTime? BirthDate = null, string Nationality = null, string SocialStatus = null,
            string JobTitle = null, string WorkPlace = null, string TenantStatus = null,
            string GuarantorName = null, string GuarantorNationalId = null, string GuarantorMobile = null,
            string GuarantorWorkPlace = null, string CommercialRegNo = null,
            string IdImagePath = null, string ContractImagePath = null, string GuaranteeImagePath = null,
            string GuarantorIdImagePath = null)
        {
            Clas.DataAccessLayer DAL = new Clas.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[19];

            param[0] = new SqlParameter("@TenantNo", SqlDbType.NVarChar, 50);
            param[0].Value = TenantNo;

            param[1] = new SqlParameter("@TenantName", SqlDbType.NVarChar, 200);
            param[1].Value = TenantName;

            param[2] = new SqlParameter("@NationalIdNo", SqlDbType.NVarChar, 50);
            param[2].Value = NationalIdNo;

            param[3] = new SqlParameter("@MobileNo", SqlDbType.NVarChar, 30);
            param[3].Value = MobileNo;

            param[4] = new SqlParameter("@BirthDate", SqlDbType.Date);
            param[4].Value = BirthDate.HasValue ? (object)BirthDate.Value : DBNull.Value;

            param[5] = new SqlParameter("@Nationality", SqlDbType.NVarChar, 50);
            param[5].Value = string.IsNullOrWhiteSpace(Nationality) ? (object)DBNull.Value : Nationality;

            param[6] = new SqlParameter("@SocialStatus", SqlDbType.NVarChar, 30);
            param[6].Value = string.IsNullOrWhiteSpace(SocialStatus) ? (object)DBNull.Value : SocialStatus;

            param[7] = new SqlParameter("@JobTitle", SqlDbType.NVarChar, 100);
            param[7].Value = string.IsNullOrWhiteSpace(JobTitle) ? (object)DBNull.Value : JobTitle;

            param[8] = new SqlParameter("@WorkPlace", SqlDbType.NVarChar, 200);
            param[8].Value = string.IsNullOrWhiteSpace(WorkPlace) ? (object)DBNull.Value : WorkPlace;

            param[9] = new SqlParameter("@TenantStatus", SqlDbType.NVarChar, 30);
            param[9].Value = TenantStatus;

            param[10] = new SqlParameter("@GuarantorName", SqlDbType.NVarChar, 200);
            param[10].Value = string.IsNullOrWhiteSpace(GuarantorName) ? (object)DBNull.Value : GuarantorName;

            param[11] = new SqlParameter("@GuarantorNationalId", SqlDbType.NVarChar, 50);
            param[11].Value = string.IsNullOrWhiteSpace(GuarantorNationalId) ? (object)DBNull.Value : GuarantorNationalId;

            param[12] = new SqlParameter("@GuarantorMobile", SqlDbType.NVarChar, 30);
            param[12].Value = string.IsNullOrWhiteSpace(GuarantorMobile) ? (object)DBNull.Value : GuarantorMobile;

            param[13] = new SqlParameter("@GuarantorWorkPlace", SqlDbType.NVarChar, 200);
            param[13].Value = string.IsNullOrWhiteSpace(GuarantorWorkPlace) ? (object)DBNull.Value : GuarantorWorkPlace;

            param[14] = new SqlParameter("@CommercialRegNo", SqlDbType.NVarChar, 50);
            param[14].Value = string.IsNullOrWhiteSpace(CommercialRegNo) ? (object)DBNull.Value : CommercialRegNo;

            param[15] = new SqlParameter("@IdImagePath", SqlDbType.NVarChar, 500);
            param[15].Value = string.IsNullOrWhiteSpace(IdImagePath) ? (object)DBNull.Value : IdImagePath;

            param[16] = new SqlParameter("@ContractImagePath", SqlDbType.NVarChar, 500);
            param[16].Value = string.IsNullOrWhiteSpace(ContractImagePath) ? (object)DBNull.Value : ContractImagePath;

            param[17] = new SqlParameter("@GuaranteeImagePath", SqlDbType.NVarChar, 500);
            param[17].Value = string.IsNullOrWhiteSpace(GuaranteeImagePath) ? (object)DBNull.Value : GuaranteeImagePath;

            param[18] = new SqlParameter("@GuarantorIdImagePath", SqlDbType.NVarChar, 500);
            param[18].Value = string.IsNullOrWhiteSpace(GuarantorIdImagePath) ? (object)DBNull.Value : GuarantorIdImagePath;

            DAL.ExecuteCommand("sp_Tenant_Add", param);
            DAL.Close();
        }

        public void UPDATE_Tenants(string TenantNo, string TenantName, string NationalIdNo, string MobileNo,
            DateTime? BirthDate = null, string Nationality = null, string SocialStatus = null,
            string JobTitle = null, string WorkPlace = null, string TenantStatus = null,
            string GuarantorName = null, string GuarantorNationalId = null, string GuarantorMobile = null,
            string GuarantorWorkPlace = null, string CommercialRegNo = null,
            string IdImagePath = null, string ContractImagePath = null, string GuaranteeImagePath = null,
            string GuarantorIdImagePath = null)
        {
            Clas.DataAccessLayer DAL = new Clas.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[19];

            param[0] = new SqlParameter("@TenantNo", SqlDbType.NVarChar, 50);
            param[0].Value = TenantNo;

            param[1] = new SqlParameter("@TenantName", SqlDbType.NVarChar, 200);
            param[1].Value = TenantName;

            param[2] = new SqlParameter("@NationalIdNo", SqlDbType.NVarChar, 50);
            param[2].Value = NationalIdNo;

            param[3] = new SqlParameter("@MobileNo", SqlDbType.NVarChar, 30);
            param[3].Value = MobileNo;

            param[4] = new SqlParameter("@BirthDate", SqlDbType.Date);
            param[4].Value = BirthDate.HasValue ? (object)BirthDate.Value : DBNull.Value;

            param[5] = new SqlParameter("@Nationality", SqlDbType.NVarChar, 50);
            param[5].Value = string.IsNullOrWhiteSpace(Nationality) ? (object)DBNull.Value : Nationality;

            param[6] = new SqlParameter("@SocialStatus", SqlDbType.NVarChar, 30);
            param[6].Value = string.IsNullOrWhiteSpace(SocialStatus) ? (object)DBNull.Value : SocialStatus;

            param[7] = new SqlParameter("@JobTitle", SqlDbType.NVarChar, 100);
            param[7].Value = string.IsNullOrWhiteSpace(JobTitle) ? (object)DBNull.Value : JobTitle;

            param[8] = new SqlParameter("@WorkPlace", SqlDbType.NVarChar, 200);
            param[8].Value = string.IsNullOrWhiteSpace(WorkPlace) ? (object)DBNull.Value : WorkPlace;

            param[9] = new SqlParameter("@TenantStatus", SqlDbType.NVarChar, 30);
            param[9].Value = TenantStatus;

            param[10] = new SqlParameter("@GuarantorName", SqlDbType.NVarChar, 200);
            param[10].Value = string.IsNullOrWhiteSpace(GuarantorName) ? (object)DBNull.Value : GuarantorName;

            param[11] = new SqlParameter("@GuarantorNationalId", SqlDbType.NVarChar, 50);
            param[11].Value = string.IsNullOrWhiteSpace(GuarantorNationalId) ? (object)DBNull.Value : GuarantorNationalId;

            param[12] = new SqlParameter("@GuarantorMobile", SqlDbType.NVarChar, 30);
            param[12].Value = string.IsNullOrWhiteSpace(GuarantorMobile) ? (object)DBNull.Value : GuarantorMobile;

            param[13] = new SqlParameter("@GuarantorWorkPlace", SqlDbType.NVarChar, 200);
            param[13].Value = string.IsNullOrWhiteSpace(GuarantorWorkPlace) ? (object)DBNull.Value : GuarantorWorkPlace;

            param[14] = new SqlParameter("@CommercialRegNo", SqlDbType.NVarChar, 50);
            param[14].Value = string.IsNullOrWhiteSpace(CommercialRegNo) ? (object)DBNull.Value : CommercialRegNo;

            param[15] = new SqlParameter("@IdImagePath", SqlDbType.NVarChar, 500);
            param[15].Value = string.IsNullOrWhiteSpace(IdImagePath) ? (object)DBNull.Value : IdImagePath;

            param[16] = new SqlParameter("@ContractImagePath", SqlDbType.NVarChar, 500);
            param[16].Value = string.IsNullOrWhiteSpace(ContractImagePath) ? (object)DBNull.Value : ContractImagePath;

            param[17] = new SqlParameter("@GuaranteeImagePath", SqlDbType.NVarChar, 500);
            param[17].Value = string.IsNullOrWhiteSpace(GuaranteeImagePath) ? (object)DBNull.Value : GuaranteeImagePath;

            param[18] = new SqlParameter("@GuarantorIdImagePath", SqlDbType.NVarChar, 500);
            param[18].Value = string.IsNullOrWhiteSpace(GuarantorIdImagePath) ? (object)DBNull.Value : GuarantorIdImagePath;

            DAL.ExecuteCommand("sp_Tenant_Update", param);
            DAL.Close();
        }
    }
}
