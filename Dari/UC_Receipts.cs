using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Dari.Clas;

namespace Dari
{
    public partial class UC_Receipts : UserControl
    {
        private Receipts receipts;
        private Tenants tenants;
        private GridBtnViewHelper gridBtnViewHelper;
        private FinancialMovements financialMovements;
        private bool isFieldsEditable = false;
        private bool isEditMode = false;

        public UC_Receipts()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            receipts = new Receipts();
            tenants = new Tenants();
            gridBtnViewHelper = new GridBtnViewHelper();
            financialMovements = new FinancialMovements();

            FillBillYearCombo();
            SetDefaultDates();
            SetFieldsEditable(false);

            if (btnClose != null) btnClose.Click += BtnClose_Click;
            if (btnAdd != null) btnAdd.Click += BtnAdd_Click;
            if (btnSave != null) btnSave.Click += BtnSave_Click;
            if (btnSearch != null) btnSearch.Click += BtnSearch_Click;
            if (btnEdit != null) btnEdit.Click += BtnEdit_Click;
            if (btnDelete != null) btnDelete.Click += BtnDelete_Click;

            if (txtTenantNo != null)
            {
                txtTenantNo.KeyDown += TxtTenantNo_KeyDown;
                txtTenantNo.Enter += TxtTenantNo_Enter;
            }

            WireReadOnlyFocusGuards();
        }

        private void FillBillYearCombo()
        {
            if (cmbBillYear == null) return;
            cmbBillYear.Items.Clear();
            int year = DateTime.Now.Year;
            for (int i = year - 2; i <= year + 1; i++)
                cmbBillYear.Items.Add(i.ToString());
            if (cmbBillYear.Items.Count > 0)
            {
                string currentYear = year.ToString();
                int idx = cmbBillYear.Items.IndexOf(currentYear);
                if (idx >= 0) cmbBillYear.SelectedIndex = idx;
                else cmbBillYear.SelectedIndex = 0;
            }
        }

        private void SetDefaultDates()
        {
            if (dtpReceiptDate != null)
                dtpReceiptDate.Value = DateTime.Now;
        }

        private void TxtTenantNo_Enter(object sender, EventArgs e)
        {
            if (txtTenantNo != null && isFieldsEditable)
                txtTenantNo.ReadOnly = true;
        }

        private void TxtTenantNo_KeyDown(object sender, KeyEventArgs e)
        {
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

        private void OpenTenantSearchPopup()
        {
            try
            {
                DataTable dt = tenants.GET_ALL_Tenants();
                DataRow row = gridBtnViewHelper.Show(dt, "البحث عن المستأجرين");
                if (row != null)
                {
                    string tenantNo = row.Table.Columns.Contains("TenantNo") ? (row["TenantNo"]?.ToString() ?? "") : "";
                    string tenantName = row.Table.Columns.Contains("TenantName") ? (row["TenantName"]?.ToString() ?? "") : "";
                    if (!string.IsNullOrWhiteSpace(tenantNo))
                    {
                        //txtTenantNo.Tag = tenantNo;
                        //txtTenantNo.Text = tenantName;
                        DataTable dt_tenants = tenants.GetTenantFullInfo(tenantNo);
                        if (dt_tenants.Rows.Count > 1)
                        {
                           
                            DataRow rowt = gridBtnViewHelper.Show(dt_tenants, "البحث الشقق");
                            string ApartmentNo = rowt.Table.Columns.Contains("ApartmentNo") ? (rowt["ApartmentNo"]?.ToString() ?? "") : "";
                            txtTenantNo.Text = tenantName + "       " + ApartmentNo;
                            txtTenantNo.Tag = Tuple.Create(tenantNo, ApartmentNo);
                        }
                        else
                        {
                            
                            string ApartmentNo = dt_tenants.Rows[0]["ApartmentNo"].ToString();
                            txtTenantNo.Text = tenantName + "       " + ApartmentNo;
                            txtTenantNo.Tag = Tuple.Create(tenantNo, ApartmentNo);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء البحث عن المستأجرين: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WireReadOnlyFocusGuards()
        {
            if (txtReceiptNo != null) txtReceiptNo.Enter += PreventFocusWhenReadOnly;
            if (txtTenantNo != null) txtTenantNo.Enter += PreventFocusWhenReadOnly;
            if (cmbReceiptType != null) cmbReceiptType.Enter += PreventFocusWhenReadOnly;
            if (dtpReceiptDate != null) dtpReceiptDate.Enter += PreventFocusWhenReadOnly;
            if (cmbBillYear != null) cmbBillYear.Enter += PreventFocusWhenReadOnly;
            if (cmbBillMonth != null) cmbBillMonth.Enter += PreventFocusWhenReadOnly;
            if (txtAmount != null) txtAmount.Enter += PreventFocusWhenReadOnly;
            if (txtReferenceNo != null) txtReferenceNo.Enter += PreventFocusWhenReadOnly;
            if (txtNarration != null) txtNarration.Enter += PreventFocusWhenReadOnly;
        }

        private void PreventFocusWhenReadOnly(object sender, EventArgs e)
        {
            if (isFieldsEditable) return;
            if (btnAdd != null && btnAdd.CanSelect) { btnAdd.Select(); return; }
            if (sender is Control c) SelectNextControl(c, true, true, true, true);
        }

        private void SetFieldsEditable(bool isEditable)
        {
            isFieldsEditable = isEditable;
            SetReceiptNoEditable(false);
            if (txtTenantNo != null) { txtTenantNo.ReadOnly = !isEditable; txtTenantNo.TabStop = isEditable; }
            if (cmbReceiptType != null) cmbReceiptType.Enabled = isEditable;
            if (dtpReceiptDate != null) dtpReceiptDate.Enabled = isEditable;
            if (cmbBillYear != null) cmbBillYear.Enabled = isEditable;
            if (cmbBillMonth != null) cmbBillMonth.Enabled = isEditable;
            if (txtAmount != null) { txtAmount.ReadOnly = !isEditable; txtAmount.TabStop = isEditable; }
            if (txtReferenceNo != null) { txtReferenceNo.ReadOnly = !isEditable; txtReferenceNo.TabStop = isEditable; }
            if (txtNarration != null) { txtNarration.ReadOnly = !isEditable; txtNarration.Enabled = isEditable; }
        }

        private void SetReceiptNoEditable(bool isEditable)
        {
            if (txtReceiptNo == null) return;
            txtReceiptNo.ReadOnly = !isEditable;
            txtReceiptNo.TabStop = isEditable;
        }

        private void SetEditMode(bool editMode)
        {
            isEditMode = editMode;
            if (btnSave != null) btnSave.Text = editMode ? "تحديث" : "حفظ";
        }

        private void ClearFields()
        {
            if (txtReceiptNo != null) txtReceiptNo.Text = string.Empty;
            if (txtTenantNo != null) { txtTenantNo.Text = string.Empty; txtTenantNo.Tag = null; }
            if (cmbReceiptType != null && cmbReceiptType.Items.Count > 0) cmbReceiptType.SelectedIndex = 0;
            if (dtpReceiptDate != null) dtpReceiptDate.Value = DateTime.Now;
            if (cmbBillYear != null && cmbBillYear.Items.Count > 0)
            {
                string y = DateTime.Now.Year.ToString();
                int i = cmbBillYear.Items.IndexOf(y);
                if (i >= 0) cmbBillYear.SelectedIndex = i; else cmbBillYear.SelectedIndex = 0;
            }
            if (cmbBillMonth != null && cmbBillMonth.Items.Count > 0)
                cmbBillMonth.SelectedIndex = DateTime.Now.Month - 1;
            if (txtAmount != null) txtAmount.Text = string.Empty;
            if (txtReferenceNo != null) txtReferenceNo.Text = string.Empty;
            if (txtNarration != null) txtNarration.Text = string.Empty;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SetEditMode(false);
            ClearFields();
            SetFieldsEditable(true);
            try
            {
                string nextNo = receipts.GET_NEXT_ReceiptNo();
                if (nextNo == "1")
                {
                    SetReceiptNoEditable(true);
                    MessageBox.Show(
                        "لا يوجد رقم سابق للسند.\nالرجاء إدخال رقم السند يدوياً لأول مرة، وسيتم توليد الرقم التالي تلقائياً لاحقاً.",
                        "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtReceiptNo?.Focus();
                    return;
                }
                if (txtReceiptNo != null) txtReceiptNo.Text = nextNo;
                SetReceiptNoEditable(false);
                if (cmbReceiptType != null && cmbReceiptType.Items.Count > 0) cmbReceiptType.SelectedIndex = 0;
                if (cmbBillMonth != null && cmbBillMonth.Items.Count >= DateTime.Now.Month)
                    cmbBillMonth.SelectedIndex = DateTime.Now.Month - 1;
                txtTenantNo?.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string receiptNo = (txtReceiptNo?.Text ?? string.Empty).Trim();
                string tenantNo;
                string apartmentNo;

                if (txtTenantNo?.Tag is Tuple<string, string> info)
                {
                    tenantNo = info.Item1;
                    apartmentNo = info.Item2;
                }
                else
                {
                    tenantNo = (txtTenantNo?.Text ?? string.Empty).Trim();
                    apartmentNo = string.Empty;
                }
                string receiptType = (cmbReceiptType?.SelectedItem?.ToString() ?? cmbReceiptType?.Text ?? "").Trim();
                if (string.IsNullOrWhiteSpace(receiptNo) || string.IsNullOrWhiteSpace(tenantNo) || string.IsNullOrWhiteSpace(receiptType))
                {
                    MessageBox.Show("الرجاء تعبئة رقم السند ورقم المستأجر ونوع السند.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmbBillMonth?.SelectedIndex < 0)
                {
                    MessageBox.Show("الرجاء اختيار الشهر.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!decimal.TryParse(txtAmount?.Text?.Trim() ?? "0", out decimal amount) || amount <= 0)
                {
                    MessageBox.Show("الرجاء إدخال مبلغ صحيح.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAmount?.Focus();
                    return;
                }

                DateTime receiptDate = dtpReceiptDate?.Value ?? DateTime.Now;
                byte billMonth = (byte)(cmbBillMonth.SelectedIndex + 1);
                int billYear =0 ;
                if (cmbBillYear?.SelectedItem != null && int.TryParse(cmbBillYear.SelectedItem.ToString(), out int y))
                    billYear = y;
                string referenceNo = (txtReferenceNo?.Text ?? string.Empty).Trim();
                string narration = (txtNarration?.Text ?? string.Empty).Trim();
                if (string.IsNullOrWhiteSpace(referenceNo)) referenceNo = null;
                if (string.IsNullOrWhiteSpace(narration)) narration = null;

                if (isEditMode)
                {
                    financialMovements.DELETE_FinancialMovements("3", receiptNo);

                    receipts.UPDATE_Receipt(receiptNo, receiptType, receiptDate, tenantNo, amount, referenceNo, narration, billMonth, billYear, apartmentNo);

                    financialMovements.ADD_FinancialMovements("3", receiptNo, receiptType, receiptDate, billYear, billMonth, tenantNo
                      , apartmentNo, 0, amount, narration);
                    MessageBox.Show("تم تحديث السند بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    receipts.ADD_Receipt(receiptNo, receiptType, receiptDate, tenantNo, amount, referenceNo, narration, billMonth, billYear , apartmentNo);

                    financialMovements.ADD_FinancialMovements("3", receiptNo, receiptType, receiptDate, billYear, billMonth, tenantNo
                      , apartmentNo, 0, amount, narration);
                    MessageBox.Show("تم حفظ السند بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ClearFields();
                SetFieldsEditable(false);
                SetEditMode(false);
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الحفظ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SetEditMode(false);
            try
            {
                DataTable dt = receipts.GET_ALL_Receipts();
                DataRow row = gridBtnViewHelper.Show(dt, "البحث عن السندات");
                if (row != null)
                    FillFieldsFromRow(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل البيانات: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillFieldsFromRow(DataRow row)
        {
            try
            {
                SetEditMode(false);
                SetFieldsEditable(false);
                if (row.Table.Columns.Contains("ReceiptNo"))
                    txtReceiptNo.Text = row["ReceiptNo"]?.ToString() ?? "";
                if (row.Table.Columns.Contains("TenantNo"))
                {
                    string tenantNo = row["TenantNo"]?.ToString() ?? "";
                    string ApartmentNo = row.Table.Columns.Contains("ApartmentNo") ? (row["ApartmentNo"]?.ToString() ?? "") : "";
                    txtTenantNo.Text = tenantNo + "       " + ApartmentNo;
                    txtTenantNo.Tag = Tuple.Create(tenantNo, ApartmentNo);
                }
                if (row.Table.Columns.Contains("ReceiptType") && cmbReceiptType != null)
                {
                    string typeVal = row["ReceiptType"]?.ToString() ?? "";
                    int idx = cmbReceiptType.Items.IndexOf(typeVal);
                    if (idx >= 0) cmbReceiptType.SelectedIndex = idx;
                }
                if (row.Table.Columns.Contains("ReceiptDate") && dtpReceiptDate != null)
                {
                    if (row["ReceiptDate"] != DBNull.Value && row["ReceiptDate"] != null &&
                        DateTime.TryParse(row["ReceiptDate"].ToString(), out DateTime d))
                        dtpReceiptDate.Value = d;
                }
                if (row.Table.Columns.Contains("BillYear") && cmbBillYear != null)
                {
                    string yearVal = row["BillYear"]?.ToString() ?? "";
                    if (!string.IsNullOrEmpty(yearVal))
                    {
                        int i = cmbBillYear.Items.IndexOf(yearVal);
                        if (i >= 0) cmbBillYear.SelectedIndex = i;
                    }
                }
                if (row.Table.Columns.Contains("BillMonth") && cmbBillMonth != null)
                {
                    if (row["BillMonth"] != DBNull.Value && row["BillMonth"] != null &&
                        int.TryParse(row["BillMonth"].ToString(), out int month) && month >= 1 && month <= 12)
                        cmbBillMonth.SelectedIndex = month - 1;
                }
                if (row.Table.Columns.Contains("Amount"))
                    txtAmount.Text = row["Amount"] != DBNull.Value && row["Amount"] != null ? row["Amount"].ToString() : "";
                if (row.Table.Columns.Contains("ReferenceNo"))
                    txtReferenceNo.Text = row["ReferenceNo"]?.ToString() ?? "";
                if (row.Table.Columns.Contains("Narration"))
                    txtNarration.Text = row["Narration"]?.ToString() ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تعبئة البيانات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGrid()
        {
            try
            {
                DataTable dt = receipts.GET_ALL_Receipts();
                dgvReceipts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل البيانات: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string receiptNo = (txtReceiptNo?.Text ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(receiptNo))
            {
                MessageBox.Show("الرجاء اختيار سند أولاً عن طريق زر العرض.", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetEditMode(true);
            SetFieldsEditable(true);
            SetReceiptNoEditable(false);
            txtTenantNo?.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string receiptNo = (txtReceiptNo?.Text ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(receiptNo))
            {
                MessageBox.Show("الرجاء اختيار سند أولاً عن طريق زر العرض.", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"هل أنت متأكد من حذف السند رقم ({receiptNo})؟",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                receipts.DELETE_Receipt(receiptNo);
                MessageBox.Show("تم حذف السند بنجاح.", "تم",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                SetFieldsEditable(false);
                SetEditMode(false);
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الحذف: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (FindForm() is Form1 mainForm)
            {
                mainForm.ShowHome();
                return;
            }
            this.Visible = false;
        }
    }
}
