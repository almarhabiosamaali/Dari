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
        
        // متغيرات لحفظ مسارات الملفات المرفقة (المسار الأصلي قبل النسخ)
        private string idImagePath = null;
        private string contractImagePath = null;
        private string guaranteeImagePath = null;
        private string guarantorIdImagePath = null;
        
        // متغيرات لحفظ مسارات الملفات المنسوخة (في المجلد) - لحذفها عند تغيير الملف
        private string idImagePathCopied = null;
        private string contractImagePathCopied = null;
        private string guaranteeImagePathCopied = null;
        private string guarantorIdImagePathCopied = null;
        
        // متغيرات لتتبع ما إذا تم حذف الملف (عند الحفظ سيتم حذفه من المجلد)
        private bool isIdImageDeleted = false;
        private bool isContractImageDeleted = false;
        private bool isGuaranteeImageDeleted = false;
        private bool isGuarantorIdImageDeleted = false;

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
            
            // ربط أحداث أزرار المرفقات - صورة الهوية
            if (btnIdImageUpload != null)
                btnIdImageUpload.Click += BtnIdImageUpload_Click;
            if (btnIdImageOpen != null)
                btnIdImageOpen.Click += BtnIdImageOpen_Click;
            if (btnIdImageDelete != null)
                btnIdImageDelete.Click += BtnIdImageDelete_Click;
            
            // ربط أحداث أزرار المرفقات - صورة العقد
            if (btnContractImageUpload != null)
                btnContractImageUpload.Click += BtnContractImageUpload_Click;
            if (btnContractImageOpen != null)
                btnContractImageOpen.Click += BtnContractImageOpen_Click;
            if (btnContractImageDelete != null)
                btnContractImageDelete.Click += BtnContractImageDelete_Click;
            
            // ربط أحداث أزرار المرفقات - صورة الضمان
            if (btnGuaranteeImageUpload != null)
                btnGuaranteeImageUpload.Click += BtnGuaranteeImageUpload_Click;
            if (btnGuaranteeImageOpen != null)
                btnGuaranteeImageOpen.Click += BtnGuaranteeImageOpen_Click;
            if (btnGuaranteeImageDelete != null)
                btnGuaranteeImageDelete.Click += BtnGuaranteeImageDelete_Click;
            
            // ربط أحداث أزرار المرفقات - صورة هوية الضامن
            if (btnGuarantorIdImageUpload != null)
                btnGuarantorIdImageUpload.Click += BtnGuarantorIdImageUpload_Click;
            if (btnGuarantorIdImageOpen != null)
                btnGuarantorIdImageOpen.Click += BtnGuarantorIdImageOpen_Click;
            if (btnGuarantorIdImageDelete != null)
                btnGuarantorIdImageDelete.Click += BtnGuarantorIdImageDelete_Click;
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
            
            // مسح المرفقات
            idImagePath = null;
            contractImagePath = null;
            guaranteeImagePath = null;
            guarantorIdImagePath = null;
            
            // مسح المسارات المنسوخة
            idImagePathCopied = null;
            contractImagePathCopied = null;
            guaranteeImagePathCopied = null;
            guarantorIdImagePathCopied = null;
            
            // إعادة تعيين علامات الحذف
            isIdImageDeleted = false;
            isContractImageDeleted = false;
            isGuaranteeImageDeleted = false;
            isGuarantorIdImageDeleted = false;
            
            if (lblIdImageName != null) lblIdImageName.Text = string.Empty;
            if (lblContractImageName != null) lblContractImageName.Text = string.Empty;
            if (lblGuaranteeImageName != null) lblGuaranteeImageName.Text = string.Empty;
            if (lblGuarantorIdImageName != null) lblGuarantorIdImageName.Text = string.Empty;
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

                // نسخ الملفات إلى مجلد المرفقات قبل الحفظ
                string idImagePathToSave = null;
                string contractImagePathToSave = null;
                string guaranteeImagePathToSave = null;
                string guarantorIdImagePathToSave = null;
                
                try
                {
                    // نسخ صورة الهوية
                    if (!string.IsNullOrWhiteSpace(idImagePath))
                    {
                        // إذا كان في وضع التعديل وكان هناك ملف قديم، احذفه أولاً
                        if (isEditMode && !string.IsNullOrWhiteSpace(idImagePathCopied) && 
                            System.IO.File.Exists(idImagePathCopied))
                        {
                            try
                            {
                                FileHelper.DeleteAttachmentFile(idImagePathCopied);
                            }
                            catch { } // تجاهل الأخطاء
                        }
                        
                        idImagePathToSave = CopyFileToAttachmentsFolder(idImagePath, "Tenants");
                        idImagePathCopied = idImagePathToSave; // حفظ المسار المنسوخ
                        isIdImageDeleted = false; // إعادة تعيين علامة الحذف
                    }
                    else if (isEditMode && !string.IsNullOrWhiteSpace(idImagePathCopied) && !isIdImageDeleted)
                    {
                        // إذا لم يتم رفع ملف جديد ولم يتم حذفه، استخدم الملف القديم
                        idImagePathToSave = idImagePathCopied;
                    }
                    else if (isEditMode && isIdImageDeleted && !string.IsNullOrWhiteSpace(idImagePathCopied))
                    {
                        // إذا تم حذف الملف وكان هناك ملف قديم، احذفه من المجلد
                        try
                        {
                            FileHelper.DeleteAttachmentFile(idImagePathCopied);
                            idImagePathToSave = null; // لن يتم حفظ الملف
                        }
                        catch { }
                    }
                    
                    // نسخ صورة العقد
                    if (!string.IsNullOrWhiteSpace(contractImagePath))
                    {
                        if (isEditMode && !string.IsNullOrWhiteSpace(contractImagePathCopied) && 
                            System.IO.File.Exists(contractImagePathCopied))
                        {
                            try { FileHelper.DeleteAttachmentFile(contractImagePathCopied); } catch { }
                        }
                        contractImagePathToSave = CopyFileToAttachmentsFolder(contractImagePath, "Tenants");
                        contractImagePathCopied = contractImagePathToSave;
                        isContractImageDeleted = false;
                    }
                    else if (isEditMode && !string.IsNullOrWhiteSpace(contractImagePathCopied) && !isContractImageDeleted)
                    {
                        contractImagePathToSave = contractImagePathCopied;
                    }
                    else if (isEditMode && isContractImageDeleted && !string.IsNullOrWhiteSpace(contractImagePathCopied))
                    {
                        try
                        {
                            FileHelper.DeleteAttachmentFile(contractImagePathCopied);
                            contractImagePathToSave = null;
                        }
                        catch { }
                    }
                    
                    // نسخ صورة الضمان
                    if (!string.IsNullOrWhiteSpace(guaranteeImagePath))
                    {
                        if (isEditMode && !string.IsNullOrWhiteSpace(guaranteeImagePathCopied) && 
                            System.IO.File.Exists(guaranteeImagePathCopied))
                        {
                            try { FileHelper.DeleteAttachmentFile(guaranteeImagePathCopied); } catch { }
                        }
                        guaranteeImagePathToSave = CopyFileToAttachmentsFolder(guaranteeImagePath, "Tenants");
                        guaranteeImagePathCopied = guaranteeImagePathToSave;
                        isGuaranteeImageDeleted = false;
                    }
                    else if (isEditMode && !string.IsNullOrWhiteSpace(guaranteeImagePathCopied) && !isGuaranteeImageDeleted)
                    {
                        guaranteeImagePathToSave = guaranteeImagePathCopied;
                    }
                    else if (isEditMode && isGuaranteeImageDeleted && !string.IsNullOrWhiteSpace(guaranteeImagePathCopied))
                    {
                        try
                        {
                            FileHelper.DeleteAttachmentFile(guaranteeImagePathCopied);
                            guaranteeImagePathToSave = null;
                        }
                        catch { }
                    }
                    
                    // نسخ صورة هوية الضامن
                    if (!string.IsNullOrWhiteSpace(guarantorIdImagePath))
                    {
                        if (isEditMode && !string.IsNullOrWhiteSpace(guarantorIdImagePathCopied) && 
                            System.IO.File.Exists(guarantorIdImagePathCopied))
                        {
                            try { FileHelper.DeleteAttachmentFile(guarantorIdImagePathCopied); } catch { }
                        }
                        guarantorIdImagePathToSave = CopyFileToAttachmentsFolder(guarantorIdImagePath, "Tenants");
                        guarantorIdImagePathCopied = guarantorIdImagePathToSave;
                        isGuarantorIdImageDeleted = false;
                    }
                    else if (isEditMode && !string.IsNullOrWhiteSpace(guarantorIdImagePathCopied) && !isGuarantorIdImageDeleted)
                    {
                        guarantorIdImagePathToSave = guarantorIdImagePathCopied;
                    }
                    else if (isEditMode && isGuarantorIdImageDeleted && !string.IsNullOrWhiteSpace(guarantorIdImagePathCopied))
                    {
                        try
                        {
                            FileHelper.DeleteAttachmentFile(guarantorIdImagePathCopied);
                            guarantorIdImagePathToSave = null;
                        }
                        catch { }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"حدث خطأ أثناء نسخ الملفات: {ex.Message}", "خطأ", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (isEditMode)
                {
                    tenants.UPDATE_Tenants(tenantNo, tenantName, nationalIdNo, mobileNo,
                        birthDate, nationality, socialStatus, jobTitle, workPlace, tenantStatus,
                        guarantorName, guarantorNationalId, guarantorMobile, guarantorWorkPlace, commercialRegNo,
                        idImagePathToSave, contractImagePathToSave, guaranteeImagePathToSave, guarantorIdImagePathToSave);
                    MessageBox.Show("تم تحديث بيانات المستأجر بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tenants.ADD_Tenants(tenantNo, tenantName, nationalIdNo, mobileNo,
                        birthDate, nationality, socialStatus, jobTitle, workPlace, tenantStatus,
                        guarantorName, guarantorNationalId, guarantorMobile, guarantorWorkPlace, commercialRegNo,
                        idImagePathToSave, contractImagePathToSave, guaranteeImagePathToSave, guarantorIdImagePathToSave);
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

                // تعبئة مسارات الملفات المرفقة (من قاعدة البيانات - المسار المنسوخ)
                if (row.Table.Columns.Contains("IdImagePath"))
                {
                    string savedPath = row["IdImagePath"] != DBNull.Value ? row["IdImagePath"]?.ToString() : null;
                    idImagePath = null; // لا يوجد ملف جديد مرفق
                    idImagePathCopied = savedPath; // المسار المنسوخ من قاعدة البيانات
                    isIdImageDeleted = false; // إعادة تعيين علامة الحذف
                    if (lblIdImageName != null)
                    {
                        lblIdImageName.Text = !string.IsNullOrWhiteSpace(savedPath) 
                            ? FileHelper.GetFileName(savedPath) 
                            : string.Empty;
                    }
                }

                if (row.Table.Columns.Contains("ContractImagePath"))
                {
                    string savedPath = row["ContractImagePath"] != DBNull.Value ? row["ContractImagePath"]?.ToString() : null;
                    contractImagePath = null;
                    contractImagePathCopied = savedPath;
                    isContractImageDeleted = false;
                    if (lblContractImageName != null)
                    {
                        lblContractImageName.Text = !string.IsNullOrWhiteSpace(savedPath) 
                            ? FileHelper.GetFileName(savedPath) 
                            : string.Empty;
                    }
                }

                if (row.Table.Columns.Contains("GuaranteeImagePath"))
                {
                    string savedPath = row["GuaranteeImagePath"] != DBNull.Value ? row["GuaranteeImagePath"]?.ToString() : null;
                    guaranteeImagePath = null;
                    guaranteeImagePathCopied = savedPath;
                    isGuaranteeImageDeleted = false;
                    if (lblGuaranteeImageName != null)
                    {
                        lblGuaranteeImageName.Text = !string.IsNullOrWhiteSpace(savedPath) 
                            ? FileHelper.GetFileName(savedPath) 
                            : string.Empty;
                    }
                }

                if (row.Table.Columns.Contains("GuarantorIdImagePath"))
                {
                    string savedPath = row["GuarantorIdImagePath"] != DBNull.Value ? row["GuarantorIdImagePath"]?.ToString() : null;
                    guarantorIdImagePath = null;
                    guarantorIdImagePathCopied = savedPath;
                    isGuarantorIdImageDeleted = false;
                    if (lblGuarantorIdImageName != null)
                    {
                        lblGuarantorIdImageName.Text = !string.IsNullOrWhiteSpace(savedPath) 
                            ? FileHelper.GetFileName(savedPath) 
                            : string.Empty;
                    }
                }
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
                // حذف الملفات المرفقة من القرص قبل حذف المستأجر
                // الحصول على مسارات الملفات من قاعدة البيانات أولاً
                DataTable dt = tenants.GET_ALL_Tenants();
                DataRow tenantRow = dt.AsEnumerable()
                    .FirstOrDefault(row => row["TenantNo"]?.ToString() == tenantNo);
                
                if (tenantRow != null)
                {
                    // حذف صورة الهوية
                    if (tenantRow.Table.Columns.Contains("IdImagePath") && 
                        tenantRow["IdImagePath"] != DBNull.Value && 
                        !string.IsNullOrWhiteSpace(tenantRow["IdImagePath"]?.ToString()))
                    {
                        try
                        {
                            FileHelper.DeleteAttachmentFile(tenantRow["IdImagePath"].ToString());
                        }
                        catch { } // تجاهل الأخطاء في حذف الملفات
                    }
                    
                    // حذف صورة العقد
                    if (tenantRow.Table.Columns.Contains("ContractImagePath") && 
                        tenantRow["ContractImagePath"] != DBNull.Value && 
                        !string.IsNullOrWhiteSpace(tenantRow["ContractImagePath"]?.ToString()))
                    {
                        try
                        {
                            FileHelper.DeleteAttachmentFile(tenantRow["ContractImagePath"].ToString());
                        }
                        catch { }
                    }
                    
                    // حذف صورة الضمان
                    if (tenantRow.Table.Columns.Contains("GuaranteeImagePath") && 
                        tenantRow["GuaranteeImagePath"] != DBNull.Value && 
                        !string.IsNullOrWhiteSpace(tenantRow["GuaranteeImagePath"]?.ToString()))
                    {
                        try
                        {
                            FileHelper.DeleteAttachmentFile(tenantRow["GuaranteeImagePath"].ToString());
                        }
                        catch { }
                    }
                    
                    // حذف صورة هوية الضامن
                    if (tenantRow.Table.Columns.Contains("GuarantorIdImagePath") && 
                        tenantRow["GuarantorIdImagePath"] != DBNull.Value && 
                        !string.IsNullOrWhiteSpace(tenantRow["GuarantorIdImagePath"]?.ToString()))
                    {
                        try
                        {
                            FileHelper.DeleteAttachmentFile(tenantRow["GuarantorIdImagePath"].ToString());
                        }
                        catch { }
                    }
                }
                
                // حذف المستأجر من قاعدة البيانات
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

        // دوال ديناميكية للتعامل مع الملفات
        private void HandleFileUpload(ref string filePath, ref string filePathCopied, ref bool isDeleted, MaterialLabel labelName, string dialogTitle)
        {
            try
            {
                // فتح حوار اختيار الملف
                string selectedFile = FileHelper.BrowseFile(dialogTitle, "جميع الملفات|*.*|صور|*.jpg;*.jpeg;*.png;*.bmp|PDF|*.pdf");
                
                if (string.IsNullOrWhiteSpace(selectedFile))
                    return; // المستخدم ألغى العملية

                // حفظ المسار الأصلي فقط (بدون نسخ إلى المجلد)
                filePath = selectedFile;
                // لا نمسح filePathCopied هنا - سيتم التعامل معه عند الحفظ
                isDeleted = false; // إعادة تعيين علامة الحذف
                
                // عرض اسم الملف
                string fileName = FileHelper.GetFileName(selectedFile);
                if (labelName != null)
                {
                    labelName.Text = fileName;
                }
                
                MessageBox.Show("تم اختيار الملف بنجاح. سيتم حفظه عند الضغط على زر الحفظ.", "تم", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء اختيار الملف: {ex.Message}", "خطأ", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // دالة لنسخ الملف إلى المجلد (يتم استدعاؤها عند الحفظ)
        private string CopyFileToAttachmentsFolder(string sourceFilePath, string folderType)
        {
            if (string.IsNullOrWhiteSpace(sourceFilePath) || !System.IO.File.Exists(sourceFilePath))
                return null;
            
            try
            {
                return FileHelper.CopyFileToAttachments(sourceFilePath, folderType);
            }
            catch (Exception ex)
            {
                throw new Exception($"فشل في نسخ الملف إلى مجلد المرفقات: {ex.Message}");
            }
        }

        private void HandleFileOpen(string filePath)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(filePath))
                {
                    MessageBox.Show("لا يوجد ملف مرفق.", "تنبيه", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FileHelper.OpenFile(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء فتح الملف: {ex.Message}", "خطأ", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleFileDelete(ref string filePath, ref string filePathCopied, ref bool isDeleted, MaterialLabel labelName)
        {
            // مسح الملف من المتغيرات فقط (لا يحذف من المجلد - سيتم الحذف عند الحفظ)
            filePath = null;
            // وضع علامة أن الملف تم حذفه (سيتم حذفه من المجلد عند الحفظ)
            isDeleted = true;
            if (labelName != null)
            {
                labelName.Text = string.Empty;
            }
        }

        private void BtnIdImageUpload_Click(object sender, EventArgs e)
        {
            HandleFileUpload(ref idImagePath, ref idImagePathCopied, ref isIdImageDeleted, lblIdImageName, "اختر صورة الهوية");
        }

        private void BtnIdImageOpen_Click(object sender, EventArgs e)
        {
            // إذا كان الملف في المتغير (قبل الحفظ - ملف جديد)، افتحه من المسار الأصلي
            string filePathToOpen = idImagePath;
            
            if (string.IsNullOrWhiteSpace(filePathToOpen))
            {
                // إذا لم يكن هناك ملف جديد، استخدم المسار المنسوخ (من قاعدة البيانات)
                filePathToOpen = idImagePathCopied;
                
                // إذا لم يكن موجوداً، حاول قراءة من قاعدة البيانات
                if (string.IsNullOrWhiteSpace(filePathToOpen))
                {
                    string tenantNo = (txtTenantNo?.Text ?? string.Empty).Trim();
                    if (!string.IsNullOrWhiteSpace(tenantNo))
                    {
                        try
                        {
                            DataTable dt = tenants.GET_ALL_Tenants();
                            DataRow tenantRow = dt.AsEnumerable()
                                .FirstOrDefault(row => row["TenantNo"]?.ToString() == tenantNo);
                            
                            if (tenantRow != null && 
                                tenantRow.Table.Columns.Contains("IdImagePath") && 
                                tenantRow["IdImagePath"] != DBNull.Value)
                            {
                                filePathToOpen = tenantRow["IdImagePath"]?.ToString();
                            }
                        }
                        catch { }
                    }
                }
            }
            
            HandleFileOpen(filePathToOpen);
        }

        private void BtnIdImageDelete_Click(object sender, EventArgs e)
        {
            HandleFileDelete(ref idImagePath, ref idImagePathCopied, ref isIdImageDeleted, lblIdImageName);
        }

        // دوال صورة العقد
        private void BtnContractImageUpload_Click(object sender, EventArgs e)
        {
            HandleFileUpload(ref contractImagePath, ref contractImagePathCopied, ref isContractImageDeleted, lblContractImageName, "اختر صورة العقد");
        }

        private void BtnContractImageOpen_Click(object sender, EventArgs e)
        {
            string filePathToOpen = contractImagePath;
            if (string.IsNullOrWhiteSpace(filePathToOpen))
            {
                filePathToOpen = contractImagePathCopied;
                if (string.IsNullOrWhiteSpace(filePathToOpen))
                {
                    string tenantNo = (txtTenantNo?.Text ?? string.Empty).Trim();
                    if (!string.IsNullOrWhiteSpace(tenantNo))
                    {
                        try
                        {
                            DataTable dt = tenants.GET_ALL_Tenants();
                            DataRow tenantRow = dt.AsEnumerable()
                                .FirstOrDefault(row => row["TenantNo"]?.ToString() == tenantNo);
                            
                            if (tenantRow != null && 
                                tenantRow.Table.Columns.Contains("ContractImagePath") && 
                                tenantRow["ContractImagePath"] != DBNull.Value)
                            {
                                filePathToOpen = tenantRow["ContractImagePath"]?.ToString();
                            }
                        }
                        catch { }
                    }
                }
            }
            HandleFileOpen(filePathToOpen);
        }

        private void BtnContractImageDelete_Click(object sender, EventArgs e)
        {
            HandleFileDelete(ref contractImagePath, ref contractImagePathCopied, ref isContractImageDeleted, lblContractImageName);
        }

        // دوال صورة الضمان
        private void BtnGuaranteeImageUpload_Click(object sender, EventArgs e)
        {
            HandleFileUpload(ref guaranteeImagePath, ref guaranteeImagePathCopied, ref isGuaranteeImageDeleted, lblGuaranteeImageName, "اختر صورة الضمان");
        }

        private void BtnGuaranteeImageOpen_Click(object sender, EventArgs e)
        {
            string filePathToOpen = guaranteeImagePath;
            if (string.IsNullOrWhiteSpace(filePathToOpen))
            {
                filePathToOpen = guaranteeImagePathCopied;
                if (string.IsNullOrWhiteSpace(filePathToOpen))
                {
                    string tenantNo = (txtTenantNo?.Text ?? string.Empty).Trim();
                    if (!string.IsNullOrWhiteSpace(tenantNo))
                    {
                        try
                        {
                            DataTable dt = tenants.GET_ALL_Tenants();
                            DataRow tenantRow = dt.AsEnumerable()
                                .FirstOrDefault(row => row["TenantNo"]?.ToString() == tenantNo);
                            
                            if (tenantRow != null && 
                                tenantRow.Table.Columns.Contains("GuaranteeImagePath") && 
                                tenantRow["GuaranteeImagePath"] != DBNull.Value)
                            {
                                filePathToOpen = tenantRow["GuaranteeImagePath"]?.ToString();
                            }
                        }
                        catch { }
                    }
                }
            }
            HandleFileOpen(filePathToOpen);
        }

        private void BtnGuaranteeImageDelete_Click(object sender, EventArgs e)
        {
            HandleFileDelete(ref guaranteeImagePath, ref guaranteeImagePathCopied, ref isGuaranteeImageDeleted, lblGuaranteeImageName);
        }

        // دوال صورة هوية الضامن
        private void BtnGuarantorIdImageUpload_Click(object sender, EventArgs e)
        {
            HandleFileUpload(ref guarantorIdImagePath, ref guarantorIdImagePathCopied, ref isGuarantorIdImageDeleted, lblGuarantorIdImageName, "اختر صورة هوية الضامن");
        }

        private void BtnGuarantorIdImageOpen_Click(object sender, EventArgs e)
        {
            string filePathToOpen = guarantorIdImagePath;
            if (string.IsNullOrWhiteSpace(filePathToOpen))
            {
                filePathToOpen = guarantorIdImagePathCopied;
                if (string.IsNullOrWhiteSpace(filePathToOpen))
                {
                    string tenantNo = (txtTenantNo?.Text ?? string.Empty).Trim();
                    if (!string.IsNullOrWhiteSpace(tenantNo))
                    {
                        try
                        {
                            DataTable dt = tenants.GET_ALL_Tenants();
                            DataRow tenantRow = dt.AsEnumerable()
                                .FirstOrDefault(row => row["TenantNo"]?.ToString() == tenantNo);
                            
                            if (tenantRow != null && 
                                tenantRow.Table.Columns.Contains("GuarantorIdImagePath") && 
                                tenantRow["GuarantorIdImagePath"] != DBNull.Value)
                            {
                                filePathToOpen = tenantRow["GuarantorIdImagePath"]?.ToString();
                            }
                        }
                        catch { }
                    }
                }
            }
            HandleFileOpen(filePathToOpen);
        }

        private void BtnGuarantorIdImageDelete_Click(object sender, EventArgs e)
        {
            HandleFileDelete(ref guarantorIdImagePath, ref guarantorIdImagePathCopied, ref isGuarantorIdImageDeleted, lblGuarantorIdImageName);
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
