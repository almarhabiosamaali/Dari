using System;
using System.Data;
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
        private ReportTenantMonthlyStatement _reportTenantMonthlyStatement;

        public UC_TenantMonthlyStatement()
        {
            InitializeComponent();
            if (DesignMode) return;

            _gridBtnViewHelper = new GridBtnViewHelper();
            _tenants = new Tenants();
            _reportTenantMonthlyStatement = new ReportTenantMonthlyStatement();

            if (btnClose != null)
                btnClose.Click += BtnClose_Click;
            if (btnPreview != null)
                btnPreview.Click += BtnPreview_Click;
            if (txtTenantNo != null)
                txtTenantNo.KeyDown += TxtTenantNo_KeyDown;

            Load += UC_TenantMonthlyStatement_Load;
        }

        private string GetTenantNo()
        {
            var v = (txtTenantNo?.Tag ?? txtTenantNo?.Text)?.ToString()?.Trim();
            return string.IsNullOrWhiteSpace(v) ? null : v;
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GetTenantNo()))
            {
                MessageBox.Show("يرجى إدخال أو اختيار رقم المستأجر.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbYear?.SelectedItem == null)
            {
                MessageBox.Show("يرجى اختيار السنة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GetReportData(out DataTable dt, out string msg);
            if (dt == null)
            {
                MessageBox.Show(msg ?? "لم يتم جلب أي بيانات.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvReport.DataSource = null;
            dgvReport.DataSource = dt;
            dgvReport.Visible = true;
            dgvReport.BringToFront();
            dgvReport.Refresh();

            if (dt.Rows.Count == 0)
                MessageBox.Show("لا توجد بيانات مطابقة لمعايير البحث.", "معاينة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GetReportData(out DataTable dt, out string errorMessage)
        {
            dt = null;
            errorMessage = null;
            try
            {
                MessageBox.Show(P_where() +"----"+ cmbArrears.SelectedIndex.ToString());
                dt = _reportTenantMonthlyStatement.GetTenantMonthlyStatement(P_where(), cmbArrears.SelectedIndex);
                if (dt != null && dt.Rows.Count == 0)
                    errorMessage = "لا توجد حركات مطابقة لمعايير البحث.";
            }
            catch (Exception ex)
            {
                errorMessage = "خطأ عند جلب البيانات: " + ex.Message;
            }
        }

        /// <summary>
        /// يبني شرط الفلتر @P_Whr للإجراء المخزن sp_TenantMonthlyStatement.
        /// </summary>
        private string P_where()
        {
            string p_whr = null;
            string tenantNo = GetTenantNo();
            if (!string.IsNullOrWhiteSpace(tenantNo))
                p_whr = (p_whr ?? "") + " and TenantNo = N'" + tenantNo.Replace("'", "''") + "' ";

            if (cmbYear != null && cmbYear.SelectedItem != null && int.TryParse(cmbYear.SelectedItem.ToString(), out int year))
                p_whr = (p_whr ?? "") + " and BillYear = " + year + " ";

            int? fromMonth = (cmbFromMonth != null && cmbFromMonth.SelectedIndex >= 0) ? cmbFromMonth.SelectedIndex + 1 : (int?)null;
            int? toMonth = (cmbToMonth != null && cmbToMonth.SelectedIndex >= 0) ? cmbToMonth.SelectedIndex + 1 : (int?)null;
            if (fromMonth.HasValue && toMonth.HasValue)
                p_whr = (p_whr ?? "") + " and BillMonth BETWEEN " + fromMonth + " AND " + toMonth + " ";

            //if (cmbArrears != null && cmbArrears.SelectedIndex == 1) // المتأخرات فقط
            //    p_whr = (p_whr ?? "") + " and ArrearsOnly = 1 ";

            return p_whr;
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //if (_lastReportData == null || _lastReportData.Rows.Count == 0)
            //{
            //    MessageBox.Show("قم بعرض التقرير أولاً (عرض / معاينة) ثم اختر طباعة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            dt = _reportTenantMonthlyStatement.GetTenantMonthlyStatement(P_where(), cmbArrears.SelectedIndex);
            RPT.TenantMonthlyStatement myRept = new RPT.TenantMonthlyStatement();
            myRept.DataSourceConnections[0].IntegratedSecurity = false;
            myRept.DataSourceConnections[0].SetConnection(Properties.Settings.Default.Server, Properties.Settings.Default.Database, Properties.Settings.Default.ID, Properties.Settings.Default.Password);
            myRept.SetDataSource(dt);
            // myReport.SetParameterValue("@p_whr", p);
            RPT.reportCaller myFom = new RPT.reportCaller();
            myFom.crystalReportViewer1.ReportSource = myRept;
            myFom.ShowDialog();
        }
    }
}
