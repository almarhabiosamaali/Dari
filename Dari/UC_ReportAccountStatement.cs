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
        private int _printRowIndex; // لترقيم الصفحات عند الطباعة

        public UC_ReportAccountStatement()
        {
            InitializeComponent();
            if (DesignMode) return;

            _reportAccountStatement = new ReportAccountStatement();

            if (btnClose != null) btnClose.Click += BtnClose_Click;
            if (cmbReportType != null) cmbReportType.SelectedIndexChanged += CmbReportType_SelectedIndexChanged;
            if (btnPreview != null) btnPreview.Click += BtnPreview_Click;
            if (btnPrint != null) btnPrint.Click += BtnPrint_Click;

            Load += UC_ReportAccountStatement_Load;
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
            if (_lastReportData == null || _lastReportData.Rows.Count == 0)
            {
                MessageBox.Show("قم بعرض التقرير أولاً (عرض / معاينة) ثم اختر طباعة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //using (var printDoc = new PrintDocument())
            //{
            //    printDoc.BeginPrint += PrintDoc_BeginPrint;
            //    printDoc.PrintPage += PrintDoc_PrintPage;
            //    using (var pp = new PrintPreviewDialog())
            //    {
            //        pp.Document = printDoc;
            //        pp.ShowDialog();
            //    }
            //}
        }

        private void PrintDoc_BeginPrint(object sender, PrintEventArgs e)
        {
            _printRowIndex = 0;
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (_lastReportData == null || _lastReportData.Columns.Count == 0) return;

            var g = e.Graphics;
            var margin = e.MarginBounds;
            float left = margin.Left;
            float width = margin.Width;
            float y = margin.Top;

            // خط الهامش للجدول
            const float padding = 4f;
            const float rowHeight = 24f;
            const float headerHeight = 28f;
            int colCount = _lastReportData.Columns.Count;
            float colWidth = width / colCount;
            float[] colWidths = new float[colCount];
            for (int i = 0; i < colCount; i++) colWidths[i] = colWidth;

            using (var fontTitle = new Font("Arial", 16, FontStyle.Bold))
            using (var fontHeader = new Font("Arial", 9, FontStyle.Bold))
            using (var fontCell = new Font("Arial", 8))
            using (var sfCenter = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            using (var sfRight = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center })
            using (var sfLeft = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center })
            {
                sfCenter.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
                sfRight.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
                sfLeft.FormatFlags |= StringFormatFlags.DirectionRightToLeft;

                // عنوان التقرير
                g.DrawString("كشف الحساب", fontTitle, Brushes.Black, left + width / 2f, y + 14f, new StringFormat(sfCenter) { Alignment = StringAlignment.Center });
                y += 36f;

                float tableLeft = left;
                float tableWidth = width;
                float tableTop = y;

                // صف العناوين
                float x = tableLeft;
                using (var brushHeader = new SolidBrush(Color.FromArgb(240, 240, 240)))
                using (var pen = new Pen(Color.Black, 1f))
                {
                    g.FillRectangle(brushHeader, x, y, tableWidth, headerHeight);
                    g.DrawRectangle(pen, x, y, tableWidth, headerHeight);
                    for (int c = 0; c < colCount; c++)
                    {
                        if (c > 0) g.DrawLine(pen, x, y, x, y + headerHeight);
                        var rect = new RectangleF(x + padding, y + padding, colWidths[c] - padding * 2, headerHeight - padding * 2);
                        g.DrawString(_lastReportData.Columns[c].ColumnName, fontHeader, Brushes.Black, rect, sfCenter);
                        x += colWidths[c];
                    }
                }
                y += headerHeight;

                // صفوف البيانات
                using (var pen = new Pen(Color.Gray, 0.75f))
                {
                    while (_printRowIndex < _lastReportData.Rows.Count)
                    {
                        if (y + rowHeight > margin.Bottom - 24)
                        {
                            using (var penOuter = new Pen(Color.Black, 1.5f))
                                g.DrawRectangle(penOuter, tableLeft, tableTop, tableWidth, y - tableTop);
                            e.HasMorePages = true;
                            return;
                        }

                        DataRow row = _lastReportData.Rows[_printRowIndex];
                        float rowY = y;
                        x = tableLeft;
                        for (int c = 0; c < colCount; c++)
                        {
                            if (c > 0) g.DrawLine(pen, x, rowY, x, rowY + rowHeight);
                            string cellText = row[c]?.ToString() ?? "";
                            if (row[c] is DateTime dt)
                                cellText = dt.ToString("yyyy-MM-dd");
                            else if (row[c] is decimal)
                                cellText = string.Format("{0:N2}", row[c]);
                            var rect = new RectangleF(x + padding, rowY + padding, colWidths[c] - padding * 2, rowHeight - padding * 2);
                            // أعمدة الأرقام (مدين/دائن) بمحاذاة لليمين، الباقي لليسار
                            var sf = (c >= colCount - 2) ? sfRight : sfLeft;
                            g.DrawString(cellText, fontCell, Brushes.Black, rect, sf);
                            x += colWidths[c];
                        }
                        g.DrawLine(pen, tableLeft, rowY + rowHeight, tableLeft + tableWidth, rowY + rowHeight);
                        y += rowHeight;
                        _printRowIndex++;
                    }
                }

                // إطار خارجي للجدول بالكامل
                float tableHeight = y - tableTop;
                using (var penOuter = new Pen(Color.Black, 1.5f))
                    g.DrawRectangle(penOuter, tableLeft, tableTop, tableWidth, tableHeight);

                // تذييل الصفحة (فقط في الصفحة الأخيرة)
                if (!e.HasMorePages)
                    g.DrawString("— نهاية كشف الحساب —", fontCell, Brushes.Gray, left + width / 2f, margin.Bottom - 14f, new StringFormat(sfCenter));
            }
        }

        private bool ValidateFilters(out string message)
        {
            message = null;
            int reportType = cmbReportType.SelectedIndex;
            if (reportType == 0) // مستأجر
            {
                if (string.IsNullOrWhiteSpace(txtTenantNo?.Text))
                {
                    message = "يرجى إدخال رقم المستأجر.";
                    return false;
                }
            }
            else if (reportType == 1) // عقار
            {
                if (string.IsNullOrWhiteSpace(txtPropertyNo?.Text))
                {
                    message = "يرجى إدخال رقم العقار.";
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

            // نوع المستند: الكل = null, إيجار=1, فاتورة=2, سندات=3
            string movementTypeFilter = null;
            if (cmbDocumentType != null && cmbDocumentType.SelectedIndex > 0)
                movementTypeFilter = cmbDocumentType.SelectedIndex == 1 ? "1" : cmbDocumentType.SelectedIndex == 2 ? "2" : "3";

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



        string P_where ()
        {
            string p_whr = null;
            if(txtTenantNo.Text != null || txtTenantNo.Text != null)
            {
                p_whr = p_whr + " and TenantNo = " + txtTenantNo.Text + "";
            }

            return p_whr;
        }
    }
}
