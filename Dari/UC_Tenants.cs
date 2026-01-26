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
    public partial class UC_Tenants : UserControl
    {
        private GridBtnViewHelper gridBtnViewHelper;
        private Tenants tenants;
        private bool isFieldsEditable = false;
        private bool isEditMode = false;

        public UC_Tenants()
        {
            InitializeComponent();
            
            // التحقق من أن Designer تم تحميله بشكل صحيح
            if (DesignMode)
                return;
            
            // تهيئة الكلاسات
            gridBtnViewHelper = new GridBtnViewHelper();
            tenants = new Tenants();
            
            WireReadOnlyFocusGuards();
            
            // افتراضيًا: كل الحقول للقراءة فقط (وتتفعل عند الضغط على "إضافة")
            SetFieldsEditable(false);
            SetEditMode(false);
            
            // ربط أحداث الأزرار
            if (btnAdd != null)
                btnAdd.Click += BtnAdd_Click;
            if (btnSave != null)
                btnSave.Click += BtnSave_Click;
            if (btnSearch != null)
                btnSearch.Click += BtnSearch_Click;
            if (btnEdit != null)
                btnEdit.Click += BtnEdit_Click;
            if (btnDelete != null)
                btnDelete.Click += BtnDelete_Click;
            if (btnClose != null)
                btnClose.Click += BtnClose_Click;
        }

        private void WireReadOnlyFocusGuards()
        {
            // منع الفوكس على الحقول عندما تكون ReadOnly (حتى عند الضغط بالماوس)
            if (txtTenantNo != null) txtTenantNo.Enter += PreventFocusWhenReadOnly;
            if (txtTenantName != null) txtTenantName.Enter += PreventFocusWhenReadOnly;
            if (txtNationalIdNo != null) txtNationalIdNo.Enter += PreventFocusWhenReadOnly;
            if (txtMobileNo != null) txtMobileNo.Enter += PreventFocusWhenReadOnly;
            if (dtpBirthDate != null) dtpBirthDate.Enter += PreventFocusWhenReadOnly;
            if (cmbNationality != null) cmbNationality.Enter += PreventFocusWhenReadOnly;
            if (cmbSocialStatus != null) cmbSocialStatus.Enter += PreventFocusWhenReadOnly;
            if (txtJobTitle != null) txtJobTitle.Enter += PreventFocusWhenReadOnly;
            if (txtWorkPlace != null) txtWorkPlace.Enter += PreventFocusWhenReadOnly;
            if (cmbTenantStatus != null) cmbTenantStatus.Enter += PreventFocusWhenReadOnly;
            if (txtGuarantorName != null) txtGuarantorName.Enter += PreventFocusWhenReadOnly;
            if (txtGuarantorNationalId != null) txtGuarantorNationalId.Enter += PreventFocusWhenReadOnly;
            if (txtGuarantorMobile != null) txtGuarantorMobile.Enter += PreventFocusWhenReadOnly;
            if (txtGuarantorWorkPlace != null) txtGuarantorWorkPlace.Enter += PreventFocusWhenReadOnly;
            if (txtCommercialRegNo != null) txtCommercialRegNo.Enter += PreventFocusWhenReadOnly;
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

            // رقم المستأجر: افتراضيًا للقراءة فقط (يتفعل فقط في حالة أول مرة)
            SetTenantNoEditable(false);

            if (txtTenantName != null) { txtTenantName.ReadOnly = !isEditable; txtTenantName.TabStop = isEditable; }
            if (txtNationalIdNo != null) { txtNationalIdNo.ReadOnly = !isEditable; txtNationalIdNo.TabStop = isEditable; }
            if (txtMobileNo != null) { txtMobileNo.ReadOnly = !isEditable; txtMobileNo.TabStop = isEditable; }
            if (dtpBirthDate != null) dtpBirthDate.Enabled = isEditable;
            if (cmbNationality != null) cmbNationality.Enabled = isEditable;
            if (cmbSocialStatus != null) cmbSocialStatus.Enabled = isEditable;
            if (txtJobTitle != null) { txtJobTitle.ReadOnly = !isEditable; txtJobTitle.TabStop = isEditable; }
            if (txtWorkPlace != null) { txtWorkPlace.ReadOnly = !isEditable; txtWorkPlace.TabStop = isEditable; }
            if (cmbTenantStatus != null) cmbTenantStatus.Enabled = isEditable;
            if (txtGuarantorName != null) { txtGuarantorName.ReadOnly = !isEditable; txtGuarantorName.TabStop = isEditable; }
            if (txtGuarantorNationalId != null) { txtGuarantorNationalId.ReadOnly = !isEditable; txtGuarantorNationalId.TabStop = isEditable; }
            if (txtGuarantorMobile != null) { txtGuarantorMobile.ReadOnly = !isEditable; txtGuarantorMobile.TabStop = isEditable; }
            if (txtGuarantorWorkPlace != null) { txtGuarantorWorkPlace.ReadOnly = !isEditable; txtGuarantorWorkPlace.TabStop = isEditable; }
            if (txtCommercialRegNo != null) { txtCommercialRegNo.ReadOnly = !isEditable; txtCommercialRegNo.TabStop = isEditable; }
        }

        private void SetTenantNoEditable(bool isEditable)
        {
            if (txtTenantNo == null)
                return;

            txtTenantNo.ReadOnly = !isEditable;
            txtTenantNo.TabStop = isEditable;
        }

        private void ClearFields()
        {
            if (txtTenantNo != null) txtTenantNo.Text = string.Empty;
            if (txtTenantName != null) txtTenantName.Text = string.Empty;
            if (txtNationalIdNo != null) txtNationalIdNo.Text = string.Empty;
            if (txtMobileNo != null) txtMobileNo.Text = string.Empty;
            if (dtpBirthDate != null) dtpBirthDate.Value = DateTime.Now;
            if (cmbNationality != null) cmbNationality.SelectedIndex = -1;
            if (cmbSocialStatus != null) cmbSocialStatus.SelectedIndex = -1;
            if (txtJobTitle != null) txtJobTitle.Text = string.Empty;
            if (txtWorkPlace != null) txtWorkPlace.Text = string.Empty;
            if (cmbTenantStatus != null) cmbTenantStatus.SelectedIndex = -1;
            if (txtGuarantorName != null) txtGuarantorName.Text = string.Empty;
            if (txtGuarantorNationalId != null) txtGuarantorNationalId.Text = string.Empty;
            if (txtGuarantorMobile != null) txtGuarantorMobile.Text = string.Empty;
            if (txtGuarantorWorkPlace != null) txtGuarantorWorkPlace.Text = string.Empty;
            if (txtCommercialRegNo != null) txtCommercialRegNo.Text = string.Empty;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SetEditMode(false);
            ClearFields();
            SetFieldsEditable(true);

            try
            {
                string nextId = tenants.GET_NEXT_TENANT_CODE();

                // إذا لم يوجد رقم سابق (أول مرة/لا توجد بيانات رقمية) نخلي المستخدم يدخل الرقم يدوياً
                if (nextId == "1")
                {
                    SetTenantNoEditable(true);
                    MessageBox.Show(
                        "لا يوجد رقم سابق للمستأجر.\nالرجاء إدخال رقم المستأجر يدوياً لأول مرة، وسيتم توليد الرقم التالي تلقائياً لاحقاً.",
                        "تنبيه",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    txtTenantNo?.Focus();
                    return;
                }

                if (txtTenantNo != null)
                    txtTenantNo.Text = nextId;
                SetTenantNoEditable(false);

                txtTenantName?.Focus();
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
                string tenantNo = (txtTenantNo?.Text ?? string.Empty).Trim();
                string tenantName = (txtTenantName?.Text ?? string.Empty).Trim();
                string nationalIdNo = (txtNationalIdNo?.Text ?? string.Empty).Trim();
                string mobileNo = (txtMobileNo?.Text ?? string.Empty).Trim();
                string tenantStatus = (cmbTenantStatus?.SelectedItem?.ToString() ?? cmbTenantStatus?.Text ?? string.Empty).Trim();

                // التحقق من الحقول الإلزامية
                if (string.IsNullOrWhiteSpace(tenantNo) ||
                    string.IsNullOrWhiteSpace(tenantName) ||
                    string.IsNullOrWhiteSpace(nationalIdNo) ||
                    string.IsNullOrWhiteSpace(mobileNo) ||
                    string.IsNullOrWhiteSpace(tenantStatus))
                {
                    MessageBox.Show(
                        "الرجاء تعبئة جميع الحقول الإلزامية:\n- رقم المستأجر\n- اسم المستأجر\n- رقم الهوية\n- رقم الجوال\n- حالة المستأجر",
                        "تنبيه",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // معالجة تاريخ الميلاد (اختياري)
                DateTime? birthDate = null;
                if (dtpBirthDate != null && dtpBirthDate.Checked)
                {
                    birthDate = dtpBirthDate.Value.Date;
                }

                // الحقول الاختيارية
                string nationality = (cmbNationality?.SelectedItem?.ToString() ?? cmbNationality?.Text ?? string.Empty).Trim();
                if (string.IsNullOrWhiteSpace(nationality)) nationality = null;

                string socialStatus = (cmbSocialStatus?.SelectedItem?.ToString() ?? cmbSocialStatus?.Text ?? string.Empty).Trim();
                if (string.IsNullOrWhiteSpace(socialStatus)) socialStatus = null;

                string jobTitle = (txtJobTitle?.Text ?? string.Empty).Trim();
                if (string.IsNullOrWhiteSpace(jobTitle)) jobTitle = null;

                string workPlace = (txtWorkPlace?.Text ?? string.Empty).Trim();
                if (string.IsNullOrWhiteSpace(workPlace)) workPlace = null;

                string guarantorName = (txtGuarantorName?.Text ?? string.Empty).Trim();
                if (string.IsNullOrWhiteSpace(guarantorName)) guarantorName = null;

                string guarantorNationalId = (txtGuarantorNationalId?.Text ?? string.Empty).Trim();
                if (string.IsNullOrWhiteSpace(guarantorNationalId)) guarantorNationalId = null;

                string guarantorMobile = (txtGuarantorMobile?.Text ?? string.Empty).Trim();
                if (string.IsNullOrWhiteSpace(guarantorMobile)) guarantorMobile = null;

                string guarantorWorkPlace = (txtGuarantorWorkPlace?.Text ?? string.Empty).Trim();
                if (string.IsNullOrWhiteSpace(guarantorWorkPlace)) guarantorWorkPlace = null;

                string commercialRegNo = (txtCommercialRegNo?.Text ?? string.Empty).Trim();
                if (string.IsNullOrWhiteSpace(commercialRegNo)) commercialRegNo = null;

                // حقول الصور (حالياً null - سيتم إضافتها لاحقاً)
                string idImagePath = null;
                string contractImagePath = null;
                string guaranteeImagePath = null;
                string guarantorIdImagePath = null;

                if (isEditMode)
                {
                    tenants.UPDATE_Tenants(tenantNo, tenantName, nationalIdNo, mobileNo,
                        birthDate, nationality, socialStatus, jobTitle, workPlace, tenantStatus,
                        guarantorName, guarantorNationalId, guarantorMobile, guarantorWorkPlace, commercialRegNo,
                        idImagePath, contractImagePath, guaranteeImagePath, guarantorIdImagePath);
                    MessageBox.Show("تم تحديث بيانات المستأجر بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tenants.ADD_Tenants(tenantNo, tenantName, nationalIdNo, mobileNo,
                        birthDate, nationality, socialStatus, jobTitle, workPlace, tenantStatus,
                        guarantorName, guarantorNationalId, guarantorMobile, guarantorWorkPlace, commercialRegNo,
                        idImagePath, contractImagePath, guaranteeImagePath, guarantorIdImagePath);
                    MessageBox.Show("تم حفظ بيانات المستأجر بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string tenantNo = (txtTenantNo?.Text ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(tenantNo))
            {
                MessageBox.Show("الرجاء اختيار مستأجر أولاً عن طريق زر البحث.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetEditMode(true);
            SetFieldsEditable(true);

            // رقم المستأجر لا يتعدل
            SetTenantNoEditable(false);

            txtTenantName?.Focus();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SetEditMode(false);
            // استدعاء البيانات من قاعدة البيانات
            DataTable dt = tenants.GET_ALL_Tenants();
            
            // عرض البيانات في نافذة البحث الديناميكية
            DataRow row = gridBtnViewHelper.Show(dt, "البحث عن المستأجرين");
            
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

                // تعبئة الحقول الأساسية
                if (row.Table.Columns.Contains("TenantNo"))
                    txtTenantNo.Text = row["TenantNo"]?.ToString() ?? "";

                if (row.Table.Columns.Contains("TenantName"))
                    txtTenantName.Text = row["TenantName"]?.ToString() ?? "";

                if (row.Table.Columns.Contains("NationalIdNo"))
                    txtNationalIdNo.Text = row["NationalIdNo"]?.ToString() ?? "";

                if (row.Table.Columns.Contains("MobileNo"))
                    txtMobileNo.Text = row["MobileNo"]?.ToString() ?? "";

                // معالجة تاريخ الميلاد
                if (row.Table.Columns.Contains("BirthDate") && dtpBirthDate != null)
                {
                    if (row["BirthDate"] != DBNull.Value && row["BirthDate"] != null)
                    {
                        if (DateTime.TryParse(row["BirthDate"].ToString(), out DateTime birthDate))
                        {
                            dtpBirthDate.Value = birthDate;
                            dtpBirthDate.Checked = true;
                        }
                        else
                        {
                            dtpBirthDate.Checked = false;
                        }
                    }
                    else
                    {
                        dtpBirthDate.Checked = false;
                    }
                }

                // معالجة ComboBox الجنسية
                if (row.Table.Columns.Contains("Nationality") && cmbNationality != null)
                {
                    string nationality = row["Nationality"]?.ToString() ?? "";
                    if (!string.IsNullOrWhiteSpace(nationality))
                    {
                        for (int i = 0; i < cmbNationality.Items.Count; i++)
                        {
                            if (cmbNationality.Items[i].ToString() == nationality)
                            {
                                cmbNationality.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                    else
                    {
                        cmbNationality.SelectedIndex = -1;
                    }
                }

                // معالجة ComboBox الحالة الاجتماعية
                if (row.Table.Columns.Contains("SocialStatus") && cmbSocialStatus != null)
                {
                    string socialStatus = row["SocialStatus"]?.ToString() ?? "";
                    if (!string.IsNullOrWhiteSpace(socialStatus))
                    {
                        for (int i = 0; i < cmbSocialStatus.Items.Count; i++)
                        {
                            if (cmbSocialStatus.Items[i].ToString() == socialStatus)
                            {
                                cmbSocialStatus.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                    else
                    {
                        cmbSocialStatus.SelectedIndex = -1;
                    }
                }

                if (row.Table.Columns.Contains("JobTitle"))
                    txtJobTitle.Text = row["JobTitle"]?.ToString() ?? "";

                if (row.Table.Columns.Contains("WorkPlace"))
                    txtWorkPlace.Text = row["WorkPlace"]?.ToString() ?? "";

                // معالجة ComboBox حالة المستأجر
                if (row.Table.Columns.Contains("TenantStatus") && cmbTenantStatus != null)
                {
                    string tenantStatus = row["TenantStatus"]?.ToString() ?? "";
                    if (!string.IsNullOrWhiteSpace(tenantStatus))
                    {
                        for (int i = 0; i < cmbTenantStatus.Items.Count; i++)
                        {
                            if (cmbTenantStatus.Items[i].ToString() == tenantStatus)
                            {
                                cmbTenantStatus.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                    else
                    {
                        cmbTenantStatus.SelectedIndex = -1;
                    }
                }

                // بيانات الكفيل
                if (row.Table.Columns.Contains("GuarantorName"))
                    txtGuarantorName.Text = row["GuarantorName"]?.ToString() ?? "";

                if (row.Table.Columns.Contains("GuarantorNationalId"))
                    txtGuarantorNationalId.Text = row["GuarantorNationalId"]?.ToString() ?? "";

                if (row.Table.Columns.Contains("GuarantorMobile"))
                    txtGuarantorMobile.Text = row["GuarantorMobile"]?.ToString() ?? "";

                if (row.Table.Columns.Contains("GuarantorWorkPlace"))
                    txtGuarantorWorkPlace.Text = row["GuarantorWorkPlace"]?.ToString() ?? "";

                if (row.Table.Columns.Contains("CommercialRegNo"))
                    txtCommercialRegNo.Text = row["CommercialRegNo"]?.ToString() ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تعبئة البيانات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string tenantNo = (txtTenantNo?.Text ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(tenantNo))
            {
                MessageBox.Show("الرجاء اختيار مستأجر أولاً عن طريق زر البحث.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenantName = (txtTenantName?.Text ?? string.Empty).Trim();
            string displayName = string.IsNullOrWhiteSpace(tenantName) ? tenantNo : $"{tenantName} ({tenantNo})";

            var confirm = MessageBox.Show(
                $"هل أنت متأكد من حذف المستأجر ({displayName})؟",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                tenants.DELETE_Tenants(tenantNo);
                MessageBox.Show("تم حذف المستأجر بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                SetFieldsEditable(false);
                SetEditMode(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الحذف: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
