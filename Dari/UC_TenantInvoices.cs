using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Dari.Clas;

namespace Dari
{
    public partial class UC_TenantInvoices : UserControl
    {
        private TenantInvoices tenantInvoices;
        private FinancialMovements financialMovements;
        private Tenants tenants;
        private GridBtnViewHelper gridBtnViewHelper;
        private bool isFieldsEditable = false;
        private bool isEditMode = false;

        public UC_TenantInvoices()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            tenantInvoices = new TenantInvoices();
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

            if (dgvInvoices != null)
                dgvInvoices.SelectionChanged += DgvInvoices_SelectionChanged;

            // منع الفوكس على جميع الحقول عندما تكون للقراءة فقط
            WireReadOnlyFocusGuards();
        }

        /// <summary>
        /// ربط حدث Enter لجميع الحقول لمنع الفوكس عند وضع القراءة فقط
        /// </summary>
        private void WireReadOnlyFocusGuards()
        {
            if (txtInvoiceNo != null) txtInvoiceNo.Enter += PreventFocusWhenReadOnly;
            if (txtTenantNo != null) txtTenantNo.Enter += PreventFocusWhenReadOnly;
            if (cmbBillYear != null) cmbBillYear.Enter += PreventFocusWhenReadOnly;
            if (cmbBillMonth != null) cmbBillMonth.Enter += PreventFocusWhenReadOnly;
            if (dtpInvoiceDate != null) dtpInvoiceDate.Enter += PreventFocusWhenReadOnly;
            if (txtElectricityUsage != null) txtElectricityUsage.Enter += PreventFocusWhenReadOnly;
            if (txtElectricityAmount != null) txtElectricityAmount.Enter += PreventFocusWhenReadOnly;
            if (txtWaterUsage != null) txtWaterUsage.Enter += PreventFocusWhenReadOnly;
            if (txtWaterAmount != null) txtWaterAmount.Enter += PreventFocusWhenReadOnly;
            if (txtOtherFees != null) txtOtherFees.Enter += PreventFocusWhenReadOnly;
            if (txtNarration != null) txtNarration.Enter += PreventFocusWhenReadOnly;
        }

        /// <summary>
        /// عند محاولة الدخول لحقل والوضع قراءة فقط: نقل الفوكس لزر الإضافة (أو التالي)
        /// </summary>
        private void PreventFocusWhenReadOnly(object sender, EventArgs e)
        {
            if (isFieldsEditable)
                return;

            if (btnAdd != null && btnAdd.CanSelect)
            {
                btnAdd.Select();
                return;
            }

            if (sender is Control c)
                SelectNextControl(c, true, true, true, true);
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
            if (dtpInvoiceDate != null)
                dtpInvoiceDate.Value = DateTime.Now;
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
                            MessageBox.Show(dt_tenants.Rows.Count.ToString());
                            DataRow rowt = gridBtnViewHelper.Show(dt_tenants, "البحث الشقق");
                            string ApartmentNo = rowt.Table.Columns.Contains("ApartmentNo") ? (rowt["ApartmentNo"]?.ToString() ?? "") : "";
                            txtTenantNo.Text = tenantName + "       " + ApartmentNo;
                            txtTenantNo.Tag = Tuple.Create(tenantNo, ApartmentNo);
                        }
                        else
                        {
                            MessageBox.Show(dt_tenants.Rows.Count.ToString());
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

        private void SetFieldsEditable(bool isEditable)
        {
            isFieldsEditable = isEditable;
            // رقم الفاتورة: للقراءة فقط إلا في حالة عدم وجود رقم سابق (أول مرة)
            SetInvoiceNoEditable(false);
            if (txtTenantNo != null) { txtTenantNo.ReadOnly = !isEditable; txtTenantNo.TabStop = isEditable; }
            if (cmbBillYear != null) cmbBillYear.Enabled = isEditable;
            if (cmbBillMonth != null) cmbBillMonth.Enabled = isEditable;
            if (dtpInvoiceDate != null) dtpInvoiceDate.Enabled = isEditable;
            if (txtElectricityUsage != null) { txtElectricityUsage.ReadOnly = !isEditable; txtElectricityUsage.TabStop = isEditable; }
            if (txtElectricityAmount != null) { txtElectricityAmount.ReadOnly = !isEditable; txtElectricityAmount.TabStop = isEditable; }
            if (txtWaterUsage != null) { txtWaterUsage.ReadOnly = !isEditable; txtWaterUsage.TabStop = isEditable; }
            if (txtWaterAmount != null) { txtWaterAmount.ReadOnly = !isEditable; txtWaterAmount.TabStop = isEditable; }
            if (txtOtherFees != null) { txtOtherFees.ReadOnly = !isEditable; txtOtherFees.TabStop = isEditable; }
            if (txtNarration != null) { txtNarration.ReadOnly = !isEditable; txtNarration.Enabled = isEditable; }
        }

        private void SetInvoiceNoEditable(bool isEditable)
        {
            if (txtInvoiceNo == null) return;
            txtInvoiceNo.ReadOnly = !isEditable;
            txtInvoiceNo.TabStop = isEditable;
        }

        private void SetEditMode(bool editMode)
        {
            isEditMode = editMode;
            if (btnSave != null)
                btnSave.Text = editMode ? "تحديث" : "حفظ";
        }

        private void ClearFields()
        {
            if (txtInvoiceNo != null) txtInvoiceNo.Text = string.Empty;
            if (txtTenantNo != null) { txtTenantNo.Text = string.Empty; txtTenantNo.Tag = null; }
            if (cmbBillYear != null && cmbBillYear.Items.Count > 0)
            {
                string y = DateTime.Now.Year.ToString();
                int i = cmbBillYear.Items.IndexOf(y);
                if (i >= 0) cmbBillYear.SelectedIndex = i; else cmbBillYear.SelectedIndex = 0;
            }
            if (cmbBillMonth != null && cmbBillMonth.Items.Count > 0)
                cmbBillMonth.SelectedIndex = DateTime.Now.Month - 1;
            if (dtpInvoiceDate != null) dtpInvoiceDate.Value = DateTime.Now;
            if (txtElectricityUsage != null) txtElectricityUsage.Text = string.Empty;
            if (txtElectricityAmount != null) txtElectricityAmount.Text = string.Empty;
            if (txtWaterUsage != null) txtWaterUsage.Text = string.Empty;
            if (txtWaterAmount != null) txtWaterAmount.Text = string.Empty;
            if (txtOtherFees != null) txtOtherFees.Text = string.Empty;
            if (txtNarration != null) txtNarration.Text = string.Empty;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SetEditMode(false);
            ClearFields();
            SetFieldsEditable(true);
            try
            {
                string nextNo = tenantInvoices.GET_NEXT_InvoiceNo();

                // إذا لم يوجد رقم سابق (أول مرة/لا توجد بيانات رقمية) نسمح للمستخدم بإدخال الرقم يدوياً
                if (nextNo == "1")
                {
                    SetInvoiceNoEditable(true);
                    MessageBox.Show(
                        "لا يوجد رقم سابق للفاتورة.\nالرجاء إدخال رقم الفاتورة يدوياً لأول مرة، وسيتم توليد الرقم التالي تلقائياً لاحقاً.",
                        "تنبيه",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    txtInvoiceNo?.Focus();
                    return;
                }

                if (txtInvoiceNo != null) txtInvoiceNo.Text = nextNo;
                SetInvoiceNoEditable(false);
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
                string invoiceNo = (txtInvoiceNo?.Text ?? string.Empty).Trim();
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
            if (string.IsNullOrWhiteSpace(invoiceNo) || string.IsNullOrWhiteSpace(tenantNo))
                {
                    MessageBox.Show("الرجاء تعبئة رقم الفاتورة ورقم المستأجر.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbBillYear?.SelectedItem == null || cmbBillMonth?.SelectedIndex < 0)
                {
                    MessageBox.Show("الرجاء اختيار السنة والشهر.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(cmbBillYear.SelectedItem.ToString(), out int billYear))
                {
                    MessageBox.Show("قيمة السنة غير صحيحة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                byte billMonth = (byte)(cmbBillMonth.SelectedIndex + 1);
                DateTime invoiceDate = dtpInvoiceDate?.Value ?? DateTime.Now;

                decimal? electricityUsage = ParseDecimalOrNull(txtElectricityUsage?.Text);
                decimal? electricityAmount = ParseDecimalOrNull(txtElectricityAmount?.Text);
                decimal? waterUsage = ParseDecimalOrNull(txtWaterUsage?.Text);
                decimal? waterAmount = ParseDecimalOrNull(txtWaterAmount?.Text);
                decimal? otherFees = ParseDecimalOrNull(txtOtherFees?.Text);
            decimal allAmount = electricityAmount.GetValueOrDefault()
              + waterAmount.GetValueOrDefault()
              + otherFees.GetValueOrDefault();

            string narration = (txtNarration?.Text ?? string.Empty).Trim();
                if (string.IsNullOrWhiteSpace(narration)) narration = null;

                if (isEditMode)
                {
                financialMovements.DELETE_FinancialMovements("2", invoiceNo);


                    tenantInvoices.UPDATE_TenantInvoice(
                        invoiceNo, tenantNo, billYear, billMonth, invoiceDate,
                        electricityUsage, electricityAmount, waterUsage, waterAmount, otherFees, narration , apartmentNo);


                financialMovements.ADD_FinancialMovements("2", invoiceNo, "", invoiceDate, billYear, billMonth, tenantNo
                       , apartmentNo, allAmount, 0, narration);
                MessageBox.Show("تم تحديث الفاتورة بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tenantInvoices.ADD_TenantInvoice(
                        invoiceNo, tenantNo, billYear, billMonth, invoiceDate,
                        electricityUsage, electricityAmount, waterUsage, waterAmount, otherFees, narration, apartmentNo);


                financialMovements.ADD_FinancialMovements("2", invoiceNo, "", invoiceDate, billYear, billMonth, tenantNo
                       , apartmentNo, allAmount, 0, narration);
                    MessageBox.Show("تم حفظ الفاتورة بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private static decimal? ParseDecimalOrNull(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return null;
            return decimal.TryParse(text.Trim(), out decimal v) ? v : (decimal?)null;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SetEditMode(false);
            try
            {
                DataTable dt = tenantInvoices.GET_ALL_TenantInvoices();
                DataRow row = gridBtnViewHelper.Show(dt, "البحث عن الفواتير");
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

                if (row.Table.Columns.Contains("InvoiceNo"))
                    txtInvoiceNo.Text = row["InvoiceNo"]?.ToString() ?? "";

                if (row.Table.Columns.Contains("TenantNo") && row.Table.Columns.Contains("ApartmentNo"))
                {
                    string tenantNo = row["TenantNo"]?.ToString() ?? "";
                    string ApartmentNo = row.Table.Columns.Contains("ApartmentNo") ? (row["ApartmentNo"]?.ToString() ?? "") : "";
                    txtTenantNo.Text = tenantNo + "       " + ApartmentNo;
                    txtTenantNo.Tag = Tuple.Create(tenantNo, ApartmentNo);
                }

                if (row.Table.Columns.Contains("BillYear") && cmbBillYear != null)
                {
                    string yearVal = row["BillYear"]?.ToString() ?? "";
                    if (!string.IsNullOrEmpty(yearVal))
                    {
                        int idx = cmbBillYear.Items.IndexOf(yearVal);
                        if (idx >= 0) cmbBillYear.SelectedIndex = idx;
                    }
                }

                if (row.Table.Columns.Contains("BillMonth") && cmbBillMonth != null)
                {
                    if (row["BillMonth"] != DBNull.Value && row["BillMonth"] != null &&
                        int.TryParse(row["BillMonth"].ToString(), out int month) && month >= 1 && month <= 12)
                        cmbBillMonth.SelectedIndex = month - 1;
                }

                if (row.Table.Columns.Contains("InvoiceDate") && dtpInvoiceDate != null)
                {
                    if (row["InvoiceDate"] != DBNull.Value && row["InvoiceDate"] != null &&
                        DateTime.TryParse(row["InvoiceDate"].ToString(), out DateTime d))
                        dtpInvoiceDate.Value = d;
                }

                if (row.Table.Columns.Contains("ElectricityUsage"))
                    txtElectricityUsage.Text = row["ElectricityUsage"] != DBNull.Value && row["ElectricityUsage"] != null ? row["ElectricityUsage"].ToString() : "";
                if (row.Table.Columns.Contains("ElectricityAmount"))
                    txtElectricityAmount.Text = row["ElectricityAmount"] != DBNull.Value && row["ElectricityAmount"] != null ? row["ElectricityAmount"].ToString() : "";
                if (row.Table.Columns.Contains("WaterUsage"))
                    txtWaterUsage.Text = row["WaterUsage"] != DBNull.Value && row["WaterUsage"] != null ? row["WaterUsage"].ToString() : "";
                if (row.Table.Columns.Contains("WaterAmount"))
                    txtWaterAmount.Text = row["WaterAmount"] != DBNull.Value && row["WaterAmount"] != null ? row["WaterAmount"].ToString() : "";
                if (row.Table.Columns.Contains("OtherFees"))
                    txtOtherFees.Text = row["OtherFees"] != DBNull.Value && row["OtherFees"] != null ? row["OtherFees"].ToString() : "";
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
                DataTable dt = tenantInvoices.GET_ALL_TenantInvoices();
                dgvInvoices.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل البيانات: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvInvoices_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInvoices?.SelectedRows.Count != 1 || !isFieldsEditable) return;
            DataGridViewRow row = dgvInvoices.SelectedRows[0];
            if (row.IsNewRow) return;
            // يمكن ملء الحقول عند التعديل لاحقاً
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string invoiceNo = (txtInvoiceNo?.Text ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(invoiceNo))
            {
                MessageBox.Show("الرجاء اختيار فاتورة أولاً عن طريق زر العرض.", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetEditMode(true);
            SetFieldsEditable(true);
            SetInvoiceNoEditable(false);
            txtTenantNo?.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string invoiceNo = (txtInvoiceNo?.Text ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(invoiceNo))
            {
                MessageBox.Show("الرجاء اختيار فاتورة أولاً عن طريق زر العرض.", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"هل أنت متأكد من حذف الفاتورة رقم ({invoiceNo})؟",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                financialMovements.DELETE_FinancialMovements("2", invoiceNo);
                tenantInvoices.DELETE_TenantInvoice(invoiceNo);
                MessageBox.Show("تم حذف الفاتورة بنجاح.", "تم",
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
