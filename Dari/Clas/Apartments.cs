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

        // دالة للحصول على الرقم التالي للشقة
        public string GET_NEXT_APARTMENT_CODE()
        {
            return AutoNumberHelper.GetNextNumber("Apartments", "ApartmentNo");
        }
    }
}
