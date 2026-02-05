using System;
using System.Data;
using System.Data.SqlClient;

namespace Dari.Clas
{
    /// <summary>
    /// جلب بيانات تقرير كشف المستأجر الشهري عبر sp_TenantMonthlyStatement.
    /// </summary>
    public class ReportTenantMonthlyStatement
    {
        /// <summary>
        /// يستدعي sp_TenantMonthlyStatement بمعامل @P_Whr فقط.
        /// </summary>
        public DataTable GetTenantMonthlyStatement(string P_Whr , int TypeTotal)
        {
            var DAL = new DataAccessLayer();
            DAL.Open();
            try
            {
                var param = new SqlParameter[2];
                param[0] = new SqlParameter("@P_Whr", SqlDbType.NVarChar, 500) { Value = string.IsNullOrWhiteSpace(P_Whr) ? (object)DBNull.Value : P_Whr };
                param[1] = new SqlParameter("@TypeTotal", SqlDbType.Int) { Value = TypeTotal };
                return DAL.SelectData("sp_TenantMonthlyStatement", param);
            }
            catch (SqlException)
            {
                return null;
            }
            finally
            {
                DAL.Close();
            }
        }
    }
}
