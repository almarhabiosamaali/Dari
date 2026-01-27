using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dari.Clas
{
    public static class FileHelper
    {
        // المسار الأساسي للمرفقات
        private static readonly string BASE_ATTACHMENTS_PATH = @"C:\Dari\Attachments";

        /// <summary>
        /// الحصول على المسار الكامل لمجلد المرفقات لنوع معين
        /// </summary>
        /// <param name="folderType">نوع المجلد (Tenants, Apartments, etc.)</param>
        /// <returns>المسار الكامل للمجلد</returns>
        public static string GetAttachmentsFolderPath(string folderType)
        {
            string folderPath = Path.Combine(BASE_ATTACHMENTS_PATH, folderType);
            
            // إنشاء المجلد إذا لم يكن موجوداً
            if (!Directory.Exists(folderPath))
            {
                try
                {
                    Directory.CreateDirectory(folderPath);
                }
                catch (Exception ex)
                {
                    throw new Exception($"فشل في إنشاء مجلد المرفقات: {ex.Message}");
                }
            }
            
            return folderPath;
        }

        /// <summary>
        /// نسخ الملف إلى مجلد المرفقات وإرجاع المسار الكامل
        /// </summary>
        /// <param name="sourceFilePath">مسار الملف الأصلي</param>
        /// <param name="folderType">نوع المجلد (Tenants, Apartments, etc.)</param>
        /// <param name="fileName">اسم الملف الجديد (اختياري - إذا لم يتم تحديده، سيتم استخدام اسم الملف الأصلي)</param>
        /// <returns>المسار الكامل للملف المنسوخ</returns>
        public static string CopyFileToAttachments(string sourceFilePath, string folderType, string fileName = null)
        {
            if (string.IsNullOrWhiteSpace(sourceFilePath) || !File.Exists(sourceFilePath))
            {
                throw new Exception("الملف المحدد غير موجود.");
            }

            try
            {
                string folderPath = GetAttachmentsFolderPath(folderType);
                
                // إذا لم يتم تحديد اسم الملف، استخدم اسم الملف الأصلي
                if (string.IsNullOrWhiteSpace(fileName))
                {
                    fileName = Path.GetFileName(sourceFilePath);
                }

                // إضافة timestamp لضمان عدم التكرار
                string fileExtension = Path.GetExtension(fileName);
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string uniqueFileName = $"{fileNameWithoutExtension}_{timestamp}{fileExtension}";
                
                string destinationPath = Path.Combine(folderPath, uniqueFileName);
                
                // نسخ الملف
                File.Copy(sourceFilePath, destinationPath, true);
                
                return destinationPath;
            }
            catch (Exception ex)
            {
                throw new Exception($"فشل في نسخ الملف: {ex.Message}");
            }
        }

        /// <summary>
        /// حذف ملف من مجلد المرفقات
        /// </summary>
        /// <param name="filePath">المسار الكامل للملف</param>
        public static void DeleteAttachmentFile(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                return;

            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"فشل في حذف الملف: {ex.Message}");
            }
        }

        /// <summary>
        /// فتح ملف باستخدام التطبيق الافتراضي
        /// </summary>
        /// <param name="filePath">المسار الكامل للملف</param>
        public static void OpenFile(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("لم يتم تحديد ملف للفتح.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("الملف المحدد غير موجود.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                System.Diagnostics.Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"فشل في فتح الملف: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// فتح حوار اختيار الملف
        /// </summary>
        /// <param name="title">عنوان الحوار</param>
        /// <param name="filter">فلتر الملفات (مثال: "جميع الملفات|*.*|صور|*.jpg;*.png|PDF|*.pdf")</param>
        /// <returns>مسار الملف المختار أو null إذا تم الإلغاء</returns>
        public static string BrowseFile(string title = "اختر ملف", string filter = "جميع الملفات|*.*")
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = title;
                openFileDialog.Filter = filter;
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }

            return null;
        }

        /// <summary>
        /// الحصول على اسم الملف من المسار الكامل
        /// </summary>
        /// <param name="filePath">المسار الكامل</param>
        /// <returns>اسم الملف فقط</returns>
        public static string GetFileName(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                return string.Empty;

            return Path.GetFileName(filePath);
        }

        /// <summary>
        /// الحصول على حجم الملف بالكيلوبايت
        /// </summary>
        /// <param name="filePath">المسار الكامل للملف</param>
        /// <returns>حجم الملف بالكيلوبايت</returns>
        public static long GetFileSize(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
                return 0;

            try
            {
                FileInfo fileInfo = new FileInfo(filePath);
                return fileInfo.Length; // بالبايت
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// الحصول على نوع الملف (الامتداد)
        /// </summary>
        /// <param name="filePath">المسار الكامل للملف</param>
        /// <returns>نوع الملف (مثال: .pdf, .jpg)</returns>
        public static string GetFileType(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                return string.Empty;

            return Path.GetExtension(filePath);
        }
    }
}
