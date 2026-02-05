using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Dari
{
    partial class UC_TenantMonthlyStatement
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
            this.pnlFilters = new Panel();
            this.btnPrint = new MaterialSkin.Controls.MaterialButton();
            this.btnPreview = new MaterialSkin.Controls.MaterialButton();
            this.lblArrears = new MaterialSkin.Controls.MaterialLabel();
            this.cmbArrears = new MaterialSkin.Controls.MaterialComboBox();
            this.lblYear = new MaterialSkin.Controls.MaterialLabel();
            this.cmbYear = new MaterialSkin.Controls.MaterialComboBox();
            this.lblToMonth = new MaterialSkin.Controls.MaterialLabel();
            this.cmbToMonth = new MaterialSkin.Controls.MaterialComboBox();
            this.lblFromMonth = new MaterialSkin.Controls.MaterialLabel();
            this.cmbFromMonth = new MaterialSkin.Controls.MaterialComboBox();
            this.lblTenantNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenantNo = new MaterialSkin.Controls.MaterialTextBox2();
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
            this.lblTitle.Location = new Point(1050, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(200, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "كشف المستأجر الشهري";
            //
            // pnlForm
            //
            this.pnlForm.BackColor = Color.White;
            this.pnlForm.Controls.Add(this.pnlFilters);
            this.pnlForm.Dock = DockStyle.Fill;
            this.pnlForm.Location = new Point(0, 74);
            this.pnlForm.Padding = new Padding(27, 25, 27, 25);
            this.pnlForm.RightToLeft = RightToLeft.Yes;
            this.pnlForm.Size = new Size(1267, 559);
            this.pnlForm.TabIndex = 1;
            //
            // pnlFilters
            //
            this.pnlFilters.Controls.Add(this.lblTenantNo);
            this.pnlFilters.Controls.Add(this.txtTenantNo);
            this.pnlFilters.Controls.Add(this.lblFromMonth);
            this.pnlFilters.Controls.Add(this.cmbFromMonth);
            this.pnlFilters.Controls.Add(this.lblToMonth);
            this.pnlFilters.Controls.Add(this.cmbToMonth);
            this.pnlFilters.Controls.Add(this.lblYear);
            this.pnlFilters.Controls.Add(this.cmbYear);
            this.pnlFilters.Controls.Add(this.lblArrears);
            this.pnlFilters.Controls.Add(this.cmbArrears);
            this.pnlFilters.Controls.Add(this.btnPreview);
            this.pnlFilters.Controls.Add(this.btnPrint);
            this.pnlFilters.Dock = DockStyle.Top;
            this.pnlFilters.Location = new Point(27, 25);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.RightToLeft = RightToLeft.Yes;
            this.pnlFilters.Size = new Size(1213, 320);
            this.pnlFilters.TabIndex = 0;
            //
            // lblTenantNo
            //
            this.lblTenantNo.AutoSize = true;
            this.lblTenantNo.Depth = 0;
            this.lblTenantNo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblTenantNo.ForeColor = Color.FromArgb(180, 0, 0, 0);
            this.lblTenantNo.Location = new Point(1115, 0);
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
            this.txtTenantNo.Location = new Point(613, 21);
            this.txtTenantNo.MaxLength = 50;
            this.txtTenantNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenantNo.Name = "txtTenantNo";
            this.txtTenantNo.PasswordChar = '\0';
            this.txtTenantNo.PrefixSuffixText = null;
            this.txtTenantNo.ReadOnly = false;
            this.txtTenantNo.RightToLeft = RightToLeft.Yes;
            this.txtTenantNo.Size = new Size(487, 36);
            this.txtTenantNo.TabIndex = 1;
            this.txtTenantNo.TextAlign = HorizontalAlignment.Right;
            this.txtTenantNo.TrailingIcon = null;
            this.txtTenantNo.UseSystemPasswordChar = false;
            this.txtTenantNo.UseTallSize = false;
            //
            // lblFromMonth
            //
            this.lblFromMonth.AutoSize = true;
            this.lblFromMonth.Depth = 0;
            this.lblFromMonth.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblFromMonth.ForeColor = Color.FromArgb(180, 0, 0, 0);
            this.lblFromMonth.Location = new Point(1115, 70);
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
            this.cmbFromMonth.DropDownWidth = 200;
            this.cmbFromMonth.Font = new Font("Microsoft Sans Serif", 11F);
            this.cmbFromMonth.ForeColor = Color.FromArgb(222, 0, 0, 0);
            this.cmbFromMonth.FormattingEnabled = true;
            this.cmbFromMonth.IntegralHeight = false;
            this.cmbFromMonth.ItemHeight = 43;
            this.cmbFromMonth.Items.AddRange(new object[] {
                "1 - يناير", "2 - فبراير", "3 - مارس", "4 - أبريل", "5 - مايو", "6 - يونيو",
                "7 - يوليو", "8 - أغسطس", "9 - سبتمبر", "10 - أكتوبر", "11 - نوفمبر", "12 - ديسمبر"
            });
            this.cmbFromMonth.Location = new Point(613, 91);
            this.cmbFromMonth.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbFromMonth.Name = "cmbFromMonth";
            this.cmbFromMonth.RightToLeft = RightToLeft.Yes;
            this.cmbFromMonth.Size = new Size(280, 49);
            this.cmbFromMonth.StartIndex = 0;
            this.cmbFromMonth.TabIndex = 2;
            //
            // lblToMonth
            //
            this.lblToMonth.AutoSize = true;
            this.lblToMonth.Depth = 0;
            this.lblToMonth.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblToMonth.ForeColor = Color.FromArgb(180, 0, 0, 0);
            this.lblToMonth.Location = new Point(515, 70);
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
            this.cmbToMonth.DropDownWidth = 200;
            this.cmbToMonth.Font = new Font("Microsoft Sans Serif", 11F);
            this.cmbToMonth.ForeColor = Color.FromArgb(222, 0, 0, 0);
            this.cmbToMonth.FormattingEnabled = true;
            this.cmbToMonth.IntegralHeight = false;
            this.cmbToMonth.ItemHeight = 43;
            this.cmbToMonth.Items.AddRange(new object[] {
                "1 - يناير", "2 - فبراير", "3 - مارس", "4 - أبريل", "5 - مايو", "6 - يونيو",
                "7 - يوليو", "8 - أغسطس", "9 - سبتمبر", "10 - أكتوبر", "11 - نوفمبر", "12 - ديسمبر"
            });
            this.cmbToMonth.Location = new Point(0, 91);
            this.cmbToMonth.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbToMonth.Name = "cmbToMonth";
            this.cmbToMonth.RightToLeft = RightToLeft.Yes;
            this.cmbToMonth.Size = new Size(280, 49);
            this.cmbToMonth.StartIndex = 0;
            this.cmbToMonth.TabIndex = 3;
            //
            // lblYear
            //
            this.lblYear.AutoSize = true;
            this.lblYear.Depth = 0;
            this.lblYear.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblYear.ForeColor = Color.FromArgb(180, 0, 0, 0);
            this.lblYear.Location = new Point(1115, 155);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new Size(40, 19);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "السنة:";
            //
            // cmbYear
            //
            this.cmbYear.AutoResize = false;
            this.cmbYear.BackColor = Color.White;
            this.cmbYear.Depth = 0;
            this.cmbYear.DrawMode = DrawMode.OwnerDrawVariable;
            this.cmbYear.DropDownHeight = 174;
            this.cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbYear.DropDownWidth = 120;
            this.cmbYear.Font = new Font("Microsoft Sans Serif", 11F);
            this.cmbYear.ForeColor = Color.FromArgb(222, 0, 0, 0);
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.IntegralHeight = false;
            this.cmbYear.ItemHeight = 43;
            this.cmbYear.Location = new Point(613, 176);
            this.cmbYear.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.RightToLeft = RightToLeft.Yes;
            this.cmbYear.Size = new Size(280, 49);
            this.cmbYear.StartIndex = 0;
            this.cmbYear.TabIndex = 4;
            //
            // lblArrears
            //
            this.lblArrears.AutoSize = true;
            this.lblArrears.Depth = 0;
            this.lblArrears.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblArrears.ForeColor = Color.FromArgb(180, 0, 0, 0);
            this.lblArrears.Location = new Point(515, 155);
            this.lblArrears.Name = "lblArrears";
            this.lblArrears.Size = new Size(65, 19);
            this.lblArrears.TabIndex = 0;
            this.lblArrears.Text = "المتأخرات:";
            //
            // cmbArrears
            //
            this.cmbArrears.AutoResize = false;
            this.cmbArrears.BackColor = Color.White;
            this.cmbArrears.Depth = 0;
            this.cmbArrears.DrawMode = DrawMode.OwnerDrawVariable;
            this.cmbArrears.DropDownHeight = 174;
            this.cmbArrears.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbArrears.DropDownWidth = 200;
            this.cmbArrears.Font = new Font("Microsoft Sans Serif", 11F);
            this.cmbArrears.ForeColor = Color.FromArgb(222, 0, 0, 0);
            this.cmbArrears.FormattingEnabled = true;
            this.cmbArrears.IntegralHeight = false;
            this.cmbArrears.ItemHeight = 43;
            this.cmbArrears.Items.AddRange(new object[] { "الكل", "المتأخرات فقط" });
            this.cmbArrears.Location = new Point(0, 176);
            this.cmbArrears.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbArrears.Name = "cmbArrears";
            this.cmbArrears.RightToLeft = RightToLeft.Yes;
            this.cmbArrears.Size = new Size(280, 49);
            this.cmbArrears.StartIndex = 0;
            this.cmbArrears.TabIndex = 5;
            //
            // btnPreview
            //
            this.btnPreview.AutoSize = false;
            this.btnPreview.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPreview.Depth = 0;
            this.btnPreview.HighEmphasis = true;
            this.btnPreview.Icon = null;
            this.btnPreview.Location = new Point(213, 250);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new Size(200, 50);
            this.btnPreview.TabIndex = 7;
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
            this.btnPrint.Location = new Point(0, 250);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new Size(200, 50);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrint.UseAccentColor = false;
            this.btnPrint.UseVisualStyleBackColor = true;
            //
            // UC_TenantMonthlyStatement
            //
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_TenantMonthlyStatement";
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
        private Panel pnlFilters;
        private MaterialSkin.Controls.MaterialLabel lblTenantNo;
        private MaterialSkin.Controls.MaterialTextBox2 txtTenantNo;
        private MaterialSkin.Controls.MaterialLabel lblFromMonth;
        private MaterialSkin.Controls.MaterialComboBox cmbFromMonth;
        private MaterialSkin.Controls.MaterialLabel lblToMonth;
        private MaterialSkin.Controls.MaterialComboBox cmbToMonth;
        private MaterialSkin.Controls.MaterialLabel lblYear;
        private MaterialSkin.Controls.MaterialComboBox cmbYear;
        private MaterialSkin.Controls.MaterialLabel lblArrears;
        private MaterialSkin.Controls.MaterialComboBox cmbArrears;
        private MaterialSkin.Controls.MaterialButton btnPreview;
        private MaterialSkin.Controls.MaterialButton btnPrint;
    }
}
