using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Dari.Clas;

namespace Dari
{
    public partial class UC_RentCalculation : UserControl
    {
        private RentCalculation rentCalculation;
        private Buildings buildings;
        private GridBtnViewHelper gridBtnViewHelper;
        private bool isFieldsEditable = false;

        public UC_RentCalculation()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            rentCalculation = new RentCalculation();
            buildings = new Buildings();
            gridBtnViewHelper = new GridBtnViewHelper();

            FillYearCombo();
            FillMonthCombo();
            SetDefaultCalculationDate();
            SetFieldsEditable(false);

            if (btnClose != null) btnClose.Click += BtnClose_Click;
            if (btnCalculate != null) btnCalculate.Click += BtnCalculate_Click;
            if (btnAdd != null) btnAdd.Click += BtnAdd_Click;
            if (btnSave != null) btnSave.Click += BtnSave_Click;

            if (txtPropertyNo != null)
            {
                txtPropertyNo.KeyDown += TxtPropertyNo_KeyDown;
                txtPropertyNo.Enter += TxtPropertyNo_Enter;
            }

            WireReadOnlyFocusGuards();
        }

        /// <summary>
        /// ربط حدث Enter لجميع الحقول لمنع الفوكس عند وضع القراءة فقط
        /// </summary>
        private void WireReadOnlyFocusGuards()
        {
            if (txtCalculationNo != null) txtCalculationNo.Enter += PreventFocusWhenReadOnly;
            if (dtpCalculationDate != null) dtpCalculationDate.Enter += PreventFocusWhenReadOnly;
            if (txtPropertyNo != null) txtPropertyNo.Enter += PreventFocusWhenReadOnly;
            if (cmbYear != null) cmbYear.Enter += PreventFocusWhenReadOnly;
            if (cmbMonth != null) cmbMonth.Enter += PreventFocusWhenReadOnly;
        }

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

        private void SetFieldsEditable(bool isEditable)
        {
            isFieldsEditable = isEditable;
            SetCalculationNoEditable(false);
            if (txtCalculationNo != null) { txtCalculationNo.ReadOnly = !isEditable; txtCalculationNo.TabStop = isEditable; }
            if (dtpCalculationDate != null) dtpCalculationDate.Enabled = isEditable;
            if (txtPropertyNo != null) { txtPropertyNo.ReadOnly = !isEditable; txtPropertyNo.TabStop = isEditable; }
            if (cmbYear != null) cmbYear.Enabled = isEditable;
            if (cmbMonth != null) cmbMonth.Enabled = isEditable;
        }

        private void SetCalculationNoEditable(bool isEditable)
        {
            if (txtCalculationNo == null) return;
            txtCalculationNo.ReadOnly = !isEditable;
            txtCalculationNo.TabStop = isEditable;
        }

        private void TxtPropertyNo_Enter(object sender, EventArgs e)
        {
            if (txtPropertyNo != null && isFieldsEditable)
                txtPropertyNo.ReadOnly = true;
        }

        private void TxtPropertyNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F2 || e.KeyCode == Keys.Space ||
                (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) ||
                (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                OpenPropertySearchPopup();
            }
        }

        private void OpenPropertySearchPopup()
        {
            try
            {
                DataTable dt = buildings.GET_ALL_Buildings();
                DataRow row = gridBtnViewHelper.Show(dt, "البحث عن العقارات");
                if (row != null)
                {
                    string propertyNo = row.Table.Columns.Contains("PropertyNo") ? (row["PropertyNo"]?.ToString() ?? "") : "";
                    string propertyName = row.Table.Columns.Contains("PropertyName") ? (row["PropertyName"]?.ToString() ?? "") : "";
                    if (!string.IsNullOrWhiteSpace(propertyNo))
                    {
                        txtPropertyNo.Tag = propertyNo;
                        txtPropertyNo.Text = string.IsNullOrWhiteSpace(propertyName) ? propertyNo : propertyName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء البحث عن العقارات: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillYearCombo()
        {
            if (cmbYear == null) return;
            cmbYear.Items.Clear();
            int year = DateTime.Now.Year;
            for (int i = year - 2; i <= year + 1; i++)
                cmbYear.Items.Add(i.ToString());
            if (cmbYear.Items.Count > 0)
            {
                string currentYear = year.ToString();
                int idx = cmbYear.Items.IndexOf(currentYear);
                if (idx >= 0) cmbYear.SelectedIndex = idx;
                else cmbYear.SelectedIndex = 0;
            }
        }

        private void FillMonthCombo()
        {
            if (cmbMonth == null || cmbMonth.Items.Count == 0) return;
            int month = DateTime.Now.Month;
            if (cmbMonth.Items.Count >= month)
                cmbMonth.SelectedIndex = month - 1;
        }

        private void SetDefaultCalculationDate()
        {
            if (dtpCalculationDate != null)
                dtpCalculationDate.Value = DateTime.Now;
        }

        private void ClearFields()
        {
            if (txtCalculationNo != null) txtCalculationNo.Text = string.Empty;
            if (dtpCalculationDate != null) dtpCalculationDate.Value = DateTime.Now;
            if (txtPropertyNo != null) { txtPropertyNo.Text = string.Empty; txtPropertyNo.Tag = null; }
            if (cmbYear != null && cmbYear.Items.Count > 0)
            {
                string y = DateTime.Now.Year.ToString();
                int i = cmbYear.Items.IndexOf(y);
                if (i >= 0) cmbYear.SelectedIndex = i; else cmbYear.SelectedIndex = 0;
            }
            if (cmbMonth != null && cmbMonth.Items.Count > 0)
                cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
            if (dgvRentSummary != null) dgvRentSummary.DataSource = null;
            RefreshTotalAmount();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SetFieldsEditable(true);
            ClearFields();
            try
            {
                string nextNo = rentCalculation.GET_NEXT_CalculationNo();

                // إذا لم يوجد رقم سابق (أول مرة/لا توجد بيانات) نسمح للمستخدم بإدخال الرقم يدوياً
                if (nextNo == "1")
                {
                    SetCalculationNoEditable(true);
                    MessageBox.Show(
                        "لا يوجد رقم سابق للاحتساب.\nالرجاء إدخال رقم الاحتساب يدوياً لأول مرة، وسيتم توليد الرقم التالي تلقائياً لاحقاً.",
                        "تنبيه",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    txtCalculationNo?.Focus();
                    return;
                }

                if (txtCalculationNo != null) txtCalculationNo.Text = nextNo;
                SetCalculationNoEditable(false);
                if (cmbMonth != null && cmbMonth.Items.Count >= DateTime.Now.Month)
                    cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
                txtPropertyNo?.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء توليد رقم الاحتساب: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            string propertyNo = txtPropertyNo?.Tag?.ToString() ?? (txtPropertyNo?.Text ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(propertyNo))
            {
                MessageBox.Show("الرجاء إدخال رقم العقار.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPropertyNo?.Focus();
                return;
            }

            try
            {
                DataTable dt = rentCalculation.GetRentSummaryByProperty(propertyNo);
                dgvRentSummary.DataSource = dt;
                RefreshTotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء احتساب الإيجار: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshTotalAmount()
        {
            if (lblTotal == null) return;

            decimal sum = 0;
            var dt = dgvRentSummary?.DataSource as DataTable;
            if (dt != null && dt.Rows.Count > 0)
            {
                string totalCol = null;
                foreach (DataColumn col in dt.Columns)
                {
                    string name = (col.ColumnName ?? "").Trim();
                    if (name == "الاجمالي" || name == "الإجمالي" || name.Equals("Total", StringComparison.OrdinalIgnoreCase) ||
                        name.Equals("TotalLineAmount", StringComparison.OrdinalIgnoreCase))
                    {
                        totalCol = col.ColumnName;
                        break;
                    }
                }
                if (totalCol != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row.IsNull(totalCol)) continue;
                        var val = row[totalCol];
                        if (val is decimal d) sum += d;
                        else if (val is double dbl) sum += (decimal)dbl;
                        else if (decimal.TryParse(val?.ToString(), out decimal parsed)) sum += parsed;
                    }
                }
            }
            lblTotal.Text = "الاجمالي: " + sum.ToString("N2");
        }

        /// <summary>
        /// يرجع مجموع عمود الإجمالي في الـ Grid (للاستخدام في الحفظ).
        /// </summary>
        private decimal GetTotalAmountDecimal()
        {
            decimal sum = 0;
            var dt = dgvRentSummary?.DataSource as DataTable;
            if (dt != null && dt.Rows.Count > 0)
            {
                string totalCol = null;
                foreach (DataColumn col in dt.Columns)
                {
                    string name = (col.ColumnName ?? "").Trim();
                    if (name == "الاجمالي" || name == "الإجمالي" || name.Equals("Total", StringComparison.OrdinalIgnoreCase) ||
                        name.Equals("TotalLineAmount", StringComparison.OrdinalIgnoreCase))
                    {
                        totalCol = col.ColumnName;
                        break;
                    }
                }
                if (totalCol != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row.IsNull(totalCol)) continue;
                        var val = row[totalCol];
                        if (val is decimal d) sum += d;
                        else if (val is double dbl) sum += (decimal)dbl;
                        else if (decimal.TryParse(val?.ToString(), out decimal parsed)) sum += parsed;
                    }
                }
            }
            return sum;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string calculationNo = (txtCalculationNo?.Text ?? string.Empty).Trim();
            string propertyNo = txtPropertyNo?.Tag?.ToString() ?? (txtPropertyNo?.Text ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(calculationNo))
            {
                MessageBox.Show("الرجاء إدخال رقم الاحتساب أو الضغط على إضافة لتوليده.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCalculationNo?.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(propertyNo))
            {
                MessageBox.Show("الرجاء إدخال رقم العقار.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPropertyNo?.Focus();
                return;
            }
            if (cmbYear?.SelectedItem == null || cmbMonth?.SelectedIndex < 0)
            {
                MessageBox.Show("الرجاء اختيار السنة والشهر.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(cmbYear.SelectedItem.ToString(), out int billYear))
            {
                MessageBox.Show("قيمة السنة غير صحيحة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            byte billMonth = (byte)(cmbMonth.SelectedIndex + 1);
            DateTime calculationDate = dtpCalculationDate?.Value ?? DateTime.Now;
            decimal totalAmount = GetTotalAmountDecimal();

            try
            {
                rentCalculation.AddMst(calculationNo, propertyNo, billYear, billMonth, calculationDate, totalAmount);
                MessageBox.Show("تم حفظ الاحتساب بنجاح.", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetFieldsEditable(false);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الحفظ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
