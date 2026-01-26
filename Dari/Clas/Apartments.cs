using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dari.Clas
{
    class Apartments
    {
        // دالة للحصول على بيانات المباني لملء ComboBox
        public DataTable GET_ALL_Properties()
        {
            Clas.DataAccessLayer DAL = new Clas.DataAccessLayer();
            DAL.Open();
            DataTable dt = DAL.SelectData("sp_Property_SelectAll", null);
            DAL.Close();
            return dt;
        }

        // دالة للحصول على جميع بيانات الشقق
        public DataTable GET_ALL_Apartments()
        {
            Clas.DataAccessLayer DAL = new Clas.DataAccessLayer();
            DAL.Open();
            DataTable dt = DAL.SelectData("sp_Apartment_SelectAll", null);
            DAL.Close();
            return dt;
        }

        // دالة للحصول على الرقم التالي للشقة
        public string GET_NEXT_APARTMENT_CODE()
        {
            return AutoNumberHelper.GetNextNumber("Apartments", "ApartmentNo");
        }

        public void ADD_Apartments(string ApartmentNo, string PropertyNo, decimal AreaSqm, string ApartmentType, 
            string ApartmentStatus, string RentStatus, int RoomsCount, int KitchensCount, 
            int BathroomsCount, int FloorNo, string AttachmentPath = null, string AttachmentName = null, 
            string AttachmentType = null, long? AttachmentSize = null)
        {
            Clas.DataAccessLayer DAL = new Clas.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[14];

            param[0] = new SqlParameter("@ApartmentNo", SqlDbType.NVarChar, 50);
            param[0].Value = ApartmentNo;

            param[1] = new SqlParameter("@PropertyNo", SqlDbType.NVarChar, 50);
            param[1].Value = PropertyNo;

            param[2] = new SqlParameter("@AreaSqm", SqlDbType.Decimal);
            param[2].Precision = 10;
            param[2].Scale = 2;
            param[2].Value = AreaSqm;

            param[3] = new SqlParameter("@ApartmentType", SqlDbType.NVarChar, 50);
            param[3].Value = ApartmentType;

            param[4] = new SqlParameter("@ApartmentStatus", SqlDbType.NVarChar, 30);
            param[4].Value = ApartmentStatus;

            param[5] = new SqlParameter("@RentStatus", SqlDbType.NVarChar, 30);
            param[5].Value = RentStatus;

            param[6] = new SqlParameter("@RoomsCount", SqlDbType.Int);
            param[6].Value = RoomsCount;

            param[7] = new SqlParameter("@KitchensCount", SqlDbType.Int);
            param[7].Value = KitchensCount;

            param[8] = new SqlParameter("@BathroomsCount", SqlDbType.Int);
            param[8].Value = BathroomsCount;

            param[9] = new SqlParameter("@FloorNo", SqlDbType.Int);
            param[9].Value = FloorNo;

            param[10] = new SqlParameter("@AttachmentPath", SqlDbType.NVarChar, 500);
            param[10].Value = string.IsNullOrWhiteSpace(AttachmentPath) ? (object)DBNull.Value : AttachmentPath;

            param[11] = new SqlParameter("@AttachmentName", SqlDbType.NVarChar, 255);
            param[11].Value = string.IsNullOrWhiteSpace(AttachmentName) ? (object)DBNull.Value : AttachmentName;

            param[12] = new SqlParameter("@AttachmentType", SqlDbType.NVarChar, 100);
            param[12].Value = string.IsNullOrWhiteSpace(AttachmentType) ? (object)DBNull.Value : AttachmentType;

            param[13] = new SqlParameter("@AttachmentSize", SqlDbType.BigInt);
            param[13].Value = AttachmentSize.HasValue ? (object)AttachmentSize.Value : DBNull.Value;

            DAL.ExecuteCommand("sp_Apartment_Add", param);
            DAL.Close();
        }

        public void UPDATE_Apartments(string ApartmentNo, string PropertyNo, decimal AreaSqm, string ApartmentType,
            string ApartmentStatus, string RentStatus, int RoomsCount, int KitchensCount,
            int BathroomsCount, int FloorNo, string AttachmentPath = null, string AttachmentName = null,
            string AttachmentType = null, long? AttachmentSize = null)
        {
            Clas.DataAccessLayer DAL = new Clas.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[14];

            param[0] = new SqlParameter("@ApartmentNo", SqlDbType.NVarChar, 50);
            param[0].Value = ApartmentNo;

            param[1] = new SqlParameter("@PropertyNo", SqlDbType.NVarChar, 50);
            param[1].Value = PropertyNo;

            param[2] = new SqlParameter("@AreaSqm", SqlDbType.Decimal);
            param[2].Precision = 10;
            param[2].Scale = 2;
            param[2].Value = AreaSqm;

            param[3] = new SqlParameter("@ApartmentType", SqlDbType.NVarChar, 50);
            param[3].Value = ApartmentType;

            param[4] = new SqlParameter("@ApartmentStatus", SqlDbType.NVarChar, 30);
            param[4].Value = ApartmentStatus;

            param[5] = new SqlParameter("@RentStatus", SqlDbType.NVarChar, 30);
            param[5].Value = RentStatus;

            param[6] = new SqlParameter("@RoomsCount", SqlDbType.Int);
            param[6].Value = RoomsCount;

            param[7] = new SqlParameter("@KitchensCount", SqlDbType.Int);
            param[7].Value = KitchensCount;

            param[8] = new SqlParameter("@BathroomsCount", SqlDbType.Int);
            param[8].Value = BathroomsCount;

            param[9] = new SqlParameter("@FloorNo", SqlDbType.Int);
            param[9].Value = FloorNo;

            param[10] = new SqlParameter("@AttachmentPath", SqlDbType.NVarChar, 500);
            param[10].Value = string.IsNullOrWhiteSpace(AttachmentPath) ? (object)DBNull.Value : AttachmentPath;

            param[11] = new SqlParameter("@AttachmentName", SqlDbType.NVarChar, 255);
            param[11].Value = string.IsNullOrWhiteSpace(AttachmentName) ? (object)DBNull.Value : AttachmentName;

            param[12] = new SqlParameter("@AttachmentType", SqlDbType.NVarChar, 100);
            param[12].Value = string.IsNullOrWhiteSpace(AttachmentType) ? (object)DBNull.Value : AttachmentType;

            param[13] = new SqlParameter("@AttachmentSize", SqlDbType.BigInt);
            param[13].Value = AttachmentSize.HasValue ? (object)AttachmentSize.Value : DBNull.Value;

            DAL.ExecuteCommand("sp_Apartment_Update", param);
            DAL.Close();
        }

        public void DELETE_Apartments(string ApartmentNo)
        {
            Clas.DataAccessLayer DAL = new Clas.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ApartmentNo", SqlDbType.NVarChar, 50);
            param[0].Value = ApartmentNo;

            DAL.ExecuteCommand("sp_Apartment_Delete", param);
            DAL.Close();
        }
    }
}
