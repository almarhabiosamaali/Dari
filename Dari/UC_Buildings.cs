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
        private bool isFieldsEditable = false;
        private bool isEditMode = false;

        public UC_Buildings()
        {
            InitializeComponent();
            
            // التحقق من أن Designer تم تحميله بشكل صحيح
            if (DesignMode)
                return;
            
            // تهيئة الكلاسات
            gridBtnViewHelper = new GridBtnViewHelper();
            buildings = new Buildings();

            WireReadOnlyFocusGuards();

            // افتراضيًا: كل الحقول للقراءة فقط (وتتفعل عند الضغط على "إضافة")
            SetFieldsEditable(false);
            SetEditMode(false);
            
            // ربط أحداث الأزرار
            if (btnSearch != null)
                btnSearch.Click += BtnSearch_Click;
            if (btnSave != null)
                btnSave.Click += BtnSave_Click;
            if (btnAdd != null)
                btnAdd.Click += BtnAdd_Click;
            if (btnEdit != null)
                btnEdit.Click += BtnEdit_Click;
            if (btnDelete != null)
                btnDelete.Click += BtnDelete_Click;
        }
        
        private void SetEditMode(bool editMode)
        {
            isEditMode = editMode;
            if (btnSave != null)
                btnSave.Text = editMode ? "تحديث" : "حفظ";
        }

        private void WireReadOnlyFocusGuards()
        {
            // منع الفوكس على الحقول عندما تكون ReadOnly (حتى عند الضغط بالماوس)
            if (txtPropertyNo != null) txtPropertyNo.Enter += PreventFocusWhenReadOnly;
            if (txtPropertyName != null) txtPropertyName.Enter += PreventFocusWhenReadOnly;
            if (txtDescription != null) txtDescription.Enter += PreventFocusWhenReadOnly;
            if (txtAddress != null) txtAddress.Enter += PreventFocusWhenReadOnly;
            if (txtOwnerNo != null) txtOwnerNo.Enter += PreventFocusWhenReadOnly;
        }

        private void PreventFocusWhenReadOnly(object sender, EventArgs e)
        {
            if (isFieldsEditable)
                return;

            // إذا كانت الشاشة في وضع ReadOnly، انقل الفوكس لأقرب عنصر مناسب (مثل زر الإضافة)
            if (btnAdd != null && btnAdd.CanSelect)
            {
                btnAdd.Select();
                return;
            }

            if (sender is Control c)
                SelectNextControl(c, true, true, true, true);
        }

        private void SetFieldsEditable(bool isEditable)
        {
            isFieldsEditable = isEditable;

            // رقم العقار: افتراضيًا للقراءة فقط (يتفعل فقط في حالة أول مرة)
            SetPropertyNoEditable(false);

            if (txtPropertyName != null) { txtPropertyName.ReadOnly = !isEditable; txtPropertyName.TabStop = isEditable; }
            if (txtDescription != null) { txtDescription.ReadOnly = !isEditable; txtDescription.TabStop = isEditable; }
            if (txtAddress != null) { txtAddress.ReadOnly = !isEditable; txtAddress.TabStop = isEditable; }
            if (txtOwnerNo != null) { txtOwnerNo.ReadOnly = !isEditable; txtOwnerNo.TabStop = isEditable; }

            if (cmbPropertyType != null) cmbPropertyType.Enabled = isEditable;

            if (chkIsActive != null)
            {
                chkIsActive.Enabled = isEditable;
                chkIsActive.ReadOnly = !isEditable;
            }
        }

        private void SetPropertyNoEditable(bool isEditable)
        {
            if (txtPropertyNo == null)
                return;

            txtPropertyNo.ReadOnly = !isEditable;
            txtPropertyNo.TabStop = isEditable;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SetEditMode(false);
            ClearFields();
            SetFieldsEditable(true);

            try
            {
                string nextId = buildings.GET_NEXT_PROPERTY_CODE();

                // إذا لم يوجد رقم سابق (أول مرة/لا توجد بيانات رقمية) نخلي المستخدم يدخل الرقم يدوياً
                if (nextId == "1")
                {
                    SetPropertyNoEditable(true);
                    MessageBox.Show(
                        "لا يوجد رقم سابق للعقار.\nالرجاء إدخال رقم العقار يدوياً لأول مرة، وسيتم توليد الرقم التالي تلقائياً لاحقاً.",
                        "تنبيه",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    txtPropertyNo?.Focus();
                    return;
                }

                if (txtPropertyNo != null)
                    txtPropertyNo.Text = nextId;
                SetPropertyNoEditable(false);

                txtPropertyName?.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء توليد الرقم: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                if (isEditMode)
                {
                    buildings.UPDATE_Buildings(propertyNo, propertyName, propertyType, description, address, ownerNo);
                    MessageBox.Show("تم تحديث بيانات العقار بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    buildings.ADD_Buildings(propertyNo, propertyName, propertyType, description, address, ownerNo);
                    MessageBox.Show("تم حفظ بيانات العقار بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ClearFields();
                SetFieldsEditable(false);
                SetEditMode(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الحفظ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            // لا يمكن التعديل بدون اختيار سجل (رقم عقار)
            string propertyNo = (txtPropertyNo?.Text ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(propertyNo))
            {
                MessageBox.Show("الرجاء اختيار عقار أولاً عن طريق زر البحث.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetEditMode(true);
            SetFieldsEditable(true);

            // رقم العقار لا يتعدل
            SetPropertyNoEditable(false);

            txtPropertyName?.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string propertyNo = (txtPropertyNo?.Text ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(propertyNo))
            {
                MessageBox.Show("الرجاء اختيار عقار أولاً عن طريق زر البحث.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"هل أنت متأكد من حذف العقار رقم ({propertyNo})؟",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                buildings.DELETE_Buildings(propertyNo);
                MessageBox.Show("تم حذف العقار بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                SetFieldsEditable(false);
                SetEditMode(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الحذف: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // لا تعطي فوكس لحقل ReadOnly
            if (isFieldsEditable && txtPropertyNo != null && !txtPropertyNo.ReadOnly)
                txtPropertyNo.Focus();
            else if (btnAdd != null && btnAdd.CanSelect)
                btnAdd.Select();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SetEditMode(false);
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
                SetEditMode(false);
                SetFieldsEditable(false);

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
