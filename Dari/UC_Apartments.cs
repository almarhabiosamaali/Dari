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
    public partial class UC_Apartments : UserControl
    {
        private Buildings buildings;

        public UC_Apartments()
        {
            InitializeComponent();
            
            // التحقق من أن Designer تم تحميله بشكل صحيح
            if (DesignMode)
                return;
            
            // تهيئة الكلاسات
            buildings = new Buildings();
            
            // ملء ComboBox الخاص برقم العقار
            LoadPropertiesComboBox();
            
            // ربط أحداث الأزرار
            if (btnClose != null)
                btnClose.Click += BtnClose_Click;
        }

        private void LoadPropertiesComboBox()
        {
            try
            {
                // الحصول على بيانات المباني
                DataTable dt = buildings.GET_ALL_Buildings();
                
                // إضافة صف فارغ في بداية الجدول
                DataRow emptyRow = dt.NewRow();
                emptyRow["PropertyNo"] = "";
                emptyRow["PropertyName"] = "";
                dt.Rows.InsertAt(emptyRow, 0);
                
                // ملء ComboBox
                cmbPropertyNo.DataSource = dt;
                cmbPropertyNo.DisplayMember = "PropertyName";  // يعرض اسم المبنى
                cmbPropertyNo.ValueMember = "PropertyNo";       // القيمة المرسلة هي رقم المبنى
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل بيانات المباني: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
