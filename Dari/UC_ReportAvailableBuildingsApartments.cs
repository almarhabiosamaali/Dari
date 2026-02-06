using System;
using System.Data;
using System.Windows.Forms;
using Dari.Clas;

namespace Dari
{
    /// <summary>
    /// شاشة تقرير المباني والشقق المتاحة.
    /// </summary>
    public partial class UC_ReportAvailableBuildingsApartments : UserControl
    {
        private GridBtnViewHelper _gridBtnViewHelper;
        private Buildings _buildings;
        private ReportGetApartmentsStatus _reportGetApartmentsStatus;

        public UC_ReportAvailableBuildingsApartments()
        {
            InitializeComponent();
            if (DesignMode) return;

            _gridBtnViewHelper = new GridBtnViewHelper();
            _buildings = new Buildings();
            _reportGetApartmentsStatus = new ReportGetApartmentsStatus();

            if (btnClose != null)
                btnClose.Click += BtnClose_Click;
            if (btnPreview != null)
                btnPreview.Click += BtnPreview_Click;
            if (txtPropertyNo != null)
                txtPropertyNo.KeyDown += TxtPropertyNo_KeyDown;
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
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
                dt = _reportGetApartmentsStatus.GetApartmentsStatus(P_where());
                if (dt != null && dt.Rows.Count == 0)
                    errorMessage = "لا توجد بيانات مطابقة لمعايير البحث.";
            }
            catch (Exception ex)
            {
                errorMessage = "خطأ عند جلب البيانات: " + ex.Message;
            }
        }

        /// <summary>
        /// يبني شرط الفلتر @P_Whr للإجراء المخزن sp_ReportGetApartmentsStatus.
        /// </summary>
        private string P_where()
        {
            string p_whr = null;
            string propertyNo = GetPropertyNo();
            if (!string.IsNullOrWhiteSpace(propertyNo))
                p_whr = (p_whr ?? "") + " and PropertyNo = N'" + propertyNo.Replace("'", "''") + "' ";

            if (cmbStatus != null && cmbStatus.SelectedIndex == 1) // المتاحة
                p_whr = (p_whr ?? "") + " and IsRented = 0 ";
            else if (cmbStatus != null && cmbStatus.SelectedIndex == 2) // المؤجرة
                p_whr = (p_whr ?? "") + " and IsRented = 1 ";

            return p_whr;
        }

        private string GetPropertyNo()
        {
            var v = (txtPropertyNo?.Tag ?? txtPropertyNo?.Text)?.ToString()?.Trim();
            return string.IsNullOrWhiteSpace(v) ? null : v;
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
                OpenBuildingSearchPopup();
            }
        }

        private void OpenBuildingSearchPopup()
        {
            try
            {
                var dt = _buildings.GET_ALL_Buildings();
                var row = _gridBtnViewHelper.Show(dt, "البحث عن المباني");
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
                MessageBox.Show("حدث خطأ أثناء البحث عن المباني: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dt = _reportGetApartmentsStatus.GetApartmentsStatus(P_where());
            RPT.ReportGetApartmentsStatus myRept = new RPT.ReportGetApartmentsStatus();
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
