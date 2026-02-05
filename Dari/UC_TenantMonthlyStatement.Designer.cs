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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblTenantNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenantNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblFromMonth = new MaterialSkin.Controls.MaterialLabel();
            this.cmbFromMonth = new MaterialSkin.Controls.MaterialComboBox();
            this.lblToMonth = new MaterialSkin.Controls.MaterialLabel();
            this.cmbToMonth = new MaterialSkin.Controls.MaterialComboBox();
            this.lblYear = new MaterialSkin.Controls.MaterialLabel();
            this.cmbYear = new MaterialSkin.Controls.MaterialComboBox();
            this.lblArrears = new MaterialSkin.Controls.MaterialLabel();
            this.cmbArrears = new MaterialSkin.Controls.MaterialComboBox();
            this.btnPreview = new MaterialSkin.Controls.MaterialButton();
            this.btnPrint = new MaterialSkin.Controls.MaterialButton();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlHeader.Size = new System.Drawing.Size(1267, 74);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = false;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.HighEmphasis = false;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(10, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(120, 45);
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
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(1050, 22);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "كشف المستأجر الشهري";
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.pnlFilters);
            this.pnlForm.Controls.Add(this.dgvReport);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 74);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlForm.Size = new System.Drawing.Size(1267, 559);
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
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Location = new System.Drawing.Point(27, 25);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlFilters.Size = new System.Drawing.Size(1213, 320);
            this.pnlFilters.TabIndex = 0;
            // 
            // lblTenantNo
            // 
            this.lblTenantNo.AutoSize = true;
            this.lblTenantNo.Depth = 0;
            this.lblTenantNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTenantNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTenantNo.Location = new System.Drawing.Point(1115, 0);
            this.lblTenantNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTenantNo.Name = "lblTenantNo";
            this.lblTenantNo.Size = new System.Drawing.Size(84, 17);
            this.lblTenantNo.TabIndex = 0;
            this.lblTenantNo.Text = "رقم المستأجر:";
            // 
            // txtTenantNo
            // 
            this.txtTenantNo.AnimateReadOnly = false;
            this.txtTenantNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTenantNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTenantNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTenantNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenantNo.Depth = 0;
            this.txtTenantNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenantNo.HideSelection = false;
            this.txtTenantNo.LeadingIcon = null;
            this.txtTenantNo.Location = new System.Drawing.Point(613, 21);
            this.txtTenantNo.MaxLength = 50;
            this.txtTenantNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenantNo.Name = "txtTenantNo";
            this.txtTenantNo.PasswordChar = '\0';
            this.txtTenantNo.PrefixSuffixText = null;
            this.txtTenantNo.ReadOnly = false;
            this.txtTenantNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTenantNo.SelectedText = "";
            this.txtTenantNo.SelectionLength = 0;
            this.txtTenantNo.SelectionStart = 0;
            this.txtTenantNo.ShortcutsEnabled = true;
            this.txtTenantNo.Size = new System.Drawing.Size(487, 36);
            this.txtTenantNo.TabIndex = 1;
            this.txtTenantNo.TabStop = false;
            this.txtTenantNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTenantNo.TrailingIcon = null;
            this.txtTenantNo.UseSystemPasswordChar = false;
            this.txtTenantNo.UseTallSize = false;
            // 
            // lblFromMonth
            // 
            this.lblFromMonth.AutoSize = true;
            this.lblFromMonth.Depth = 0;
            this.lblFromMonth.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFromMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFromMonth.Location = new System.Drawing.Point(1115, 70);
            this.lblFromMonth.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFromMonth.Name = "lblFromMonth";
            this.lblFromMonth.Size = new System.Drawing.Size(53, 17);
            this.lblFromMonth.TabIndex = 0;
            this.lblFromMonth.Text = "من شهر:";
            // 
            // cmbFromMonth
            // 
            this.cmbFromMonth.AutoResize = false;
            this.cmbFromMonth.BackColor = System.Drawing.Color.White;
            this.cmbFromMonth.Depth = 0;
            this.cmbFromMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbFromMonth.DropDownHeight = 174;
            this.cmbFromMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFromMonth.DropDownWidth = 200;
            this.cmbFromMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbFromMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbFromMonth.FormattingEnabled = true;
            this.cmbFromMonth.IntegralHeight = false;
            this.cmbFromMonth.ItemHeight = 43;
            this.cmbFromMonth.Items.AddRange(new object[] {
            "1 - يناير",
            "2 - فبراير",
            "3 - مارس",
            "4 - أبريل",
            "5 - مايو",
            "6 - يونيو",
            "7 - يوليو",
            "8 - أغسطس",
            "9 - سبتمبر",
            "10 - أكتوبر",
            "11 - نوفمبر",
            "12 - ديسمبر"});
            this.cmbFromMonth.Location = new System.Drawing.Point(613, 91);
            this.cmbFromMonth.MaxDropDownItems = 4;
            this.cmbFromMonth.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbFromMonth.Name = "cmbFromMonth";
            this.cmbFromMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbFromMonth.Size = new System.Drawing.Size(280, 49);
            this.cmbFromMonth.StartIndex = 0;
            this.cmbFromMonth.TabIndex = 2;
            // 
            // lblToMonth
            // 
            this.lblToMonth.AutoSize = true;
            this.lblToMonth.Depth = 0;
            this.lblToMonth.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblToMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToMonth.Location = new System.Drawing.Point(515, 70);
            this.lblToMonth.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblToMonth.Name = "lblToMonth";
            this.lblToMonth.Size = new System.Drawing.Size(54, 17);
            this.lblToMonth.TabIndex = 0;
            this.lblToMonth.Text = "إلى شهر:";
            // 
            // cmbToMonth
            // 
            this.cmbToMonth.AutoResize = false;
            this.cmbToMonth.BackColor = System.Drawing.Color.White;
            this.cmbToMonth.Depth = 0;
            this.cmbToMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbToMonth.DropDownHeight = 174;
            this.cmbToMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToMonth.DropDownWidth = 200;
            this.cmbToMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbToMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbToMonth.FormattingEnabled = true;
            this.cmbToMonth.IntegralHeight = false;
            this.cmbToMonth.ItemHeight = 43;
            this.cmbToMonth.Items.AddRange(new object[] {
            "1 - يناير",
            "2 - فبراير",
            "3 - مارس",
            "4 - أبريل",
            "5 - مايو",
            "6 - يونيو",
            "7 - يوليو",
            "8 - أغسطس",
            "9 - سبتمبر",
            "10 - أكتوبر",
            "11 - نوفمبر",
            "12 - ديسمبر"});
            this.cmbToMonth.Location = new System.Drawing.Point(0, 91);
            this.cmbToMonth.MaxDropDownItems = 4;
            this.cmbToMonth.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbToMonth.Name = "cmbToMonth";
            this.cmbToMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbToMonth.Size = new System.Drawing.Size(280, 49);
            this.cmbToMonth.StartIndex = 0;
            this.cmbToMonth.TabIndex = 3;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Depth = 0;
            this.lblYear.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblYear.Location = new System.Drawing.Point(1115, 155);
            this.lblYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(37, 17);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "السنة:";
            // 
            // cmbYear
            // 
            this.cmbYear.AutoResize = false;
            this.cmbYear.BackColor = System.Drawing.Color.White;
            this.cmbYear.Depth = 0;
            this.cmbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbYear.DropDownHeight = 174;
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.DropDownWidth = 120;
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.IntegralHeight = false;
            this.cmbYear.ItemHeight = 43;
            this.cmbYear.Location = new System.Drawing.Point(613, 176);
            this.cmbYear.MaxDropDownItems = 4;
            this.cmbYear.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbYear.Size = new System.Drawing.Size(280, 49);
            this.cmbYear.StartIndex = 0;
            this.cmbYear.TabIndex = 4;
            // 
            // lblArrears
            // 
            this.lblArrears.AutoSize = true;
            this.lblArrears.Depth = 0;
            this.lblArrears.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblArrears.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblArrears.Location = new System.Drawing.Point(515, 155);
            this.lblArrears.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblArrears.Name = "lblArrears";
            this.lblArrears.Size = new System.Drawing.Size(62, 17);
            this.lblArrears.TabIndex = 0;
            this.lblArrears.Text = "المتأخرات:";
            // 
            // cmbArrears
            // 
            this.cmbArrears.AutoResize = false;
            this.cmbArrears.BackColor = System.Drawing.Color.White;
            this.cmbArrears.Depth = 0;
            this.cmbArrears.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbArrears.DropDownHeight = 174;
            this.cmbArrears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArrears.DropDownWidth = 200;
            this.cmbArrears.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbArrears.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbArrears.FormattingEnabled = true;
            this.cmbArrears.IntegralHeight = false;
            this.cmbArrears.ItemHeight = 43;
            this.cmbArrears.Items.AddRange(new object[] {
            "الكل",
            "المتأخرات فقط"});
            this.cmbArrears.Location = new System.Drawing.Point(0, 176);
            this.cmbArrears.MaxDropDownItems = 4;
            this.cmbArrears.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbArrears.Name = "cmbArrears";
            this.cmbArrears.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbArrears.Size = new System.Drawing.Size(280, 49);
            this.cmbArrears.StartIndex = 0;
            this.cmbArrears.TabIndex = 5;
            // 
            // btnPreview
            // 
            this.btnPreview.AutoSize = false;
            this.btnPreview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPreview.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPreview.Depth = 0;
            this.btnPreview.HighEmphasis = true;
            this.btnPreview.Icon = null;
            this.btnPreview.Location = new System.Drawing.Point(213, 250);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPreview.Size = new System.Drawing.Size(200, 50);
            this.btnPreview.TabIndex = 7;
            this.btnPreview.Text = "عرض / معاينة";
            this.btnPreview.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPreview.UseAccentColor = false;
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSize = false;
            this.btnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrint.Depth = 0;
            this.btnPrint.HighEmphasis = false;
            this.btnPrint.Icon = null;
            this.btnPrint.Location = new System.Drawing.Point(0, 250);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrint.Size = new System.Drawing.Size(200, 50);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrint.UseAccentColor = false;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(27, 25);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(0);
            this.dgvReport.MinimumSize = new System.Drawing.Size(0, 180);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.Size = new System.Drawing.Size(1213, 509);
            this.dgvReport.TabIndex = 1;
            // 
            // UC_TenantMonthlyStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_TenantMonthlyStatement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1267, 633);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlHeader;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private Panel pnlForm;
        private DataGridView dgvReport;
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
