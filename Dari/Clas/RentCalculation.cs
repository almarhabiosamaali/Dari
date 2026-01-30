using System;
using System.Data;
using System.Data.SqlClient;

namespace Dari.Clas
{
    /// <summary>
    /// احتساب الإيجار - استدعاء sp_GetRentSummaryByProperty (من vw_RentSummary)
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
    }
}
