using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Dari
{
    partial class UC_ReportAccountStatement
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new Panel();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.pnlForm = new Panel();
            this.dgvReport = new DataGridView();
            this.pnlFilters = new Panel();
            this.btnPrint = new MaterialSkin.Controls.MaterialButton();
            this.btnPreview = new MaterialSkin.Controls.MaterialButton();
            this.lblToMonth = new MaterialSkin.Controls.MaterialLabel();
            this.cmbToMonth = new MaterialSkin.Controls.MaterialComboBox();
            this.lblFromMonth = new MaterialSkin.Controls.MaterialLabel();
            this.cmbFromMonth = new MaterialSkin.Controls.MaterialComboBox();
            this.lblYear = new MaterialSkin.Controls.MaterialLabel();
            this.cmbYear = new MaterialSkin.Controls.MaterialComboBox();
            this.lblDocumentType = new MaterialSkin.Controls.MaterialLabel();
            this.cmbDocumentType = new MaterialSkin.Controls.MaterialComboBox();
            this.lblApartmentNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtApartmentNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblPropertyNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtPropertyNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblTenantNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenantNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblReportType = new MaterialSkin.Controls.MaterialLabel();
            this.cmbReportType = new MaterialSkin.Controls.MaterialComboBox();
            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = Color.FromArgb(33, 150, 243);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Location = new Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.RightToLeft = RightToLeft.Yes;
            this.pnlHeader.Size = new Size(1267, 74);
            this.pnlHeader.TabIndex = 0;
            //
            // btnClose
            //
            this.btnClose.AutoSize = false;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.HighEmphasis = false;
            this.btnClose.Icon = null;
            this.btnClose.Location = new Point(10, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(120, 45);
            this.btnClose.TabIndex = 99;
            this.btnClose.Text = "رجوع";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(1100, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(140, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "كشف الحساب";
            //
            // pnlForm
            //
            this.pnlForm.BackColor = Color.White;
            this.pnlForm.Controls.Add(this.pnlFilters);
            this.pnlForm.Controls.Add(this.dgvReport);
            this.pnlForm.Dock = DockStyle.Fill;
            this.pnlForm.Location = new Point(0, 74);
            this.pnlForm.Padding = new Padding(27, 25, 27, 25);
            this.pnlForm.RightToLeft = RightToLeft.Yes;
            this.pnlForm.Size = new Size(1267, 559);
            this.pnlForm.TabIndex = 1;
            //
            // pnlFilters
            //
            this.pnlFilters.Controls.Add(this.lblReportType);
            this.pnlFilters.Controls.Add(this.cmbReportType);
            this.pnlFilters.Controls.Add(this.lblTenantNo);
            this.pnlFilters.Controls.Add(this.txtTenantNo);
            this.pnlFilters.Controls.Add(this.lblPropertyNo);
            this.pnlFilters.Controls.Add(this.txtPropertyNo);
            this.pnlFilters.Controls.Add(this.lblApartmentNo);
            this.pnlFilters.Controls.Add(this.txtApartmentNo);
            this.pnlFilters.Controls.Add(this.lblDocumentType);
            this.pnlFilters.Controls.Add(this.cmbDocumentType);
            this.pnlFilters.Controls.Add(this.lblYear);
            this.pnlFilters.Controls.Add(this.cmbYear);
            this.pnlFilters.Controls.Add(this.lblFromMonth);
            this.pnlFilters.Controls.Add(this.cmbFromMonth);
            this.pnlFilters.Controls.Add(this.lblToMonth);
            this.pnlFilters.Controls.Add(this.cmbToMonth);
            this.pnlFilters.Controls.Add(this.btnPreview);
            this.pnlFilters.Controls.Add(this.btnPrint);
            this.pnlFilters.Dock = DockStyle.Top;
            this.pnlFilters.Location = new Point(27, 25);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.RightToLeft = RightToLeft.Yes;
            this.pnlFilters.Size = new Size(1213, 460);
            this.pnlFilters.TabIndex = 0;
            //
            // dgvReport
            //
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = Color.White;
            this.dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Dock = DockStyle.Fill;
            this.dgvReport.Margin = new Padding(0);
            this.dgvReport.MinimumSize = new Size(0, 180);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RightToLeft = RightToLeft.Yes;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.TabIndex = 1;
            this.dgvReport.Visible = true;
            //
            // lblReportType
            //
            this.lblReportType.AutoSize = true;
            this.lblReportType.Depth = 0;
            this.lblReportType.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblReportType.ForeColor = Color.FromArgb(180, 0, 0, 0);
            this.lblReportType.Location = new Point(1115, 0);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new Size(75, 19);
            this.lblReportType.TabIndex = 0;
            this.lblReportType.Text = "نوع الكشف:";
            //
            // cmbReportType
            //
            this.cmbReportType.AutoResize = false;
            this.cmbReportType.BackColor = Color.White;
            this.cmbReportType.Depth = 0;
            this.cmbReportType.DrawMode = DrawMode.OwnerDrawVariable;
            this.cmbReportType.DropDownHeight = 174;
            this.cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbReportType.DropDownWidth = 250;
            this.cmbReportType.Font = new Font("Microsoft Sans Serif", 11F);
            this.cmbReportType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.IntegralHeight = false;
            this.cmbReportType.ItemHeight = 43;
            this.cmbReportType.Items.AddRange(new object[] { "كشف حساب مستأجر", "كشف حساب عقار" });
            this.cmbReportType.Location = new Point(613, 21);
            this.cmbReportType.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.RightToLeft = RightToLeft.Yes;
            this.cmbReportType.Size = new Size(587, 49);
            this.cmbReportType.StartIndex = 0;
            this.cmbReportType.TabIndex = 0;
            //
            // lblTenantNo
            //
            this.lblTenantNo.AutoSize = true;
            this.lblTenantNo.Depth = 0;
            this.lblTenantNo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblTenantNo.ForeColor = Color.FromArgb(180, 0, 0, 0);
            this.lblTenantNo.Location = new Point(1095, 80);
            this.lblTenantNo.Name = "lblTenantNo";
            this.lblTenantNo.Size = new Size(95, 19);
            this.lblTenantNo.TabIndex = 0;
            this.lblTenantNo.Text = "رقم المستأجر:";
            //
            // txtTenantNo
            //
            this.txtTenantNo.AnimateReadOnly = false;
            this.txtTenantNo.CharacterCasing = CharacterCasing.Normal;
            this.txtTenantNo.Depth = 0;
            this.txtTenantNo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.txtTenantNo.HideSelection = false;
            this.txtTenantNo.LeadingIcon = null;
            this.txtTenantNo.Location = new Point(613, 101);
            this.txtTenantNo.MaxLength = 50;
            this.txtTenantNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenantNo.Name = "txtTenantNo";
            this.txtTenantNo.PasswordChar = '\0';
            this.txtTenantNo.PrefixSuffixText = null;
            this.txtTenantNo.ReadOnly = false;
            this.txtTenantNo.RightToLeft = RightToLeft.Yes;
            this.txtTenantNo.Size = new Size(587, 36);
            this.txtTenantNo.TabIndex = 1;
            this.txtTenantNo.TextAlign = HorizontalAlignment.Right;
            this.txtTenantNo.TrailingIcon = null;
            this.txtTenantNo.UseSystemPasswordChar = false;
            this.txtTenantNo.UseTallSize = false;
            //
            // lblPropertyNo
            //
            this.lblPropertyNo.AutoSize = true;
            this.lblPropertyNo.Depth = 0;
            this.lblPropertyNo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblPropertyNo.ForeColor = Color.FromArgb(180, 0, 0, 0);
            this.lblPropertyNo.Location = new Point(515, 80);
            this.lblPropertyNo.Name = "lblPropertyNo";
            this.lblPropertyNo.Size = new Size(75, 19);
            this.lblPropertyNo.TabIndex = 0;
            this.lblPropertyNo.Text = "رقم العقار:";
            //
            // txtPropertyNo
            //
            this.txtPropertyNo.AnimateReadOnly = false;
            this.txtPropertyNo.CharacterCasing = CharacterCasing.Normal;
            this.txtPropertyNo.Depth = 0;
            this.txtPropertyNo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.txtPropertyNo.HideSelection = false;
            this.txtPropertyNo.LeadingIcon = null;
            this.txtPropertyNo.Location = new Point(0, 101);
            this.txtPropertyNo.MaxLength = 50;
            this.txtPropertyNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPropertyNo.Name = "txtPropertyNo";
            this.txtPropertyNo.PasswordChar = '\0';
            this.txtPropertyNo.PrefixSuffixText = null;
            this.txtPropertyNo.ReadOnly = false;
            this.txtPropertyNo.RightToLeft = RightToLeft.Yes;
            this.txtPropertyNo.Size = new Size(587, 36);
            this.txtPropertyNo.TabIndex = 2;
            this.txtPropertyNo.TextAlign = HorizontalAlignment.Right;
            this.txtPropertyNo.TrailingIcon = null;
            this.txtPropertyNo.UseSystemPasswordChar = false;
            this.txtPropertyNo.UseTallSize = false;
            //
            // lblApartmentNo
            //
            this.lblApartmentNo.AutoSize = true;
            this.lblApartmentNo.Depth = 0;
            this.lblApartmentNo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblApartmentNo.ForeColor = Color.FromArgb(180, 0, 0, 0);
            this.lblApartmentNo.Location = new Point(1115, 155);
            this.lblApartmentNo.Name = "lblApartmentNo";
            this.lblApartmentNo.Size = new Size(78, 19);
            this.lblApartmentNo.TabIndex = 0;
            this.lblApartmentNo.Text = "رقم الشقة:";
            //
            // txtApartmentNo
            //
            this.txtApartmentNo.AnimateReadOnly = false;
            this.txtApartmentNo.CharacterCasing = CharacterCasing.Normal;
            this.txtApartmentNo.Depth = 0;
            this.txtApartmentNo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.txtApartmentNo.HideSelection = false;
            this.txtApartmentNo.LeadingIcon = null;
            this.txtApartmentNo.Location = new Point(613, 176);
            this.txtApartmentNo.MaxLength = 50;
            this.txtApartmentNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApartmentNo.Name = "txtApartmentNo";
            this.txtApartmentNo.PasswordChar = '\0';
            this.txtApartmentNo.PrefixSuffixText = null;
            this.txtApartmentNo.ReadOnly = false;
            this.txtApartmentNo.RightToLeft = RightToLeft.Yes;
            this.txtApartmentNo.Size = new Size(587, 36);
            this.txtApartmentNo.TabIndex = 3;
            this.txtApartmentNo.TextAlign = HorizontalAlignment.Right;
            this.txtApartmentNo.TrailingIcon = null;
            this.txtApartmentNo.UseSystemPasswordChar = false;
            this.txtApartmentNo.UseTallSize = false;
            //
            // lblDocumentType
            //
            this.lblDocumentType.AutoSize = true;
            this.lblDocumentType.Depth = 0;
            this.lblDocumentType.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblDocumentType.ForeColor = Color.FromArgb(180, 0, 0, 0);
            this.lblDocumentType.Location = new Point(515, 155);
            this.lblDocumentType.Name = "lblDocumentType";
            this.lblDocumentType.Size = new Size(88, 19);
            this.lblDocumentType.TabIndex = 0;
            this.lblDocumentType.Text = "نوع المستند:";
            //
            // cmbDocumentType
            //
            this.cmbDocumentType.AutoResize = false;
            this.cmbDocumentType.BackColor = Color.White;
            this.cmbDocumentType.Depth = 0;
            this.cmbDocumentType.DrawMode = DrawMode.OwnerDrawVariable;
            this.cmbDocumentType.DropDownHeight = 174;
            this.cmbDocumentType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbDocumentType.DropDownWidth = 180;
            this.cmbDocumentType.Font = new Font("Microsoft Sans Serif", 11F);
            this.cmbDocumentType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            this.cmbDocumentType.FormattingEnabled = true;
            this.cmbDocumentType.IntegralHeight = false;
            this.cmbDocumentType.ItemHeight = 43;
            this.cmbDocumentType.Items.AddRange(new object[] { "الكل", "إيجار", "فاتورة", "سندات" });
            this.cmbDocumentType.Location = new Point(0, 176);
            this.cmbDocumentType.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbDocumentType.Name = "cmbDocumentType";
            this.cmbDocumentType.RightToLeft = RightToLeft.Yes;
            this.cmbDocumentType.Size = new Size(587, 49);
            this.cmbDocumentType.StartIndex = 0;
            this.cmbDocumentType.TabIndex = 4;
            //
            // lblYear
            //
            this.lblYear.AutoSize = true;
            this.lblYear.Depth = 0;
            this.lblYear.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblYear.ForeColor = Color.FromArgb(180, 0, 0, 0);
            this.lblYear.Location = new Point(1115, 235);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new Size(40, 19);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "سنة:";
            //
            // cmbYear
            //
            this.cmbYear.AutoResize = false;
            this.cmbYear.BackColor = Color.White;
            this.cmbYear.Depth = 0;
            this.cmbYear.DrawMode = DrawMode.OwnerDrawVariable;
            this.cmbYear.DropDownHeight = 174;
            this.cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbYear.DropDownWidth = 121;
            this.cmbYear.Font = new Font("Microsoft Sans Serif", 11F);
            this.cmbYear.ForeColor = Color.FromArgb(222, 0, 0, 0);
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.IntegralHeight = false;
            this.cmbYear.ItemHeight = 43;
            this.cmbYear.Location = new Point(613, 256);
            this.cmbYear.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.RightToLeft = RightToLeft.Yes;
            this.cmbYear.Size = new Size(280, 49);
            this.cmbYear.StartIndex = 0;
            this.cmbYear.TabIndex = 5;
            //
            // lblFromMonth
            //
            this.lblFromMonth.AutoSize = true;
            this.lblFromMonth.Depth = 0;
            this.lblFromMonth.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblFromMonth.ForeColor = Color.FromArgb(180, 0, 0, 0);
            this.lblFromMonth.Location = new Point(1115, 315);
            this.lblFromMonth.Name = "lblFromMonth";
            this.lblFromMonth.Size = new Size(63, 19);
            this.lblFromMonth.TabIndex = 0;
            this.lblFromMonth.Text = "من شهر:";
            //
            // cmbFromMonth
            //
            this.cmbFromMonth.AutoResize = false;
            this.cmbFromMonth.BackColor = Color.White;
            this.cmbFromMonth.Depth = 0;
            this.cmbFromMonth.DrawMode = DrawMode.OwnerDrawVariable;
            this.cmbFromMonth.DropDownHeight = 174;
            this.cmbFromMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbFromMonth.DropDownWidth = 121;
            this.cmbFromMonth.Font = new Font("Microsoft Sans Serif", 11F);
            this.cmbFromMonth.ForeColor = Color.FromArgb(222, 0, 0, 0);
            this.cmbFromMonth.FormattingEnabled = true;
            this.cmbFromMonth.IntegralHeight = false;
            this.cmbFromMonth.ItemHeight = 43;
            this.cmbFromMonth.Items.AddRange(new object[] {
                "1 - يناير", "2 - فبراير", "3 - مارس", "4 - أبريل", "5 - مايو", "6 - يونيو",
                "7 - يوليو", "8 - أغسطس", "9 - سبتمبر", "10 - أكتوبر", "11 - نوفمبر", "12 - ديسمبر"
            });
            this.cmbFromMonth.Location = new Point(613, 336);
            this.cmbFromMonth.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbFromMonth.Name = "cmbFromMonth";
            this.cmbFromMonth.RightToLeft = RightToLeft.Yes;
            this.cmbFromMonth.Size = new Size(280, 49);
            this.cmbFromMonth.StartIndex = 0;
            this.cmbFromMonth.TabIndex = 6;
            //
            // lblToMonth
            //
            this.lblToMonth.AutoSize = true;
            this.lblToMonth.Depth = 0;
            this.lblToMonth.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblToMonth.ForeColor = Color.FromArgb(180, 0, 0, 0);
            this.lblToMonth.Location = new Point(515, 315);
            this.lblToMonth.Name = "lblToMonth";
            this.lblToMonth.Size = new Size(63, 19);
            this.lblToMonth.TabIndex = 0;
            this.lblToMonth.Text = "إلى شهر:";
            //
            // cmbToMonth
            //
            this.cmbToMonth.AutoResize = false;
            this.cmbToMonth.BackColor = Color.White;
            this.cmbToMonth.Depth = 0;
            this.cmbToMonth.DrawMode = DrawMode.OwnerDrawVariable;
            this.cmbToMonth.DropDownHeight = 174;
            this.cmbToMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbToMonth.DropDownWidth = 121;
            this.cmbToMonth.Font = new Font("Microsoft Sans Serif", 11F);
            this.cmbToMonth.ForeColor = Color.FromArgb(222, 0, 0, 0);
            this.cmbToMonth.FormattingEnabled = true;
            this.cmbToMonth.IntegralHeight = false;
            this.cmbToMonth.ItemHeight = 43;
            this.cmbToMonth.Items.AddRange(new object[] {
                "1 - يناير", "2 - فبراير", "3 - مارس", "4 - أبريل", "5 - مايو", "6 - يونيو",
                "7 - يوليو", "8 - أغسطس", "9 - سبتمبر", "10 - أكتوبر", "11 - نوفمبر", "12 - ديسمبر"
            });
            this.cmbToMonth.Location = new Point(0, 336);
            this.cmbToMonth.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbToMonth.Name = "cmbToMonth";
            this.cmbToMonth.RightToLeft = RightToLeft.Yes;
            this.cmbToMonth.Size = new Size(280, 49);
            this.cmbToMonth.StartIndex = 0;
            this.cmbToMonth.TabIndex = 7;
            //
            // btnPreview
            //
            this.btnPreview.AutoSize = false;
            this.btnPreview.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPreview.Depth = 0;
            this.btnPreview.HighEmphasis = true;
            this.btnPreview.Icon = null;
            this.btnPreview.Location = new Point(213, 400);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new Size(200, 50);
            this.btnPreview.TabIndex = 8;
            this.btnPreview.Text = "🔍 عرض / معاينة";
            this.btnPreview.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPreview.UseAccentColor = false;
            this.btnPreview.UseVisualStyleBackColor = true;
            //
            // btnPrint
            //
            this.btnPrint.AutoSize = false;
            this.btnPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrint.Depth = 0;
            this.btnPrint.HighEmphasis = false;
            this.btnPrint.Icon = null;
            this.btnPrint.Location = new Point(0, 400);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new Size(200, 50);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "🖨️ طباعة";
            this.btnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrint.UseAccentColor = false;
            this.btnPrint.UseVisualStyleBackColor = true;
            //
            // UC_ReportAccountStatement
            //
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_ReportAccountStatement";
            this.RightToLeft = RightToLeft.Yes;
            this.Size = new Size(1267, 633);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private Panel pnlForm;
        private DataGridView dgvReport;
        private Panel pnlFilters;
        private MaterialSkin.Controls.MaterialLabel lblReportType;
        private MaterialSkin.Controls.MaterialComboBox cmbReportType;
        private MaterialSkin.Controls.MaterialLabel lblTenantNo;
        private MaterialSkin.Controls.MaterialTextBox2 txtTenantNo;
        private MaterialSkin.Controls.MaterialLabel lblPropertyNo;
        private MaterialSkin.Controls.MaterialTextBox2 txtPropertyNo;
        private MaterialSkin.Controls.MaterialLabel lblApartmentNo;
        private MaterialSkin.Controls.MaterialTextBox2 txtApartmentNo;
        private MaterialSkin.Controls.MaterialLabel lblDocumentType;
        private MaterialSkin.Controls.MaterialComboBox cmbDocumentType;
        private MaterialSkin.Controls.MaterialLabel lblYear;
        private MaterialSkin.Controls.MaterialComboBox cmbYear;
        private MaterialSkin.Controls.MaterialLabel lblFromMonth;
        private MaterialSkin.Controls.MaterialComboBox cmbFromMonth;
        private MaterialSkin.Controls.MaterialLabel lblToMonth;
        private MaterialSkin.Controls.MaterialComboBox cmbToMonth;
        private MaterialSkin.Controls.MaterialButton btnPreview;
        private MaterialSkin.Controls.MaterialButton btnPrint;
    }
}
