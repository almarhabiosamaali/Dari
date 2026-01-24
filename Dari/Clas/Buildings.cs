using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dari.Clas
{
    class Buildings
    {
        public DataTable GET_ALL_Buildings()
        {
            Clas.DataAccessLayer DAL = new Clas.DataAccessLayer();
            DAL.Open();
            DataTable dt = DAL.SelectData("sp_Property_SelectAll", null);
            DAL.Close();
            return dt;
        }

        public string GET_NEXT_PROPERTY_CODE()
        {
            return AutoNumberHelper.GetNextNumber("Properties", "PropertyNo");
        }


        public void ADD_Buildings(string PropertyNo, string PropertyName, string PropertyType, string Description, string Address, string OwnerNo)
        {
            Clas.DataAccessLayer DAL = new Clas.DataAccessLayer();
            DAL.Open(); 
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@PropertyNo", SqlDbType.VarChar, 50);
            param[0].Value = PropertyNo;

            param[1] = new SqlParameter("@PropertyName", SqlDbType.VarChar, 200);
            param[1].Value = PropertyName;

            param[2] = new SqlParameter("@PropertyType", SqlDbType.VarChar, 50);
            param[2].Value = PropertyType;

            param[3] = new SqlParameter("@Description", SqlDbType.VarChar, 1000);
            param[3].Value = Description;

            param[4] = new SqlParameter("@Address", SqlDbType.VarChar, 300);
            param[4].Value = Address;

            param[5] = new SqlParameter("@OwnerNo", SqlDbType.VarChar, 50);
            param[5].Value = OwnerNo;

            DAL.ExecuteCommand("sp_Property_Add", param);
            DAL.Close();
        }

        public void UPDATE_Buildings(string PropertyNo, string PropertyName, string PropertyType, string Description, string Address, string OwnerNo)
        {
            Clas.DataAccessLayer DAL = new Clas.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@PropertyNo", SqlDbType.NVarChar, 50);
            param[0].Value = PropertyNo;

            param[1] = new SqlParameter("@PropertyName", SqlDbType.NVarChar, 200);
            param[1].Value = PropertyName;

            param[2] = new SqlParameter("@PropertyType", SqlDbType.NVarChar, 50);
            param[2].Value = PropertyType;

            param[3] = new SqlParameter("@Description", SqlDbType.NVarChar, 1000);
            param[3].Value = string.IsNullOrWhiteSpace(Description) ? (object)DBNull.Value : Description;

            param[4] = new SqlParameter("@Address", SqlDbType.NVarChar, 300);
            param[4].Value = Address;

            param[5] = new SqlParameter("@OwnerNo", SqlDbType.NVarChar, 50);
            param[5].Value = OwnerNo;

            DAL.ExecuteCommand("sp_Property_Update", param);
            DAL.Close();
        }
    }
}
