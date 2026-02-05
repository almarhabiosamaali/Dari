using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Dari
{
    partial class UC_ReportAvailableBuildingsApartments
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
            this.lblPropertyNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtPropertyNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.cmbStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.btnPreview = new MaterialSkin.Controls.MaterialButton();
            this.btnPrint = new MaterialSkin.Controls.MaterialButton();
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
            this.lblTitle.Location = new Point(950, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(300, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "المباني والشقق المتاحة";
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
            this.pnlFilters.Controls.Add(this.lblPropertyNo);
            this.pnlFilters.Controls.Add(this.txtPropertyNo);
            this.pnlFilters.Controls.Add(this.lblStatus);
            this.pnlFilters.Controls.Add(this.cmbStatus);
            this.pnlFilters.Controls.Add(this.btnPreview);
            this.pnlFilters.Controls.Add(this.btnPrint);
            this.pnlFilters.Dock = DockStyle.Top;
            this.pnlFilters.Location = new Point(27, 25);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.RightToLeft = RightToLeft.Yes;
            this.pnlFilters.Size = new Size(1213, 220);
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
            // lblPropertyNo
            //
            this.lblPropertyNo.AutoSize = true;
            this.lblPropertyNo.Depth = 0;
            this.lblPropertyNo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblPropertyNo.ForeColor = Color.FromArgb(180, 0, 0, 0);
            this.lblPropertyNo.Location = new Point(1115, 0);
            this.lblPropertyNo.Name = "lblPropertyNo";
            this.lblPropertyNo.Size = new Size(95, 19);
            this.lblPropertyNo.TabIndex = 0;
            this.lblPropertyNo.Text = "رقم المبنى:";
            //
            // txtPropertyNo
            //
            this.txtPropertyNo.AnimateReadOnly = false;
            this.txtPropertyNo.CharacterCasing = CharacterCasing.Normal;
            this.txtPropertyNo.Depth = 0;
            this.txtPropertyNo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.txtPropertyNo.HideSelection = false;
            this.txtPropertyNo.LeadingIcon = null;
            this.txtPropertyNo.Location = new Point(613, 21);
            this.txtPropertyNo.MaxLength = 50;
            this.txtPropertyNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPropertyNo.Name = "txtPropertyNo";
            this.txtPropertyNo.PasswordChar = '\0';
            this.txtPropertyNo.PrefixSuffixText = null;
            this.txtPropertyNo.ReadOnly = false;
            this.txtPropertyNo.RightToLeft = RightToLeft.Yes;
            this.txtPropertyNo.Size = new Size(487, 36);
            this.txtPropertyNo.TabIndex = 1;
            this.txtPropertyNo.TextAlign = HorizontalAlignment.Right;
            this.txtPropertyNo.TrailingIcon = null;
            this.txtPropertyNo.UseSystemPasswordChar = false;
            this.txtPropertyNo.UseTallSize = false;
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = true;
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblStatus.ForeColor = Color.FromArgb(180, 0, 0, 0);
            this.lblStatus.Location = new Point(1115, 70);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(45, 19);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "الحالة:";
            //
            // cmbStatus
            //
            this.cmbStatus.AutoResize = false;
            this.cmbStatus.BackColor = Color.White;
            this.cmbStatus.Depth = 0;
            this.cmbStatus.DrawMode = DrawMode.OwnerDrawVariable;
            this.cmbStatus.DropDownHeight = 174;
            this.cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbStatus.DropDownWidth = 200;
            this.cmbStatus.Font = new Font("Microsoft Sans Serif", 11F);
            this.cmbStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.IntegralHeight = false;
            this.cmbStatus.ItemHeight = 43;
            this.cmbStatus.Items.AddRange(new object[] { "الكل", "المتاحة", "المؤجرة" });
            this.cmbStatus.Location = new Point(613, 91);
            this.cmbStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.RightToLeft = RightToLeft.Yes;
            this.cmbStatus.Size = new Size(280, 49);
            this.cmbStatus.StartIndex = 0;
            this.cmbStatus.TabIndex = 2;
            //
            // btnPreview
            //
            this.btnPreview.AutoSize = false;
            this.btnPreview.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPreview.Depth = 0;
            this.btnPreview.HighEmphasis = true;
            this.btnPreview.Icon = null;
            this.btnPreview.Location = new Point(213, 160);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new Size(200, 50);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "عرض / معاينة";
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
            this.btnPrint.Location = new Point(0, 160);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new Size(200, 50);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrint.UseAccentColor = false;
            this.btnPrint.UseVisualStyleBackColor = true;
            //
            // UC_ReportAvailableBuildingsApartments
            //
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_ReportAvailableBuildingsApartments";
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
        private MaterialSkin.Controls.MaterialLabel lblPropertyNo;
        private MaterialSkin.Controls.MaterialTextBox2 txtPropertyNo;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private MaterialSkin.Controls.MaterialComboBox cmbStatus;
        private MaterialSkin.Controls.MaterialButton btnPreview;
        private MaterialSkin.Controls.MaterialButton btnPrint;
    }
}
