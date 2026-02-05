using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Dari.Clas;
using System.Data.SqlClient;
using System.Data;

namespace Dari
{
    /// <summary>
    /// شاشة فلتر تقرير كشف الحساب (مستأجر أو عقار) وعرض/طباعة النتائج.
    /// </summary>
    public partial class UC_ReportAccountStatement : UserControl
    {
        private ReportAccountStatement _reportAccountStatement;
        private DataTable _lastReportData;
        
        private GridBtnViewHelper _gridBtnViewHelper;
        private Tenants _tenants;
        private Buildings _buildings;
        private Apartments _apartments;

        public UC_ReportAccountStatement()
        {
            InitializeComponent();
            if (DesignMode) return;

            _reportAccountStatement = new ReportAccountStatement();
            _gridBtnViewHelper = new GridBtnViewHelper();
            _tenants = new Tenants();
            _buildings = new Buildings();
            _apartments = new Apartments();

            if (btnClose != null) btnClose.Click += BtnClose_Click;
            if (cmbReportType != null) cmbReportType.SelectedIndexChanged += CmbReportType_SelectedIndexChanged;
            if (btnPreview != null) btnPreview.Click += BtnPreview_Click;
            if (btnPrint != null) btnPrint.Click += BtnPrint_Click;

            if (txtTenantNo != null) txtTenantNo.KeyDown += TxtTenantNo_KeyDown;
            if (txtPropertyNo != null) txtPropertyNo.KeyDown += TxtPropertyNo_KeyDown;
            if (txtApartmentNo != null) txtApartmentNo.KeyDown += TxtApartmentNo_KeyDown;

            Load += UC_ReportAccountStatement_Load;
        }

        /// <summary>رقم المستأجر الفعلي (من البحث أو من النص)</summary>
        private string GetTenantNo()
        {
            var v = (txtTenantNo?.Tag ?? txtTenantNo?.Text)?.ToString()?.Trim();
            return string.IsNullOrWhiteSpace(v) ? null : v;
        }

        /// <summary>رقم العقار الفعلي (من البحث أو من النص)</summary>
        private string GetPropertyNo()
        {
            var v = (txtPropertyNo?.Tag ?? txtPropertyNo?.Text)?.ToString()?.Trim();
            return string.IsNullOrWhiteSpace(v) ? null : v;
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

        private void TxtApartmentNo_KeyDown(object sender, KeyEventArgs e)
        {
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
                DataTable dt = _tenants.GET_ALL_Tenants();
                DataRow row = _gridBtnViewHelper.Show(dt, "البحث عن المستأجرين");
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

        private void OpenPropertySearchPopup()
        {
            try
            {
                DataTable dt = _buildings.GET_ALL_Buildings();
                DataRow row = _gridBtnViewHelper.Show(dt, "البحث عن العقارات");
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
                MessageBox.Show("حدث خطأ أثناء البحث عن العقارات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenApartmentSearchPopup()
        {
            try
            {
                DataTable dt = _apartments.GET_ALL_Apartments();
                DataRow row = _gridBtnViewHelper.Show(dt, "البحث عن الشقق");
                if (row != null)
                {
                    string apartmentNo = row.Table.Columns.Contains("ApartmentNo") ? (row["ApartmentNo"]?.ToString() ?? "") : "";
                    if (!string.IsNullOrWhiteSpace(apartmentNo))
                    {
                        txtApartmentNo.Text = apartmentNo;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء البحث عن الشقق: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_ReportAccountStatement_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            FillYearCombo();
            cmbReportType.SelectedIndex = 0;
            ApplyReportTypeVisibility();
        }

        private void FillYearCombo()
        {
            if (cmbYear == null) return;
            cmbYear.Items.Clear();
            int currentYear = DateTime.Today.Year;
            for (int y = currentYear - 2; y <= currentYear + 1; y++)
                cmbYear.Items.Add(y.ToString());
            if (cmbYear.Items.Count > 0)
                cmbYear.SelectedIndex = Math.Min(2, cmbYear.Items.Count - 1); // تقريباً السنة الحالية
        }

        private void CmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyReportTypeVisibility();
        }

        private void ApplyReportTypeVisibility()
        {
            if (cmbReportType == null) return;
            bool isTenant = cmbReportType.SelectedIndex == 0; // كشف حساب مستأجر
            if (lblTenantNo != null) lblTenantNo.Visible = isTenant;
            if (txtTenantNo != null) txtTenantNo.Visible = isTenant;
            if (lblPropertyNo != null) lblPropertyNo.Visible = !isTenant;
            if (txtPropertyNo != null) txtPropertyNo.Visible = !isTenant;
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

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            if (!ValidateFilters(out string msg))
            {
                MessageBox.Show(msg, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GetReportData(out DataTable dt, out msg);
            if (dt == null)
            {
                MessageBox.Show(msg ?? "لم يتم جلب أي بيانات.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _lastReportData = dt;
            dgvReport.DataSource = null;
            dgvReport.DataSource = dt;
            dgvReport.Visible = true;
            dgvReport.BringToFront();
            dgvReport.Refresh();

            if (dt.Rows.Count == 0)
                MessageBox.Show("لا توجد حركات مطابقة لمعايير البحث.", "معاينة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (_lastReportData == null || _lastReportData.Rows.Count == 0)
            {
                MessageBox.Show("قم بعرض التقرير أولاً (عرض / معاينة) ثم اختر طباعة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dt = _reportAccountStatement.GetAccountStatement(P_where());
            RPT.RepAcc myRept = new RPT.RepAcc();
            myRept.DataSourceConnections[0].IntegratedSecurity = false;
            myRept.DataSourceConnections[0].SetConnection(Properties.Settings.Default.Server, Properties.Settings.Default.Database, Properties.Settings.Default.ID, Properties.Settings.Default.Password);
            myRept.SetDataSource(dt);
            // myReport.SetParameterValue("@p_whr", p);
            RPT.reportCaller myFom = new RPT.reportCaller();
            myFom.crystalReportViewer1.ReportSource = myRept;
            myFom.ShowDialog();

        }

        

       

        private bool ValidateFilters(out string message)
        {
            message = null;
            int reportType = cmbReportType.SelectedIndex;
            if (reportType == 0) // مستأجر
            {
                if (string.IsNullOrWhiteSpace(GetTenantNo()))
                {
                    message = "يرجى إدخال أو اختيار رقم المستأجر (اضغط مفتاحاً في الحقل للبحث).";
                    return false;
                }
            }
            else if (reportType == 1) // عقار
            {
                if (string.IsNullOrWhiteSpace(GetPropertyNo()))
                {
                    message = "يرجى إدخال أو اختيار رقم العقار (اضغط مفتاحاً في الحقل للبحث).";
                    return false;
                }
            }

            if (cmbYear.SelectedIndex < 0)
            {
                message = "يرجى اختيار السنة.";
                return false;
            }

            return true;
        }

        private void GetReportData(out DataTable dt, out string errorMessage)
        {
            dt = null;
            errorMessage = null;

            int reportType = cmbReportType.SelectedIndex + 1; // 1 = مستأجر, 2 = عقار
            string tenantNo = reportType == 1 ? txtTenantNo?.Text?.Trim() : null;
            string propertyNo = reportType == 2 ? txtPropertyNo?.Text?.Trim() : null;
            string apartmentNo = txtApartmentNo?.Text?.Trim();

            if (!int.TryParse(cmbYear?.SelectedItem?.ToString(), out int year))
                year = DateTime.Today.Year;

            int? fromMonth = null;
            if (cmbFromMonth != null && cmbFromMonth.SelectedIndex >= 0)
                fromMonth = cmbFromMonth.SelectedIndex + 1;

            int? toMonth = null;
            if (cmbToMonth != null && cmbToMonth.SelectedIndex >= 0)
                toMonth = cmbToMonth.SelectedIndex + 1;

            try
            {
                dt = _reportAccountStatement.GetAccountStatement(P_where());

                if (dt != null && dt.Rows.Count == 0)
                    errorMessage = "لا توجد حركات مطابقة لمعايير البحث.";
            }
            catch (Exception ex)
            {
                errorMessage = "خطأ عند جلب البيانات: " + ex.Message;
            }
        }



        string P_where()
        {
            string p_whr = null;
            string tenantNo = GetTenantNo();
            if (!string.IsNullOrWhiteSpace(tenantNo))
            {
                p_whr = (p_whr ?? "") + " and TenantNo = N'" + tenantNo.Replace("'", "''") + "' ";
            }

            int? fromMonth = null;
            if (cmbFromMonth != null && cmbFromMonth.SelectedIndex >= 0)
                fromMonth = cmbFromMonth.SelectedIndex + 1;

            int? toMonth = null;
            if (cmbToMonth != null && cmbToMonth.SelectedIndex >= 0)
                toMonth = cmbToMonth.SelectedIndex + 1;

            if (fromMonth.HasValue && toMonth.HasValue)
            {
                p_whr = (p_whr ?? "") + " and BillMonth BETWEEN " + fromMonth + " AND " + toMonth + " ";
            }

            if (cmbYear != null && cmbYear.SelectedItem != null)
            {
                int year = int.Parse(cmbYear.SelectedItem.ToString());
                p_whr = (p_whr ?? "") + " and BillYear = " + year + " ";
            }

            if (!string.IsNullOrWhiteSpace(txtApartmentNo?.Text?.Trim()))
            {
                p_whr = (p_whr ?? "") + " and ApartmentNo = N'" + txtApartmentNo.Text.Trim().Replace("'", "''") + "' ";
            }

            string propertyNo = GetPropertyNo();
            if (!string.IsNullOrWhiteSpace(propertyNo))
            {
                p_whr = (p_whr ?? "") + " and PropertyNo = N'" + propertyNo.Replace("'", "''") + "' ";
            }

            if (cmbDocumentType != null && cmbDocumentType.SelectedIndex > 0)
            {
                string movementTypeFilter = cmbDocumentType.SelectedIndex == 1 ? "1" : cmbDocumentType.SelectedIndex == 2 ? "2" : "3";
                p_whr = (p_whr ?? "") + " and MovementType = N'" + movementTypeFilter + "' ";
            }

            return p_whr;
        }
    }
}
