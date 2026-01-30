using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Dari
{
    partial class UC_RentCalculation
    {
        private System.ComponentModel.IContainer components = null;

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
            this.btnCalculate = new MaterialSkin.Controls.MaterialButton();
            this.lblMonth = new MaterialSkin.Controls.MaterialLabel();
            this.cmbMonth = new MaterialSkin.Controls.MaterialComboBox();
            this.lblYear = new MaterialSkin.Controls.MaterialLabel();
            this.cmbYear = new MaterialSkin.Controls.MaterialComboBox();
            this.lblPropertyNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtPropertyNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dgvRentSummary = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentSummary)).BeginInit();
            this.SuspendLayout();
            //
            // pnlHeader
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
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
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.HighEmphasis = false;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(10, 12);
            this.btnClose.Name = "btnClose";
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
            this.lblTitle.Location = new System.Drawing.Point(1115, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "احتساب الإيجار";
            //
            // pnlForm
            //
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.pnlFilters);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForm.Location = new System.Drawing.Point(0, 74);
            this.pnlForm.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlForm.Size = new System.Drawing.Size(1267, 180);
            this.pnlForm.TabIndex = 1;
            //
            // pnlFilters
            //
            this.pnlFilters.Controls.Add(this.lblPropertyNo);
            this.pnlFilters.Controls.Add(this.txtPropertyNo);
            this.pnlFilters.Controls.Add(this.lblYear);
            this.pnlFilters.Controls.Add(this.cmbYear);
            this.pnlFilters.Controls.Add(this.lblMonth);
            this.pnlFilters.Controls.Add(this.cmbMonth);
            this.pnlFilters.Controls.Add(this.btnCalculate);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilters.Location = new System.Drawing.Point(27, 25);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlFilters.Size = new System.Drawing.Size(1213, 130);
            this.pnlFilters.TabIndex = 0;
            //
            // lblPropertyNo
            //
            this.lblPropertyNo.AutoSize = true;
            this.lblPropertyNo.Depth = 0;
            this.lblPropertyNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPropertyNo.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblPropertyNo.Location = new System.Drawing.Point(1115, 0);
            this.lblPropertyNo.Name = "lblPropertyNo";
            this.lblPropertyNo.Size = new System.Drawing.Size(75, 19);
            this.lblPropertyNo.TabIndex = 1;
            this.lblPropertyNo.Text = "رقم العقار:";
            //
            // txtPropertyNo
            //
            this.txtPropertyNo.AnimateReadOnly = false;
            this.txtPropertyNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPropertyNo.Depth = 0;
            this.txtPropertyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPropertyNo.HideSelection = false;
            this.txtPropertyNo.LeadingIcon = null;
            this.txtPropertyNo.Location = new System.Drawing.Point(613, 21);
            this.txtPropertyNo.MaxLength = 50;
            this.txtPropertyNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPropertyNo.Name = "txtPropertyNo";
            this.txtPropertyNo.PasswordChar = '\0';
            this.txtPropertyNo.PrefixSuffixText = null;
            this.txtPropertyNo.ReadOnly = false;
            this.txtPropertyNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPropertyNo.Size = new System.Drawing.Size(587, 36);
            this.txtPropertyNo.TabIndex = 0;
            this.txtPropertyNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPropertyNo.TrailingIcon = null;
            this.txtPropertyNo.UseSystemPasswordChar = false;
            this.txtPropertyNo.UseTallSize = false;
            //
            // lblYear
            //
            this.lblYear.AutoSize = true;
            this.lblYear.Depth = 0;
            this.lblYear.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblYear.Location = new System.Drawing.Point(515, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(41, 19);
            this.lblYear.TabIndex = 3;
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
            this.cmbYear.DropDownWidth = 121;
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbYear.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.IntegralHeight = false;
            this.cmbYear.ItemHeight = 43;
            this.cmbYear.Location = new System.Drawing.Point(0, 21);
            this.cmbYear.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbYear.Size = new System.Drawing.Size(587, 49);
            this.cmbYear.StartIndex = 0;
            this.cmbYear.TabIndex = 1;
            //
            // lblMonth
            //
            this.lblMonth.AutoSize = true;
            this.lblMonth.Depth = 0;
            this.lblMonth.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMonth.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblMonth.Location = new System.Drawing.Point(1115, 80);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(43, 19);
            this.lblMonth.TabIndex = 5;
            this.lblMonth.Text = "الشهر:";
            //
            // cmbMonth
            //
            this.cmbMonth.AutoResize = false;
            this.cmbMonth.BackColor = System.Drawing.Color.White;
            this.cmbMonth.Depth = 0;
            this.cmbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbMonth.DropDownHeight = 174;
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.DropDownWidth = 121;
            this.cmbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbMonth.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.IntegralHeight = false;
            this.cmbMonth.ItemHeight = 43;
            this.cmbMonth.Items.AddRange(new object[] {
                "1 - يناير", "2 - فبراير", "3 - مارس", "4 - أبريل", "5 - مايو", "6 - يونيو",
                "7 - يوليو", "8 - أغسطس", "9 - سبتمبر", "10 - أكتوبر", "11 - نوفمبر", "12 - ديسمبر"
            });
            this.cmbMonth.Location = new System.Drawing.Point(613, 101);
            this.cmbMonth.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbMonth.Size = new System.Drawing.Size(587, 49);
            this.cmbMonth.StartIndex = 0;
            this.cmbMonth.TabIndex = 2;
            //
            // btnCalculate
            //
            this.btnCalculate.AutoSize = false;
            this.btnCalculate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCalculate.Depth = 0;
            this.btnCalculate.HighEmphasis = true;
            this.btnCalculate.Icon = null;
            this.btnCalculate.Location = new System.Drawing.Point(0, 95);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(220, 55);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "📅 احتساب";
            this.btnCalculate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCalculate.UseAccentColor = false;
            this.btnCalculate.UseVisualStyleBackColor = true;
            //
            // pnlDataGrid
            //
            this.pnlDataGrid.BackColor = System.Drawing.Color.White;
            this.pnlDataGrid.Controls.Add(this.dgvRentSummary);
            this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGrid.Location = new System.Drawing.Point(0, 254);
            this.pnlDataGrid.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlDataGrid.Size = new System.Drawing.Size(1267, 777);
            this.pnlDataGrid.TabIndex = 2;
            //
            // dgvRentSummary
            //
            this.dgvRentSummary.AllowUserToAddRows = false;
            this.dgvRentSummary.AllowUserToDeleteRows = false;
            this.dgvRentSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRentSummary.BackgroundColor = System.Drawing.Color.White;
            this.dgvRentSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRentSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentSummary.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.dgvRentSummary.Location = new System.Drawing.Point(27, 25);
            this.dgvRentSummary.MultiSelect = false;
            this.dgvRentSummary.Name = "dgvRentSummary";
            this.dgvRentSummary.ReadOnly = true;
            this.dgvRentSummary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvRentSummary.RowHeadersWidth = 51;
            this.dgvRentSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentSummary.Size = new System.Drawing.Size(1213, 727);
            this.dgvRentSummary.TabIndex = 0;
            //
            // UC_RentCalculation
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlDataGrid);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_RentCalculation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1267, 1031);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentSummary)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlFilters;
        private MaterialSkin.Controls.MaterialLabel lblPropertyNo;
        private MaterialSkin.Controls.MaterialTextBox2 txtPropertyNo;
        private MaterialSkin.Controls.MaterialLabel lblYear;
        private MaterialSkin.Controls.MaterialComboBox cmbYear;
        private MaterialSkin.Controls.MaterialLabel lblMonth;
        private MaterialSkin.Controls.MaterialComboBox cmbMonth;
        private MaterialSkin.Controls.MaterialButton btnCalculate;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dgvRentSummary;
    }
}
