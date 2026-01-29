using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Dari
{
    partial class UC_TenantInvoices
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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnEdit = new MaterialSkin.Controls.MaterialButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.pnlFields = new System.Windows.Forms.Panel();
            this.lblNarration = new MaterialSkin.Controls.MaterialLabel();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lblOtherFees = new MaterialSkin.Controls.MaterialLabel();
            this.txtOtherFees = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblWaterAmount = new MaterialSkin.Controls.MaterialLabel();
            this.txtWaterAmount = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblWaterUsage = new MaterialSkin.Controls.MaterialLabel();
            this.txtWaterUsage = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblElectricityAmount = new MaterialSkin.Controls.MaterialLabel();
            this.txtElectricityAmount = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblElectricityUsage = new MaterialSkin.Controls.MaterialLabel();
            this.txtElectricityUsage = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblInvoiceDate = new MaterialSkin.Controls.MaterialLabel();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblBillMonth = new MaterialSkin.Controls.MaterialLabel();
            this.cmbBillMonth = new MaterialSkin.Controls.MaterialComboBox();
            this.lblBillYear = new MaterialSkin.Controls.MaterialLabel();
            this.cmbBillYear = new MaterialSkin.Controls.MaterialComboBox();
            this.lblTenantNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenantNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblInvoiceNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtInvoiceNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlFields.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
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
            this.lblTitle.Location = new System.Drawing.Point(1120, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "فواتير المستأجرين";
            //
            // pnlForm
            //
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.pnlButtons);
            this.pnlForm.Controls.Add(this.pnlFields);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForm.Location = new System.Drawing.Point(0, 74);
            this.pnlForm.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlForm.Size = new System.Drawing.Size(1267, 600);
            this.pnlForm.TabIndex = 1;
            //
            // pnlButtons
            //
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Controls.Add(this.btnSearch);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnEdit);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(27, 477);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlButtons.Size = new System.Drawing.Size(1213, 98);
            this.pnlButtons.TabIndex = 1;
            //
            // btnSave
            //
            this.btnSave.AutoSize = false;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = false;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(0, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 62);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "حفظ";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            //
            // btnSearch
            //
            this.btnSearch.AutoSize = false;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.HighEmphasis = false;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(213, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 62);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "🔍 عرض";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            //
            // btnDelete
            //
            this.btnDelete.AutoSize = false;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(427, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 62);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "🗑️ حذف";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = true;
            this.btnDelete.UseVisualStyleBackColor = true;
            //
            // btnEdit
            //
            this.btnEdit.AutoSize = false;
            this.btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(640, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(200, 62);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "✏️ تعديل";
            this.btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEdit.UseAccentColor = false;
            this.btnEdit.UseVisualStyleBackColor = true;
            //
            // btnAdd
            //
            this.btnAdd.AutoSize = false;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(853, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 62);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "➕ إضافة";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            //
            // pnlFields
            //
            this.pnlFields.Controls.Add(this.lblInvoiceNo);
            this.pnlFields.Controls.Add(this.txtInvoiceNo);
            this.pnlFields.Controls.Add(this.lblTenantNo);
            this.pnlFields.Controls.Add(this.txtTenantNo);
            this.pnlFields.Controls.Add(this.lblBillYear);
            this.pnlFields.Controls.Add(this.cmbBillYear);
            this.pnlFields.Controls.Add(this.lblBillMonth);
            this.pnlFields.Controls.Add(this.cmbBillMonth);
            this.pnlFields.Controls.Add(this.lblInvoiceDate);
            this.pnlFields.Controls.Add(this.dtpInvoiceDate);
            this.pnlFields.Controls.Add(this.lblElectricityUsage);
            this.pnlFields.Controls.Add(this.txtElectricityUsage);
            this.pnlFields.Controls.Add(this.lblElectricityAmount);
            this.pnlFields.Controls.Add(this.txtElectricityAmount);
            this.pnlFields.Controls.Add(this.lblWaterUsage);
            this.pnlFields.Controls.Add(this.txtWaterUsage);
            this.pnlFields.Controls.Add(this.lblWaterAmount);
            this.pnlFields.Controls.Add(this.txtWaterAmount);
            this.pnlFields.Controls.Add(this.lblOtherFees);
            this.pnlFields.Controls.Add(this.txtOtherFees);
            this.pnlFields.Controls.Add(this.lblNarration);
            this.pnlFields.Controls.Add(this.txtNarration);
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFields.Location = new System.Drawing.Point(27, 25);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlFields.Size = new System.Drawing.Size(1213, 550);
            this.pnlFields.TabIndex = 0;
            //
            // lblInvoiceNo
            //
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Depth = 0;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblInvoiceNo.Location = new System.Drawing.Point(1097, 0);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(79, 19);
            this.lblInvoiceNo.TabIndex = 1;
            this.lblInvoiceNo.Text = "رقم الفاتورة:";
            //
            // txtInvoiceNo
            //
            this.txtInvoiceNo.AnimateReadOnly = false;
            this.txtInvoiceNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtInvoiceNo.Depth = 0;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtInvoiceNo.HideSelection = true;
            this.txtInvoiceNo.LeadingIcon = null;
            this.txtInvoiceNo.Location = new System.Drawing.Point(613, 21);
            this.txtInvoiceNo.MaxLength = 50;
            this.txtInvoiceNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.PasswordChar = '\0';
            this.txtInvoiceNo.PrefixSuffixText = null;
            this.txtInvoiceNo.ReadOnly = false;
            this.txtInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtInvoiceNo.Size = new System.Drawing.Size(587, 36);
            this.txtInvoiceNo.TabIndex = 0;
            this.txtInvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInvoiceNo.TrailingIcon = null;
            this.txtInvoiceNo.UseSystemPasswordChar = false;
            this.txtInvoiceNo.UseTallSize = false;
            //
            // lblTenantNo
            //
            this.lblTenantNo.AutoSize = true;
            this.lblTenantNo.Depth = 0;
            this.lblTenantNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTenantNo.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblTenantNo.Location = new System.Drawing.Point(495, 0);
            this.lblTenantNo.Name = "lblTenantNo";
            this.lblTenantNo.Size = new System.Drawing.Size(84, 19);
            this.lblTenantNo.TabIndex = 3;
            this.lblTenantNo.Text = "رقم المستأجر:";
            //
            // txtTenantNo
            //
            this.txtTenantNo.AnimateReadOnly = false;
            this.txtTenantNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenantNo.Depth = 0;
            this.txtTenantNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenantNo.HideSelection = false;
            this.txtTenantNo.LeadingIcon = null;
            this.txtTenantNo.Location = new System.Drawing.Point(0, 21);
            this.txtTenantNo.MaxLength = 50;
            this.txtTenantNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenantNo.Name = "txtTenantNo";
            this.txtTenantNo.PasswordChar = '\0';
            this.txtTenantNo.PrefixSuffixText = null;
            this.txtTenantNo.ReadOnly = false;
            this.txtTenantNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTenantNo.Size = new System.Drawing.Size(587, 36);
            this.txtTenantNo.TabIndex = 1;
            this.txtTenantNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTenantNo.TrailingIcon = null;
            this.txtTenantNo.UseSystemPasswordChar = false;
            this.txtTenantNo.UseTallSize = false;
            //
            // lblBillYear
            //
            this.lblBillYear.AutoSize = true;
            this.lblBillYear.Depth = 0;
            this.lblBillYear.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBillYear.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblBillYear.Location = new System.Drawing.Point(1115, 60);
            this.lblBillYear.Name = "lblBillYear";
            this.lblBillYear.Size = new System.Drawing.Size(41, 19);
            this.lblBillYear.TabIndex = 5;
            this.lblBillYear.Text = "السنة:";
            //
            // cmbBillYear
            //
            this.cmbBillYear.AutoResize = false;
            this.cmbBillYear.BackColor = System.Drawing.Color.White;
            this.cmbBillYear.Depth = 0;
            this.cmbBillYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBillYear.DropDownHeight = 174;
            this.cmbBillYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillYear.DropDownWidth = 121;
            this.cmbBillYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbBillYear.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            this.cmbBillYear.FormattingEnabled = true;
            this.cmbBillYear.IntegralHeight = false;
            this.cmbBillYear.ItemHeight = 43;
            this.cmbBillYear.Location = new System.Drawing.Point(613, 81);
            this.cmbBillYear.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBillYear.Name = "cmbBillYear";
            this.cmbBillYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbBillYear.Size = new System.Drawing.Size(587, 49);
            this.cmbBillYear.StartIndex = 0;
            this.cmbBillYear.TabIndex = 2;
            //
            // lblBillMonth
            //
            this.lblBillMonth.AutoSize = true;
            this.lblBillMonth.Depth = 0;
            this.lblBillMonth.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBillMonth.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblBillMonth.Location = new System.Drawing.Point(509, 60);
            this.lblBillMonth.Name = "lblBillMonth";
            this.lblBillMonth.Size = new System.Drawing.Size(43, 19);
            this.lblBillMonth.TabIndex = 7;
            this.lblBillMonth.Text = "الشهر:";
            //
            // cmbBillMonth
            //
            this.cmbBillMonth.AutoResize = false;
            this.cmbBillMonth.BackColor = System.Drawing.Color.White;
            this.cmbBillMonth.Depth = 0;
            this.cmbBillMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBillMonth.DropDownHeight = 174;
            this.cmbBillMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillMonth.DropDownWidth = 121;
            this.cmbBillMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbBillMonth.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            this.cmbBillMonth.FormattingEnabled = true;
            this.cmbBillMonth.IntegralHeight = false;
            this.cmbBillMonth.ItemHeight = 43;
            this.cmbBillMonth.Items.AddRange(new object[] {
                "1 - يناير", "2 - فبراير", "3 - مارس", "4 - أبريل", "5 - مايو", "6 - يونيو",
                "7 - يوليو", "8 - أغسطس", "9 - سبتمبر", "10 - أكتوبر", "11 - نوفمبر", "12 - ديسمبر"
            });
            this.cmbBillMonth.Location = new System.Drawing.Point(0, 81);
            this.cmbBillMonth.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBillMonth.Name = "cmbBillMonth";
            this.cmbBillMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbBillMonth.Size = new System.Drawing.Size(587, 49);
            this.cmbBillMonth.StartIndex = 0;
            this.cmbBillMonth.TabIndex = 3;
            //
            // lblInvoiceDate
            //
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Depth = 0;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblInvoiceDate.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblInvoiceDate.Location = new System.Drawing.Point(1085, 135);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(91, 19);
            this.lblInvoiceDate.TabIndex = 9;
            this.lblInvoiceDate.Text = "تاريخ الفاتورة:";
            //
            // dtpInvoiceDate
            //
            this.dtpInvoiceDate.CustomFormat = "yyyy-MM-dd";
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(613, 156);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpInvoiceDate.RightToLeftLayout = true;
            this.dtpInvoiceDate.Size = new System.Drawing.Size(587, 22);
            this.dtpInvoiceDate.TabIndex = 4;
            //
            // lblElectricityUsage
            //
            this.lblElectricityUsage.AutoSize = true;
            this.lblElectricityUsage.Depth = 0;
            this.lblElectricityUsage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblElectricityUsage.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblElectricityUsage.Location = new System.Drawing.Point(1065, 200);
            this.lblElectricityUsage.Name = "lblElectricityUsage";
            this.lblElectricityUsage.Size = new System.Drawing.Size(111, 19);
            this.lblElectricityUsage.TabIndex = 11;
            this.lblElectricityUsage.Text = "استهلاك الكهرباء:";
            //
            // txtElectricityUsage
            //
            this.txtElectricityUsage.AnimateReadOnly = false;
            this.txtElectricityUsage.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtElectricityUsage.Depth = 0;
            this.txtElectricityUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtElectricityUsage.HideSelection = false;
            this.txtElectricityUsage.LeadingIcon = null;
            this.txtElectricityUsage.Location = new System.Drawing.Point(613, 221);
            this.txtElectricityUsage.MaxLength = 20;
            this.txtElectricityUsage.MouseState = MaterialSkin.MouseState.OUT;
            this.txtElectricityUsage.Name = "txtElectricityUsage";
            this.txtElectricityUsage.PasswordChar = '\0';
            this.txtElectricityUsage.PrefixSuffixText = null;
            this.txtElectricityUsage.ReadOnly = false;
            this.txtElectricityUsage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtElectricityUsage.Size = new System.Drawing.Size(587, 36);
            this.txtElectricityUsage.TabIndex = 5;
            this.txtElectricityUsage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtElectricityUsage.TrailingIcon = null;
            this.txtElectricityUsage.UseSystemPasswordChar = false;
            this.txtElectricityUsage.UseTallSize = false;
            //
            // lblElectricityAmount
            //
            this.lblElectricityAmount.AutoSize = true;
            this.lblElectricityAmount.Depth = 0;
            this.lblElectricityAmount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblElectricityAmount.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblElectricityAmount.Location = new System.Drawing.Point(495, 200);
            this.lblElectricityAmount.Name = "lblElectricityAmount";
            this.lblElectricityAmount.Size = new System.Drawing.Size(95, 19);
            this.lblElectricityAmount.TabIndex = 13;
            this.lblElectricityAmount.Text = "قيمة الكهرباء:";
            //
            // txtElectricityAmount
            //
            this.txtElectricityAmount.AnimateReadOnly = false;
            this.txtElectricityAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtElectricityAmount.Depth = 0;
            this.txtElectricityAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtElectricityAmount.HideSelection = false;
            this.txtElectricityAmount.LeadingIcon = null;
            this.txtElectricityAmount.Location = new System.Drawing.Point(0, 221);
            this.txtElectricityAmount.MaxLength = 20;
            this.txtElectricityAmount.MouseState = MaterialSkin.MouseState.OUT;
            this.txtElectricityAmount.Name = "txtElectricityAmount";
            this.txtElectricityAmount.PasswordChar = '\0';
            this.txtElectricityAmount.PrefixSuffixText = null;
            this.txtElectricityAmount.ReadOnly = false;
            this.txtElectricityAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtElectricityAmount.Size = new System.Drawing.Size(587, 36);
            this.txtElectricityAmount.TabIndex = 6;
            this.txtElectricityAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtElectricityAmount.TrailingIcon = null;
            this.txtElectricityAmount.UseSystemPasswordChar = false;
            this.txtElectricityAmount.UseTallSize = false;
            //
            // lblWaterUsage
            //
            this.lblWaterUsage.AutoSize = true;
            this.lblWaterUsage.Depth = 0;
            this.lblWaterUsage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWaterUsage.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblWaterUsage.Location = new System.Drawing.Point(1085, 265);
            this.lblWaterUsage.Name = "lblWaterUsage";
            this.lblWaterUsage.Size = new System.Drawing.Size(91, 19);
            this.lblWaterUsage.TabIndex = 15;
            this.lblWaterUsage.Text = "استهلاك الماء:";
            //
            // txtWaterUsage
            //
            this.txtWaterUsage.AnimateReadOnly = false;
            this.txtWaterUsage.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtWaterUsage.Depth = 0;
            this.txtWaterUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtWaterUsage.HideSelection = false;
            this.txtWaterUsage.LeadingIcon = null;
            this.txtWaterUsage.Location = new System.Drawing.Point(613, 286);
            this.txtWaterUsage.MaxLength = 20;
            this.txtWaterUsage.MouseState = MaterialSkin.MouseState.OUT;
            this.txtWaterUsage.Name = "txtWaterUsage";
            this.txtWaterUsage.PasswordChar = '\0';
            this.txtWaterUsage.PrefixSuffixText = null;
            this.txtWaterUsage.ReadOnly = false;
            this.txtWaterUsage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtWaterUsage.Size = new System.Drawing.Size(587, 36);
            this.txtWaterUsage.TabIndex = 7;
            this.txtWaterUsage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWaterUsage.TrailingIcon = null;
            this.txtWaterUsage.UseSystemPasswordChar = false;
            this.txtWaterUsage.UseTallSize = false;
            //
            // lblWaterAmount
            //
            this.lblWaterAmount.AutoSize = true;
            this.lblWaterAmount.Depth = 0;
            this.lblWaterAmount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWaterAmount.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblWaterAmount.Location = new System.Drawing.Point(515, 265);
            this.lblWaterAmount.Name = "lblWaterAmount";
            this.lblWaterAmount.Size = new System.Drawing.Size(75, 19);
            this.lblWaterAmount.TabIndex = 17;
            this.lblWaterAmount.Text = "قيمة الماء:";
            //
            // txtWaterAmount
            //
            this.txtWaterAmount.AnimateReadOnly = false;
            this.txtWaterAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtWaterAmount.Depth = 0;
            this.txtWaterAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtWaterAmount.HideSelection = false;
            this.txtWaterAmount.LeadingIcon = null;
            this.txtWaterAmount.Location = new System.Drawing.Point(0, 286);
            this.txtWaterAmount.MaxLength = 20;
            this.txtWaterAmount.MouseState = MaterialSkin.MouseState.OUT;
            this.txtWaterAmount.Name = "txtWaterAmount";
            this.txtWaterAmount.PasswordChar = '\0';
            this.txtWaterAmount.PrefixSuffixText = null;
            this.txtWaterAmount.ReadOnly = false;
            this.txtWaterAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtWaterAmount.Size = new System.Drawing.Size(587, 36);
            this.txtWaterAmount.TabIndex = 8;
            this.txtWaterAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWaterAmount.TrailingIcon = null;
            this.txtWaterAmount.UseSystemPasswordChar = false;
            this.txtWaterAmount.UseTallSize = false;
            //
            // lblOtherFees
            //
            this.lblOtherFees.AutoSize = true;
            this.lblOtherFees.Depth = 0;
            this.lblOtherFees.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblOtherFees.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblOtherFees.Location = new System.Drawing.Point(1115, 330);
            this.lblOtherFees.Name = "lblOtherFees";
            this.lblOtherFees.Size = new System.Drawing.Size(71, 19);
            this.lblOtherFees.TabIndex = 19;
            this.lblOtherFees.Text = "رسوم أخرى:";
            //
            // txtOtherFees
            //
            this.txtOtherFees.AnimateReadOnly = false;
            this.txtOtherFees.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtOtherFees.Depth = 0;
            this.txtOtherFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOtherFees.HideSelection = false;
            this.txtOtherFees.LeadingIcon = null;
            this.txtOtherFees.Location = new System.Drawing.Point(613, 351);
            this.txtOtherFees.MaxLength = 20;
            this.txtOtherFees.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOtherFees.Name = "txtOtherFees";
            this.txtOtherFees.PasswordChar = '\0';
            this.txtOtherFees.PrefixSuffixText = null;
            this.txtOtherFees.ReadOnly = false;
            this.txtOtherFees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOtherFees.Size = new System.Drawing.Size(587, 36);
            this.txtOtherFees.TabIndex = 9;
            this.txtOtherFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOtherFees.TrailingIcon = null;
            this.txtOtherFees.UseSystemPasswordChar = false;
            this.txtOtherFees.UseTallSize = false;
            //
            // lblNarration
            //
            this.lblNarration.AutoSize = true;
            this.lblNarration.Depth = 0;
            this.lblNarration.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNarration.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblNarration.Location = new System.Drawing.Point(1135, 395);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(41, 19);
            this.lblNarration.TabIndex = 21;
            this.lblNarration.Text = "البيان:";
            //
            // txtNarration
            //
            this.txtNarration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNarration.Location = new System.Drawing.Point(613, 416);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNarration.Size = new System.Drawing.Size(587, 80);
            this.txtNarration.TabIndex = 10;
            //
            // pnlDataGrid
            //
            this.pnlDataGrid.BackColor = System.Drawing.Color.White;
            this.pnlDataGrid.Controls.Add(this.dgvInvoices);
            this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGrid.Location = new System.Drawing.Point(0, 674);
            this.pnlDataGrid.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlDataGrid.Size = new System.Drawing.Size(1267, 357);
            this.pnlDataGrid.TabIndex = 2;
            //
            // dgvInvoices
            //
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoices.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoices.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.dgvInvoices.Location = new System.Drawing.Point(27, 25);
            this.dgvInvoices.MultiSelect = false;
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvInvoices.RowHeadersWidth = 51;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(1213, 307);
            this.dgvInvoices.TabIndex = 0;
            //
            // UC_TenantInvoices
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlDataGrid);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_TenantInvoices";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1267, 1031);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlFields.ResumeLayout(false);
            this.pnlFields.PerformLayout();
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlFields;
        private MaterialSkin.Controls.MaterialLabel lblInvoiceNo;
        private MaterialSkin.Controls.MaterialTextBox2 txtInvoiceNo;
        private MaterialSkin.Controls.MaterialLabel lblTenantNo;
        private MaterialSkin.Controls.MaterialTextBox2 txtTenantNo;
        private MaterialSkin.Controls.MaterialLabel lblBillYear;
        private MaterialSkin.Controls.MaterialComboBox cmbBillYear;
        private MaterialSkin.Controls.MaterialLabel lblBillMonth;
        private MaterialSkin.Controls.MaterialComboBox cmbBillMonth;
        private MaterialSkin.Controls.MaterialLabel lblInvoiceDate;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private MaterialSkin.Controls.MaterialLabel lblElectricityUsage;
        private MaterialSkin.Controls.MaterialTextBox2 txtElectricityUsage;
        private MaterialSkin.Controls.MaterialLabel lblElectricityAmount;
        private MaterialSkin.Controls.MaterialTextBox2 txtElectricityAmount;
        private MaterialSkin.Controls.MaterialLabel lblWaterUsage;
        private MaterialSkin.Controls.MaterialTextBox2 txtWaterUsage;
        private MaterialSkin.Controls.MaterialLabel lblWaterAmount;
        private MaterialSkin.Controls.MaterialTextBox2 txtWaterAmount;
        private MaterialSkin.Controls.MaterialLabel lblOtherFees;
        private MaterialSkin.Controls.MaterialTextBox2 txtOtherFees;
        private MaterialSkin.Controls.MaterialLabel lblNarration;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Panel pnlButtons;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dgvInvoices;
    }
}
