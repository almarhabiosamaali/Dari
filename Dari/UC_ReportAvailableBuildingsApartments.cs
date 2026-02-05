using System;
using System.Windows.Forms;
using Dari.Clas;

namespace Dari
{
    /// <summary>
    /// شاشة تقرير المباني والشقق المتاحة (التصميم فقط).
    /// </summary>
    public partial class UC_ReportAvailableBuildingsApartments : UserControl
    {
        private GridBtnViewHelper _gridBtnViewHelper;
        private Buildings _buildings;

        public UC_ReportAvailableBuildingsApartments()
        {
            InitializeComponent();
            if (DesignMode) return;

            _gridBtnViewHelper = new GridBtnViewHelper();
            _buildings = new Buildings();

            if (btnClose != null)
                btnClose.Click += BtnClose_Click;
            if (txtPropertyNo != null)
                txtPropertyNo.KeyDown += TxtPropertyNo_KeyDown;
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
    }
}
