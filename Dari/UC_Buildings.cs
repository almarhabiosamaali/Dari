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
            if (btnSave != null)
                btnSave.Click += BtnSave_Click;
        }
        
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string propertyNo = (txtPropertyNo?.Text ?? string.Empty).Trim();
                string propertyName = (txtPropertyName?.Text ?? string.Empty).Trim();
                string propertyType = (cmbPropertyType?.SelectedItem?.ToString() ?? cmbPropertyType?.Text ?? string.Empty).Trim();
                string description = (txtDescription?.Text ?? string.Empty).Trim();
                string address = (txtAddress?.Text ?? string.Empty).Trim();
                string ownerNo = (txtOwnerNo?.Text ?? string.Empty).Trim();

                if (string.IsNullOrWhiteSpace(propertyNo) ||
                    string.IsNullOrWhiteSpace(propertyName) ||
                    string.IsNullOrWhiteSpace(propertyType) ||
                    string.IsNullOrWhiteSpace(address) ||
                    string.IsNullOrWhiteSpace(ownerNo))
                {
                    MessageBox.Show(
                        "الرجاء تعبئة الحقول الإلزامية: رقم العقار، اسم العقار، نوع العقار، العنوان، رقم مالك العقار.",
                        "تنبيه",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                buildings.ADD_Buildings(propertyNo, propertyName, propertyType, description, address, ownerNo);

                
                MessageBox.Show("تم حفظ بيانات العقار بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الحفظ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            if (txtPropertyNo != null) txtPropertyNo.Text = string.Empty;
            if (txtPropertyName != null) txtPropertyName.Text = string.Empty;
            if (txtDescription != null) txtDescription.Text = string.Empty;
            if (txtAddress != null) txtAddress.Text = string.Empty;
            if (txtOwnerNo != null) txtOwnerNo.Text = string.Empty;

            if (cmbPropertyType != null)
            {
                cmbPropertyType.SelectedIndex = -1;
                cmbPropertyType.Text = string.Empty;
            }

            if (chkIsActive != null)
                chkIsActive.Checked = false;

            txtPropertyNo?.Focus();
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
