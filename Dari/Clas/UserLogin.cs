using System;
using System.Data;
using System.Data.SqlClient;

namespace Dari.Clas
{
    /// <summary>
    /// استدعاء إجراء تسجيل الدخول user_login والتحقق من المستخدم.
    /// </summary>
    public class UserLogin
    {
        /// <summary>
        /// يستدعي [user_login] بالمعاملين @SignInName و @PWD.
        /// يعيد DataTable يحتوي على صف المستخدم عند النجاح، أو فارغ عند الفشل.
        /// </summary>
        public DataTable Login(string signInName, string pwd)
        {
            var DAL = new DataAccessLayer();
            DAL.Open();
            try
            {
                var param = new SqlParameter[2];
                param[0] = new SqlParameter("@SignInName", SqlDbType.VarChar, 50) { Value = string.IsNullOrEmpty(signInName) ? (object)DBNull.Value : signInName };
                param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50) { Value = string.IsNullOrEmpty(pwd) ? (object)DBNull.Value : pwd };
                return DAL.SelectData("user_login", param);
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
