using System;
using System.Windows.Forms;
using Dari.Clas;

namespace Dari
{
    /// <summary>
    /// شاشة تقرير كشف المستأجر الشهري.
    /// </summary>
    public partial class UC_TenantMonthlyStatement : UserControl
    {
        private GridBtnViewHelper _gridBtnViewHelper;
        private Tenants _tenants;

        public UC_TenantMonthlyStatement()
        {
            InitializeComponent();
            if (DesignMode) return;

            _gridBtnViewHelper = new GridBtnViewHelper();
            _tenants = new Tenants();

            if (btnClose != null)
                btnClose.Click += BtnClose_Click;
            if (txtTenantNo != null)
                txtTenantNo.KeyDown += TxtTenantNo_KeyDown;

            Load += UC_TenantMonthlyStatement_Load;
        }

        private void UC_TenantMonthlyStatement_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            FillYearCombo();
        }

        private void FillYearCombo()
        {
            if (cmbYear == null) return;
            cmbYear.Items.Clear();
            int currentYear = DateTime.Today.Year;
            for (int y = currentYear - 2; y <= currentYear + 1; y++)
                cmbYear.Items.Add(y.ToString());
            if (cmbYear.Items.Count > 0)
                cmbYear.SelectedIndex = Math.Min(2, cmbYear.Items.Count - 1);
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
                var dt = _tenants.GET_ALL_Tenants();
                var row = _gridBtnViewHelper.Show(dt, "البحث عن المستأجرين");
                if (row != null)
                {
                    string tenantNo = row.Table.Columns.Contains("TenantNo") ? (row["TenantNo"]?.ToString() ?? "") : "";
                    string tenantName = row.Table.Columns.Contains("TenantName") ? (row["TenantName"]?.ToString() ?? "") : "";
                    if (!string.IsNullOrWhiteSpace(tenantNo))
                    {
                        txtTenantNo.Tag = tenantNo;
                        txtTenantNo.Text = string.IsNullOrWhiteSpace(tenantName) ? tenantNo : tenantName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء البحث عن المستأجرين: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (FindForm() is Form1 mainForm)
            {
                mainForm.ShowHome();
                return;
            }
            Visible = false;
        }
    }
}
