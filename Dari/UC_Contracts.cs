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
        private Contracts contracts;
        private bool isFieldsEditable = false;
        private bool isEditMode = false;

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
            contracts = new Contracts();
            
            // افتراضيًا: كل الحقول للقراءة فقط
            SetFieldsEditable(false);
            SetEditMode(false);
            
            // ربط أحداث الأزرار
            if (btnClose != null)
                btnClose.Click += BtnClose_Click;
            if (btnAdd != null)
                btnAdd.Click += BtnAdd_Click;
            if (btnSave != null)
                btnSave.Click += BtnSave_Click;
            
            // ربط أحداث KeyDown للحقول (يجب أن يكون قبل WireReadOnlyFocusGuards)
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
            
            // ربط أحداث منع الفوكس على الحقول في وضع ReadOnly (يجب أن يكون بعد ربط الأحداث الأخرى)
            WireReadOnlyFocusGuards();
        }

        private void TxtTenantNo_Enter(object sender, EventArgs e)
        {
            // عند الدخول للحقل، نمنع الكتابة المباشرة (فقط عندما تكون الحقول قابلة للتحرير)
            if (txtTenantNo != null && isFieldsEditable)
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
            // عند الدخول للحقل، نمنع الكتابة المباشرة (فقط عندما تكون الحقول قابلة للتحرير)
            if (txtApartmentNo != null && isFieldsEditable)
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

        private void WireReadOnlyFocusGuards()
        {
            // منع الفوكس على الحقول عندما تكون ReadOnly (حتى عند الضغط بالماوس)
            // ملاحظة: txtTenantNo و txtApartmentNo لهما أحداث Enter خاصة (TxtTenantNo_Enter و TxtApartmentNo_Enter)
            // لذا سنربط PreventFocusWhenReadOnly أيضاً، لكن TxtTenantNo_Enter و TxtApartmentNo_Enter سيتحققان من isFieldsEditable أولاً
            if (txtContractNo != null) txtContractNo.Enter += PreventFocusWhenReadOnly;
            if (txtTenantNo != null) txtTenantNo.Enter += PreventFocusWhenReadOnly;
            if (txtApartmentNo != null) txtApartmentNo.Enter += PreventFocusWhenReadOnly;
            if (dtpStartDate != null) dtpStartDate.Enter += PreventFocusWhenReadOnly;
            if (dtpEndDate != null) dtpEndDate.Enter += PreventFocusWhenReadOnly;
            if (txtMonthlyRent != null) txtMonthlyRent.Enter += PreventFocusWhenReadOnly;
            if (txtDepositAmount != null) txtDepositAmount.Enter += PreventFocusWhenReadOnly;
            if (txtOtherFees != null) txtOtherFees.Enter += PreventFocusWhenReadOnly;
            if (cmbContractStatus != null) cmbContractStatus.Enter += PreventFocusWhenReadOnly;
            if (txtNote != null) txtNote.Enter += PreventFocusWhenReadOnly;
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

        private void SetEditMode(bool editMode)
        {
            isEditMode = editMode;
            if (btnSave != null)
                btnSave.Text = editMode ? "تحديث" : "حفظ";
        }

        private void SetFieldsEditable(bool isEditable)
        {
            isFieldsEditable = isEditable;

            // رقم العقد: افتراضيًا للقراءة فقط (يتفعل فقط في حالة أول مرة)
            SetContractNoEditable(false);

            if (txtTenantNo != null) { txtTenantNo.ReadOnly = !isEditable; txtTenantNo.TabStop = isEditable; }
            if (txtApartmentNo != null) { txtApartmentNo.ReadOnly = !isEditable; txtApartmentNo.TabStop = isEditable; }
            if (dtpStartDate != null) dtpStartDate.Enabled = isEditable;
            if (dtpEndDate != null) dtpEndDate.Enabled = isEditable;
            if (txtMonthlyRent != null) { txtMonthlyRent.ReadOnly = !isEditable; txtMonthlyRent.TabStop = isEditable; }
            if (txtDepositAmount != null) { txtDepositAmount.ReadOnly = !isEditable; txtDepositAmount.TabStop = isEditable; }
            if (txtOtherFees != null) { txtOtherFees.ReadOnly = !isEditable; txtOtherFees.TabStop = isEditable; }
            if (cmbContractStatus != null) cmbContractStatus.Enabled = isEditable;
            if (txtNote != null) { txtNote.ReadOnly = !isEditable; txtNote.Enabled = isEditable; }
        }

        private void SetContractNoEditable(bool isEditable)
        {
            if (txtContractNo == null)
                return;

            txtContractNo.ReadOnly = !isEditable;
            txtContractNo.TabStop = isEditable;
        }

        private void ClearFields()
        {
            if (txtContractNo != null) txtContractNo.Text = string.Empty;
            if (txtTenantNo != null) 
            { 
                txtTenantNo.Text = string.Empty;
                txtTenantNo.Tag = null;
            }
            if (txtApartmentNo != null) txtApartmentNo.Text = string.Empty;
            if (dtpStartDate != null) dtpStartDate.Value = DateTime.Now;
            if (dtpEndDate != null) dtpEndDate.Value = DateTime.Now;
            if (txtMonthlyRent != null) txtMonthlyRent.Text = string.Empty;
            if (txtDepositAmount != null) txtDepositAmount.Text = string.Empty;
            if (txtOtherFees != null) txtOtherFees.Text = string.Empty;
            if (cmbContractStatus != null) cmbContractStatus.SelectedIndex = -1;
            if (txtNote != null) txtNote.Text = string.Empty;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SetEditMode(false);
            ClearFields();
            SetFieldsEditable(true);

            try
            {
                string nextId = contracts.GET_NEXT_CONTRACT_CODE();

                // إذا لم يوجد رقم سابق (أول مرة/لا توجد بيانات رقمية) نخلي المستخدم يدخل الرقم يدوياً
                if (nextId == "1")
                {
                    SetContractNoEditable(true);
                    MessageBox.Show(
                        "لا يوجد رقم سابق للعقد.\nالرجاء إدخال رقم العقد يدوياً لأول مرة، وسيتم توليد الرقم التالي تلقائياً لاحقاً.",
                        "تنبيه",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    txtContractNo?.Focus();
                    return;
                }

                if (txtContractNo != null)
                    txtContractNo.Text = nextId;
                SetContractNoEditable(false);

                // نقل الفوكس إلى حقل رقم المستأجر
                txtTenantNo?.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء توليد رقم العقد: {ex.Message}", "خطأ", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // جمع البيانات من الحقول
                string contractNo = (txtContractNo?.Text ?? string.Empty).Trim();
                
                // الحصول على رقم المستأجر من Tag (إذا كان موجوداً) أو من النص
                string tenantNo = txtTenantNo?.Tag?.ToString() ?? (txtTenantNo?.Text ?? string.Empty).Trim();
                
                string apartmentNo = (txtApartmentNo?.Text ?? string.Empty).Trim();
                DateTime startDate = dtpStartDate?.Value ?? DateTime.Now;
                DateTime endDate = dtpEndDate?.Value ?? DateTime.Now;

                // التحقق من الحقول الإلزامية
                if (string.IsNullOrWhiteSpace(contractNo) ||
                    string.IsNullOrWhiteSpace(tenantNo) ||
                    string.IsNullOrWhiteSpace(apartmentNo) ||
                    cmbContractStatus?.SelectedIndex < 0)
                {
                    MessageBox.Show(
                        "الرجاء تعبئة جميع الحقول الإلزامية:\n- رقم العقد\n- رقم المستأجر\n- رقم الشقة\n- حالة العقد",
                        "تنبيه",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // التحقق من أن تاريخ الانتهاء بعد تاريخ البدء
                if (endDate < startDate)
                {
                    MessageBox.Show(
                        "تاريخ الانتهاء يجب أن يكون بعد تاريخ البدء.",
                        "تنبيه",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // معالجة الحقول الرقمية
                if (!decimal.TryParse(txtMonthlyRent?.Text?.Trim() ?? "0", out decimal monthlyRent))
                {
                    MessageBox.Show("الرجاء إدخال قيمة صحيحة للإيجار الشهري.", "تنبيه", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMonthlyRent?.Focus();
                    return;
                }

                if (!decimal.TryParse(txtDepositAmount?.Text?.Trim() ?? "0", out decimal depositAmount))
                {
                    MessageBox.Show("الرجاء إدخال قيمة صحيحة لمبلغ الضمان.", "تنبيه", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDepositAmount?.Focus();
                    return;
                }

                // معالجة رسوم أخرى (اختياري)
                decimal? otherFees = null;
                if (!string.IsNullOrWhiteSpace(txtOtherFees?.Text?.Trim()))
                {
                    if (decimal.TryParse(txtOtherFees.Text.Trim(), out decimal otherFeesValue))
                    {
                        otherFees = otherFeesValue;
                    }
                    else
                    {
                        MessageBox.Show("الرجاء إدخال قيمة صحيحة لرسوم أخرى.", "تنبيه", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtOtherFees?.Focus();
                        return;
                    }
                }

                // الحصول على حالة العقد
                string contractStatus = (cmbContractStatus?.SelectedItem?.ToString() ?? cmbContractStatus?.Text ?? string.Empty).Trim();
                if (string.IsNullOrWhiteSpace(contractStatus))
                {
                    MessageBox.Show("الرجاء اختيار حالة العقد.", "تنبيه", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // معالجة الملاحظات (اختياري)
                string note = (txtNote?.Text ?? string.Empty).Trim();
                if (string.IsNullOrWhiteSpace(note))
                    note = null;

                // حفظ البيانات
                contracts.ADD_Contracts(contractNo, tenantNo, apartmentNo, 
                    startDate, endDate, monthlyRent, depositAmount, otherFees, contractStatus, note);
                
                MessageBox.Show("تم حفظ بيانات العقد بنجاح.", "تم", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // تنظيف الحقول وإعادة الحالة
                ClearFields();
                SetFieldsEditable(false);
                SetEditMode(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الحفظ: {ex.Message}", "خطأ", 
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
