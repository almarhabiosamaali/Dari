using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Dari
{
    partial class UC_Contracts
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
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
            this.lblContractStatus = new MaterialSkin.Controls.MaterialLabel();
            this.cmbContractStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.lblOtherFees = new MaterialSkin.Controls.MaterialLabel();
            this.txtOtherFees = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblDepositAmount = new MaterialSkin.Controls.MaterialLabel();
            this.txtDepositAmount = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblMonthlyRent = new MaterialSkin.Controls.MaterialLabel();
            this.txtMonthlyRent = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblEndDate = new MaterialSkin.Controls.MaterialLabel();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new MaterialSkin.Controls.MaterialLabel();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblApartmentNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtApartmentNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblTenantNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenantNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblContractNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtContractNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlFields.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
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
            this.lblTitle.Location = new System.Drawing.Point(1169, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(79, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "بيانات العقود";
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.pnlButtons);
            this.pnlForm.Controls.Add(this.pnlFields);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForm.Location = new System.Drawing.Point(0, 74);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlForm.Name = "pnlForm";
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
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlButtons.Size = new System.Drawing.Size(1213, 98);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = false;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(0, 18);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(200, 62);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "حفظ ";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = false;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.HighEmphasis = false;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(213, 18);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearch.Size = new System.Drawing.Size(200, 62);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "🔍 بحث";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(427, 18);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
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
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(640, 18);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
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
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(853, 18);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(200, 62);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "➕ إضافة";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // pnlFields
            // 
            this.pnlFields.Controls.Add(this.lblContractStatus);
            this.pnlFields.Controls.Add(this.cmbContractStatus);
            this.pnlFields.Controls.Add(this.lblOtherFees);
            this.pnlFields.Controls.Add(this.txtOtherFees);
            this.pnlFields.Controls.Add(this.lblDepositAmount);
            this.pnlFields.Controls.Add(this.txtDepositAmount);
            this.pnlFields.Controls.Add(this.lblMonthlyRent);
            this.pnlFields.Controls.Add(this.txtMonthlyRent);
            this.pnlFields.Controls.Add(this.lblEndDate);
            this.pnlFields.Controls.Add(this.dtpEndDate);
            this.pnlFields.Controls.Add(this.lblStartDate);
            this.pnlFields.Controls.Add(this.dtpStartDate);
            this.pnlFields.Controls.Add(this.lblApartmentNo);
            this.pnlFields.Controls.Add(this.txtApartmentNo);
            this.pnlFields.Controls.Add(this.lblTenantNo);
            this.pnlFields.Controls.Add(this.txtTenantNo);
            this.pnlFields.Controls.Add(this.lblContractNo);
            this.pnlFields.Controls.Add(this.txtContractNo);
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFields.Location = new System.Drawing.Point(27, 25);
            this.pnlFields.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlFields.Size = new System.Drawing.Size(1213, 550);
            this.pnlFields.TabIndex = 0;
            // 
            // lblContractStatus
            // 
            this.lblContractStatus.AutoSize = true;
            this.lblContractStatus.Depth = 0;
            this.lblContractStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblContractStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblContractStatus.Location = new System.Drawing.Point(1097, 255);
            this.lblContractStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContractStatus.Name = "lblContractStatus";
            this.lblContractStatus.Size = new System.Drawing.Size(64, 17);
            this.lblContractStatus.TabIndex = 17;
            this.lblContractStatus.Text = "حالة العقد:";
            // 
            // cmbContractStatus
            // 
            this.cmbContractStatus.AutoResize = false;
            this.cmbContractStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbContractStatus.Depth = 0;
            this.cmbContractStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbContractStatus.DropDownHeight = 174;
            this.cmbContractStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContractStatus.DropDownWidth = 121;
            this.cmbContractStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbContractStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbContractStatus.FormattingEnabled = true;
            this.cmbContractStatus.IntegralHeight = false;
            this.cmbContractStatus.ItemHeight = 43;
            this.cmbContractStatus.Items.AddRange(new object[] {
            "نشط",
            "منتهي",
            "ملغي",
            "معلق"});
            this.cmbContractStatus.Location = new System.Drawing.Point(613, 276);
            this.cmbContractStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbContractStatus.MaxDropDownItems = 4;
            this.cmbContractStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbContractStatus.Name = "cmbContractStatus";
            this.cmbContractStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbContractStatus.Size = new System.Drawing.Size(587, 49);
            this.cmbContractStatus.StartIndex = 0;
            this.cmbContractStatus.TabIndex = 8;
            // 
            // lblOtherFees
            // 
            this.lblOtherFees.AutoSize = true;
            this.lblOtherFees.Depth = 0;
            this.lblOtherFees.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblOtherFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOtherFees.Location = new System.Drawing.Point(495, 255);
            this.lblOtherFees.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOtherFees.Name = "lblOtherFees";
            this.lblOtherFees.Size = new System.Drawing.Size(71, 17);
            this.lblOtherFees.TabIndex = 15;
            this.lblOtherFees.Text = "رسوم أخرى:";
            // 
            // txtOtherFees
            // 
            this.txtOtherFees.AnimateReadOnly = false;
            this.txtOtherFees.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtOtherFees.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtOtherFees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtOtherFees.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtOtherFees.Depth = 0;
            this.txtOtherFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOtherFees.HideSelection = false;
            this.txtOtherFees.LeadingIcon = null;
            this.txtOtherFees.Location = new System.Drawing.Point(0, 276);
            this.txtOtherFees.Margin = new System.Windows.Forms.Padding(4);
            this.txtOtherFees.MaxLength = 20;
            this.txtOtherFees.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOtherFees.Name = "txtOtherFees";
            this.txtOtherFees.PasswordChar = '\0';
            this.txtOtherFees.PrefixSuffixText = null;
            this.txtOtherFees.ReadOnly = false;
            this.txtOtherFees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOtherFees.SelectedText = "";
            this.txtOtherFees.SelectionLength = 0;
            this.txtOtherFees.SelectionStart = 0;
            this.txtOtherFees.ShortcutsEnabled = true;
            this.txtOtherFees.Size = new System.Drawing.Size(587, 36);
            this.txtOtherFees.TabIndex = 7;
            this.txtOtherFees.TabStop = false;
            this.txtOtherFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOtherFees.TrailingIcon = null;
            this.txtOtherFees.UseSystemPasswordChar = false;
            this.txtOtherFees.UseTallSize = false;
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Depth = 0;
            this.lblDepositAmount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDepositAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDepositAmount.Location = new System.Drawing.Point(1097, 190);
            this.lblDepositAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(76, 17);
            this.lblDepositAmount.TabIndex = 13;
            this.lblDepositAmount.Text = "مبلغ الضمان:";
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.AnimateReadOnly = false;
            this.txtDepositAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDepositAmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDepositAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDepositAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDepositAmount.Depth = 0;
            this.txtDepositAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDepositAmount.HideSelection = false;
            this.txtDepositAmount.LeadingIcon = null;
            this.txtDepositAmount.Location = new System.Drawing.Point(613, 211);
            this.txtDepositAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepositAmount.MaxLength = 20;
            this.txtDepositAmount.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.PasswordChar = '\0';
            this.txtDepositAmount.PrefixSuffixText = null;
            this.txtDepositAmount.ReadOnly = false;
            this.txtDepositAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDepositAmount.SelectedText = "";
            this.txtDepositAmount.SelectionLength = 0;
            this.txtDepositAmount.SelectionStart = 0;
            this.txtDepositAmount.ShortcutsEnabled = true;
            this.txtDepositAmount.Size = new System.Drawing.Size(587, 36);
            this.txtDepositAmount.TabIndex = 6;
            this.txtDepositAmount.TabStop = false;
            this.txtDepositAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDepositAmount.TrailingIcon = null;
            this.txtDepositAmount.UseSystemPasswordChar = false;
            this.txtDepositAmount.UseTallSize = false;
            // 
            // lblMonthlyRent
            // 
            this.lblMonthlyRent.AutoSize = true;
            this.lblMonthlyRent.Depth = 0;
            this.lblMonthlyRent.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMonthlyRent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMonthlyRent.Location = new System.Drawing.Point(495, 190);
            this.lblMonthlyRent.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMonthlyRent.Name = "lblMonthlyRent";
            this.lblMonthlyRent.Size = new System.Drawing.Size(92, 17);
            this.lblMonthlyRent.TabIndex = 11;
            this.lblMonthlyRent.Text = "الإيجار الشهري:";
            // 
            // txtMonthlyRent
            // 
            this.txtMonthlyRent.AnimateReadOnly = false;
            this.txtMonthlyRent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMonthlyRent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMonthlyRent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMonthlyRent.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMonthlyRent.Depth = 0;
            this.txtMonthlyRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMonthlyRent.HideSelection = false;
            this.txtMonthlyRent.LeadingIcon = null;
            this.txtMonthlyRent.Location = new System.Drawing.Point(0, 211);
            this.txtMonthlyRent.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonthlyRent.MaxLength = 20;
            this.txtMonthlyRent.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMonthlyRent.Name = "txtMonthlyRent";
            this.txtMonthlyRent.PasswordChar = '\0';
            this.txtMonthlyRent.PrefixSuffixText = null;
            this.txtMonthlyRent.ReadOnly = false;
            this.txtMonthlyRent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMonthlyRent.SelectedText = "";
            this.txtMonthlyRent.SelectionLength = 0;
            this.txtMonthlyRent.SelectionStart = 0;
            this.txtMonthlyRent.ShortcutsEnabled = true;
            this.txtMonthlyRent.Size = new System.Drawing.Size(587, 36);
            this.txtMonthlyRent.TabIndex = 5;
            this.txtMonthlyRent.TabStop = false;
            this.txtMonthlyRent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonthlyRent.TrailingIcon = null;
            this.txtMonthlyRent.UseSystemPasswordChar = false;
            this.txtMonthlyRent.UseTallSize = false;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Depth = 0;
            this.lblEndDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEndDate.Location = new System.Drawing.Point(1097, 125);
            this.lblEndDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(82, 17);
            this.lblEndDate.TabIndex = 9;
            this.lblEndDate.Text = "تاريخ الانتهاء:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(613, 146);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpEndDate.RightToLeftLayout = true;
            this.dtpEndDate.Size = new System.Drawing.Size(587, 22);
            this.dtpEndDate.TabIndex = 4;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Depth = 0;
            this.lblStartDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStartDate.Location = new System.Drawing.Point(495, 125);
            this.lblStartDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(68, 17);
            this.lblStartDate.TabIndex = 7;
            this.lblStartDate.Text = "تاريخ البدء:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "yyyy-MM-dd";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(0, 146);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpStartDate.RightToLeftLayout = true;
            this.dtpStartDate.Size = new System.Drawing.Size(587, 22);
            this.dtpStartDate.TabIndex = 3;
            // 
            // lblApartmentNo
            // 
            this.lblApartmentNo.AutoSize = true;
            this.lblApartmentNo.Depth = 0;
            this.lblApartmentNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblApartmentNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblApartmentNo.Location = new System.Drawing.Point(1097, 60);
            this.lblApartmentNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblApartmentNo.Name = "lblApartmentNo";
            this.lblApartmentNo.Size = new System.Drawing.Size(65, 17);
            this.lblApartmentNo.TabIndex = 5;
            this.lblApartmentNo.Text = "رقم الشقة:";
            // 
            // txtApartmentNo
            // 
            this.txtApartmentNo.AnimateReadOnly = false;
            this.txtApartmentNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtApartmentNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtApartmentNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtApartmentNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtApartmentNo.Depth = 0;
            this.txtApartmentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApartmentNo.HideSelection = false;
            this.txtApartmentNo.LeadingIcon = null;
            this.txtApartmentNo.Location = new System.Drawing.Point(613, 81);
            this.txtApartmentNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtApartmentNo.MaxLength = 50;
            this.txtApartmentNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApartmentNo.Name = "txtApartmentNo";
            this.txtApartmentNo.PasswordChar = '\0';
            this.txtApartmentNo.PrefixSuffixText = null;
            this.txtApartmentNo.ReadOnly = false;
            this.txtApartmentNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtApartmentNo.SelectedText = "";
            this.txtApartmentNo.SelectionLength = 0;
            this.txtApartmentNo.SelectionStart = 0;
            this.txtApartmentNo.ShortcutsEnabled = true;
            this.txtApartmentNo.Size = new System.Drawing.Size(587, 36);
            this.txtApartmentNo.TabIndex = 2;
            this.txtApartmentNo.TabStop = false;
            this.txtApartmentNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtApartmentNo.TrailingIcon = null;
            this.txtApartmentNo.UseSystemPasswordChar = false;
            this.txtApartmentNo.UseTallSize = false;
            // 
            // lblTenantNo
            // 
            this.lblTenantNo.AutoSize = true;
            this.lblTenantNo.Depth = 0;
            this.lblTenantNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTenantNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTenantNo.Location = new System.Drawing.Point(495, 60);
            this.lblTenantNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTenantNo.Name = "lblTenantNo";
            this.lblTenantNo.Size = new System.Drawing.Size(84, 17);
            this.lblTenantNo.TabIndex = 3;
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
            this.txtTenantNo.Location = new System.Drawing.Point(0, 81);
            this.txtTenantNo.Margin = new System.Windows.Forms.Padding(4);
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
            this.txtTenantNo.Size = new System.Drawing.Size(587, 36);
            this.txtTenantNo.TabIndex = 1;
            this.txtTenantNo.TabStop = false;
            this.txtTenantNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTenantNo.TrailingIcon = null;
            this.txtTenantNo.UseSystemPasswordChar = false;
            this.txtTenantNo.UseTallSize = false;
            // 
            // lblContractNo
            // 
            this.lblContractNo.AutoSize = true;
            this.lblContractNo.Depth = 0;
            this.lblContractNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblContractNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblContractNo.Location = new System.Drawing.Point(1094, 0);
            this.lblContractNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContractNo.Name = "lblContractNo";
            this.lblContractNo.Size = new System.Drawing.Size(60, 17);
            this.lblContractNo.TabIndex = 1;
            this.lblContractNo.Text = "رقم العقد:";
            // 
            // txtContractNo
            // 
            this.txtContractNo.AnimateReadOnly = false;
            this.txtContractNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtContractNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtContractNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtContractNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtContractNo.Depth = 0;
            this.txtContractNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContractNo.HideSelection = true;
            this.txtContractNo.LeadingIcon = null;
            this.txtContractNo.Location = new System.Drawing.Point(613, 21);
            this.txtContractNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtContractNo.MaxLength = 50;
            this.txtContractNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContractNo.Name = "txtContractNo";
            this.txtContractNo.PasswordChar = '\0';
            this.txtContractNo.PrefixSuffixText = null;
            this.txtContractNo.ReadOnly = false;
            this.txtContractNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContractNo.SelectedText = "";
            this.txtContractNo.SelectionLength = 0;
            this.txtContractNo.SelectionStart = 0;
            this.txtContractNo.ShortcutsEnabled = true;
            this.txtContractNo.Size = new System.Drawing.Size(587, 36);
            this.txtContractNo.TabIndex = 0;
            this.txtContractNo.TabStop = false;
            this.txtContractNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtContractNo.TrailingIcon = null;
            this.txtContractNo.UseSystemPasswordChar = false;
            this.txtContractNo.UseTallSize = false;
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.White;
            this.pnlDataGrid.Controls.Add(this.dgvContracts);
            this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGrid.Location = new System.Drawing.Point(0, 674);
            this.pnlDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlDataGrid.Size = new System.Drawing.Size(1267, 357);
            this.pnlDataGrid.TabIndex = 2;
            // 
            // dgvContracts
            // 
            this.dgvContracts.AllowUserToAddRows = false;
            this.dgvContracts.AllowUserToDeleteRows = false;
            this.dgvContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContracts.BackgroundColor = System.Drawing.Color.White;
            this.dgvContracts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContracts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvContracts.Location = new System.Drawing.Point(27, 25);
            this.dgvContracts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvContracts.MultiSelect = false;
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.ReadOnly = true;
            this.dgvContracts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvContracts.RowHeadersWidth = 51;
            this.dgvContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContracts.Size = new System.Drawing.Size(1213, 307);
            this.dgvContracts.TabIndex = 0;
            // 
            // UC_Contracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlDataGrid);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Contracts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1267, 1031);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlFields.ResumeLayout(false);
            this.pnlFields.PerformLayout();
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlFields;
        private MaterialSkin.Controls.MaterialTextBox2 txtContractNo;
        private MaterialSkin.Controls.MaterialLabel lblContractNo;
        private MaterialSkin.Controls.MaterialLabel lblTenantNo;
        private MaterialSkin.Controls.MaterialTextBox2 txtTenantNo;
        private MaterialSkin.Controls.MaterialLabel lblApartmentNo;
        private MaterialSkin.Controls.MaterialTextBox2 txtApartmentNo;
        private MaterialSkin.Controls.MaterialLabel lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private MaterialSkin.Controls.MaterialLabel lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private MaterialSkin.Controls.MaterialLabel lblMonthlyRent;
        private MaterialSkin.Controls.MaterialTextBox2 txtMonthlyRent;
        private MaterialSkin.Controls.MaterialLabel lblDepositAmount;
        private MaterialSkin.Controls.MaterialTextBox2 txtDepositAmount;
        private MaterialSkin.Controls.MaterialLabel lblOtherFees;
        private MaterialSkin.Controls.MaterialTextBox2 txtOtherFees;
        private MaterialSkin.Controls.MaterialLabel lblContractStatus;
        private MaterialSkin.Controls.MaterialComboBox cmbContractStatus;
        private System.Windows.Forms.Panel pnlButtons;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dgvContracts;
    }
}
