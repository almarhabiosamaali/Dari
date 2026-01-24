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
    public partial class UC_Buildings : UserControl
    {
        private GridBtnViewHelper gridBtnViewHelper;
        private Buildings buildings;

        public UC_Buildings()
        {
            InitializeComponent();
            
            // التحقق من أن Designer تم تحميله بشكل صحيح
            if (DesignMode)
                return;
            
            // تهيئة الكلاسات
            gridBtnViewHelper = new GridBtnViewHelper();
            buildings = new Buildings();
            
            // ربط أحداث الأزرار
            if (btnSearch != null)
                btnSearch.Click += BtnSearch_Click;
        }
        
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // استدعاء البيانات من قاعدة البيانات
            DataTable dt = buildings.GET_ALL_Buildings();
            
            // عرض البيانات في نافذة البحث الديناميكية
            DataRow row = gridBtnViewHelper.Show(dt, "البحث عن العقارات");
            
            if (row != null)
            {
                // تعبئة البيانات في الحقول
                FillFieldsFromRow(row);
            }
        }
        
        private void FillFieldsFromRow(DataRow row)
        {
            try
            {
                // تعبئة الحقول من البيانات المختارة
                if (row.Table.Columns.Contains("PropertyNo"))
                    txtPropertyNo.Text = row["PropertyNo"]?.ToString() ?? "";
                    
                if (row.Table.Columns.Contains("PropertyName"))
                    txtPropertyName.Text = row["PropertyName"]?.ToString() ?? "";
                    
                if (row.Table.Columns.Contains("PropertyType"))
                {
                    string propertyType = row["PropertyType"]?.ToString() ?? "";
                    // البحث عن النوع في ComboBox
                    for (int i = 0; i < cmbPropertyType.Items.Count; i++)
                    {
                        if (cmbPropertyType.Items[i].ToString() == propertyType)
                        {
                            cmbPropertyType.SelectedIndex = i;
                            break;
                        }
                    }
                }
                    
                if (row.Table.Columns.Contains("Description"))
                    txtDescription.Text = row["Description"]?.ToString() ?? "";
                    
                if (row.Table.Columns.Contains("Address"))
                    txtAddress.Text = row["Address"]?.ToString() ?? "";
                    
                if (row.Table.Columns.Contains("OwnerNo"))
                    txtOwnerNo.Text = row["OwnerNo"]?.ToString() ?? "";
                    
                if (row.Table.Columns.Contains("IsActive"))
                {
                    bool isActive = false;
                    if (row["IsActive"] != DBNull.Value)
                    {
                        bool.TryParse(row["IsActive"].ToString(), out isActive);
                    }
                    chkIsActive.Checked = isActive;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تعبئة البيانات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
