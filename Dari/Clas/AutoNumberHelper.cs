using System;
using System.Data;

namespace Dari.Clas
{
    /// <summary>
    /// كلاس مساعد موحد لتوليد الأرقام التلقائية من قاعدة البيانات
    /// </summary>
    public static class AutoNumberHelper
    {
        /// <summary>
        /// الحصول على الرقم التالي التلقائي من جدول معين.
        /// ملاحظة: يعتمد على MAX للأرقام القابلة للتحويل إلى INT.
        /// </summary>
        /// <param name="tableName">اسم الجدول (مثال: "Properties")</param>
        /// <param name="columnName">اسم العمود (مثال: "PropertyNo")</param>
        /// <param name="schemaName">اسم الـ Schema (افتراضي: "dbo")</param>
        /// <param name="databaseName">اسم قاعدة البيانات (افتراضي: "Dari")</param>
        /// <returns>الرقم التالي كـ string، وفي حال عدم وجود بيانات/خطأ يرجع "1"</returns>
        public static string GetNextNumber(string tableName, string columnName, string schemaName = "dbo", string databaseName = "Dari")
        {
            try
            {
                var dal = new DataAccessLayer();
                dal.Open();

                string table = EscapeIdentifier(tableName);
                string column = EscapeIdentifier(columnName);
                string schema = EscapeIdentifier(schemaName);
                string database = string.IsNullOrWhiteSpace(databaseName) ? string.Empty : EscapeIdentifier(databaseName);

                // TRY_CONVERT يتجنب مشاكل ISNUMERIC (مثل 1e4) ويُرجع NULL عند الفشل.
                string sqlQuery;
                if (string.IsNullOrWhiteSpace(database))
                {
                    sqlQuery = $"SELECT ISNULL(MAX(TRY_CONVERT(INT, [{column}])), 0) + 1 AS NextNumber FROM [{schema}].[{table}]";
                }
                else
                {
                    sqlQuery = $"SELECT ISNULL(MAX(TRY_CONVERT(INT, [{column}])), 0) + 1 AS NextNumber FROM [{database}].[{schema}].[{table}]";
                }

                object result = dal.ExecuteScalar(sqlQuery);
                dal.Close();

                if (result != null && result != DBNull.Value)
                    return result.ToString();

                return "1";
            }
            catch
            {
                return "1";
            }
        }

        private static string EscapeIdentifier(string value)
        {
            return (value ?? string.Empty).Replace("]", "]]");
        }
    }
}
