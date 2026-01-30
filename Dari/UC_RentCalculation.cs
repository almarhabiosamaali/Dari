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

            if (btnClose != null) btnClose.Click += BtnClose_Click;
            if (btnCalculate != null) btnCalculate.Click += BtnCalculate_Click;

            if (txtPropertyNo != null)
            {
                txtPropertyNo.KeyDown += TxtPropertyNo_KeyDown;
                txtPropertyNo.Enter += TxtPropertyNo_Enter;
            }
        }

        private void TxtPropertyNo_Enter(object sender, EventArgs e)
        {
            if (txtPropertyNo != null)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء احتساب الإيجار: {ex.Message}", "خطأ",
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
