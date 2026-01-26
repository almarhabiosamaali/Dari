using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using MaterialSkin;
using MaterialSkin.Controls;
using Dari.Clas;

namespace Dari
{
    public partial class UC_Contracts : UserControl
    {
        private GridBtnViewHelper gridBtnViewHelper;
        private Tenants tenants;
        private Apartments apartments;

        public UC_Contracts()
        {
            InitializeComponent();
            
            // التحقق من أن Designer تم تحميله بشكل صحيح
            if (DesignMode)
                return;
            
            // تهيئة الكلاسات
            gridBtnViewHelper = new GridBtnViewHelper();
            tenants = new Tenants();
            apartments = new Apartments();
            
            // ربط أحداث الأزرار
            if (btnClose != null)
                btnClose.Click += BtnClose_Click;
            
            // ربط أحداث KeyDown للحقول
            if (txtTenantNo != null)
            {
                txtTenantNo.KeyDown += TxtTenantNo_KeyDown;
                txtTenantNo.Enter += TxtTenantNo_Enter;
            }
            
            if (txtApartmentNo != null)
            {
                txtApartmentNo.KeyDown += TxtApartmentNo_KeyDown;
                txtApartmentNo.Enter += TxtApartmentNo_Enter;
            }
        }

        private void TxtTenantNo_Enter(object sender, EventArgs e)
        {
            // عند الدخول للحقل، نمنع الكتابة المباشرة
            if (txtTenantNo != null)
            {
                txtTenantNo.ReadOnly = true;
            }
        }

        private void TxtTenantNo_KeyDown(object sender, KeyEventArgs e)
        {
            // عند الضغط على أي مفتاح، نفتح popup البحث
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F2 || e.KeyCode == Keys.Space || 
                (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) || 
                (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                OpenTenantSearchPopup();
            }
        }

        private void TxtApartmentNo_Enter(object sender, EventArgs e)
        {
            // عند الدخول للحقل، نمنع الكتابة المباشرة
            if (txtApartmentNo != null)
            {
                txtApartmentNo.ReadOnly = true;
            }
        }

        private void TxtApartmentNo_KeyDown(object sender, KeyEventArgs e)
        {
            // عند الضغط على أي مفتاح، نفتح popup البحث
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F2 || e.KeyCode == Keys.Space || 
                (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) || 
                (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                OpenApartmentSearchPopup();
            }
        }

        private void OpenTenantSearchPopup()
        {
            try
            {
                // استدعاء بيانات المستأجرين
                DataTable dt = tenants.GET_ALL_Tenants();
                
                // عرض البيانات في نافذة البحث
                DataRow row = gridBtnViewHelper.Show(dt, "البحث عن المستأجرين");
                
                if (row != null)
                {
                    // الحصول على رقم المستأجر واسمه
                    string tenantNo = row.Table.Columns.Contains("TenantNo") 
                        ? (row["TenantNo"]?.ToString() ?? "") 
                        : "";
                    string tenantName = row.Table.Columns.Contains("TenantName") 
                        ? (row["TenantName"]?.ToString() ?? "") 
                        : "";
                    
                    if (!string.IsNullOrWhiteSpace(tenantNo))
                    {
                        // حفظ رقم المستأجر في Tag
                        txtTenantNo.Tag = tenantNo;
                        
                        // عرض اسم المستأجر في الحقل
                        txtTenantNo.Text = tenantName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء البحث عن المستأجرين: {ex.Message}", "خطأ", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenApartmentSearchPopup()
        {
            try
            {
                // استدعاء بيانات الشقق
                DataTable dt = apartments.GET_ALL_Apartments();
                
                // عرض البيانات في نافذة البحث
                DataRow row = gridBtnViewHelper.Show(dt, "البحث عن الشقق");
                
                if (row != null)
                {
                    // الحصول على رقم الشقة
                    string apartmentNo = row.Table.Columns.Contains("ApartmentNo") 
                        ? (row["ApartmentNo"]?.ToString() ?? "") 
                        : "";
                    
                    if (!string.IsNullOrWhiteSpace(apartmentNo))
                    {
                        // عرض رقم الشقة في الحقل
                        txtApartmentNo.Text = apartmentNo;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء البحث عن الشقق: {ex.Message}", "خطأ", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            // رجوع للشاشة الرئيسية (Form1)
            if (FindForm() is Form1 mainForm)
            {
                mainForm.ShowHome();
                return;
            }

            // كحل احتياطي: إخفاء الشاشة الحالية
            this.Visible = false;
        }
    }
}
