using System;

namespace Dari.Clas
{
    /// <summary>
    /// بيانات المستخدم الحالي بعد تسجيل الدخول.
    /// </summary>
    public static class CurrentUser
    {
        public static int? ID { get; set; }
        public static string SignInName { get; set; }
        public static string FullName { get; set; }
        public static string UserType { get; set; }

        public static void SetFromRow(System.Data.DataRow row)
        {
            if (row == null) return;
            ID = row.Table.Columns.Contains("ID") && row["ID"] != DBNull.Value ? Convert.ToInt32(row["ID"]) : (int?)null;
            SignInName = row.Table.Columns.Contains("SignInName") ? row["SignInName"]?.ToString() : null;
            FullName = row.Table.Columns.Contains("FullName") ? row["FullName"]?.ToString() : null;
            UserType = row.Table.Columns.Contains("UserType") ? row["UserType"]?.ToString() : null;
        }

        public static void Clear()
        {
            ID = null;
            SignInName = null;
            FullName = null;
            UserType = null;
        }

        public static bool IsLoggedIn => ID.HasValue;

        /// <summary>
        /// عند true: بعد إغلاق شاشة الدخول يتم عرض شاشة إعدادات الاتصال (دخول ADMIN/ADMIN@123).
        /// </summary>
        public static bool ShowConnectionSettingsNext { get; set; }
    }
}
