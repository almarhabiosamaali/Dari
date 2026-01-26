using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Dari
{
    partial class UC_Tenants
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
            this.lblCommercialRegNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtCommercialRegNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblGuarantorWorkPlace = new MaterialSkin.Controls.MaterialLabel();
            this.txtGuarantorWorkPlace = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblGuarantorMobile = new MaterialSkin.Controls.MaterialLabel();
            this.txtGuarantorMobile = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblGuarantorNationalId = new MaterialSkin.Controls.MaterialLabel();
            this.txtGuarantorNationalId = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblGuarantorName = new MaterialSkin.Controls.MaterialLabel();
            this.txtGuarantorName = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblTenantStatus = new MaterialSkin.Controls.MaterialLabel();
            this.cmbTenantStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.lblWorkPlace = new MaterialSkin.Controls.MaterialLabel();
            this.txtWorkPlace = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblJobTitle = new MaterialSkin.Controls.MaterialLabel();
            this.txtJobTitle = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblSocialStatus = new MaterialSkin.Controls.MaterialLabel();
            this.cmbSocialStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.lblNationality = new MaterialSkin.Controls.MaterialLabel();
            this.cmbNationality = new MaterialSkin.Controls.MaterialComboBox();
            this.lblBirthDate = new MaterialSkin.Controls.MaterialLabel();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblMobileNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtMobileNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblNationalIdNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtNationalIdNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblTenantName = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenantName = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblTenantNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenantNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dgvTenants = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlFields.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenants)).BeginInit();
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
            this.lblTitle.Location = new System.Drawing.Point(1155, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(114, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "بيانات المستأجرين";
            // 
            // pnlForm
            // 
            this.pnlForm.AutoScroll = true;
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.pnlButtons);
            this.pnlForm.Controls.Add(this.pnlFields);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 74);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlForm.Size = new System.Drawing.Size(1267, 1257);
            this.pnlForm.TabIndex = 1;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Controls.Add(this.btnSearch);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnEdit);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Location = new System.Drawing.Point(27, 560);
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
            this.pnlFields.Controls.Add(this.lblCommercialRegNo);
            this.pnlFields.Controls.Add(this.txtCommercialRegNo);
            this.pnlFields.Controls.Add(this.lblGuarantorWorkPlace);
            this.pnlFields.Controls.Add(this.txtGuarantorWorkPlace);
            this.pnlFields.Controls.Add(this.lblGuarantorMobile);
            this.pnlFields.Controls.Add(this.txtGuarantorMobile);
            this.pnlFields.Controls.Add(this.lblGuarantorNationalId);
            this.pnlFields.Controls.Add(this.txtGuarantorNationalId);
            this.pnlFields.Controls.Add(this.lblGuarantorName);
            this.pnlFields.Controls.Add(this.txtGuarantorName);
            this.pnlFields.Controls.Add(this.lblTenantStatus);
            this.pnlFields.Controls.Add(this.cmbTenantStatus);
            this.pnlFields.Controls.Add(this.lblWorkPlace);
            this.pnlFields.Controls.Add(this.txtWorkPlace);
            this.pnlFields.Controls.Add(this.lblJobTitle);
            this.pnlFields.Controls.Add(this.txtJobTitle);
            this.pnlFields.Controls.Add(this.lblSocialStatus);
            this.pnlFields.Controls.Add(this.cmbSocialStatus);
            this.pnlFields.Controls.Add(this.lblNationality);
            this.pnlFields.Controls.Add(this.cmbNationality);
            this.pnlFields.Controls.Add(this.lblBirthDate);
            this.pnlFields.Controls.Add(this.dtpBirthDate);
            this.pnlFields.Controls.Add(this.lblMobileNo);
            this.pnlFields.Controls.Add(this.txtMobileNo);
            this.pnlFields.Controls.Add(this.lblNationalIdNo);
            this.pnlFields.Controls.Add(this.txtNationalIdNo);
            this.pnlFields.Controls.Add(this.lblTenantName);
            this.pnlFields.Controls.Add(this.txtTenantName);
            this.pnlFields.Controls.Add(this.lblTenantNo);
            this.pnlFields.Controls.Add(this.txtTenantNo);
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFields.Location = new System.Drawing.Point(27, 25);
            this.pnlFields.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlFields.Size = new System.Drawing.Size(1213, 530);
            this.pnlFields.TabIndex = 0;
            // 
            // lblCommercialRegNo
            // 
            this.lblCommercialRegNo.AutoSize = true;
            this.lblCommercialRegNo.Depth = 0;
            this.lblCommercialRegNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCommercialRegNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCommercialRegNo.Location = new System.Drawing.Point(1092, 450);
            this.lblCommercialRegNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCommercialRegNo.Name = "lblCommercialRegNo";
            this.lblCommercialRegNo.Size = new System.Drawing.Size(119, 17);
            this.lblCommercialRegNo.TabIndex = 29;
            this.lblCommercialRegNo.Text = "رقم السجل التجاري:";
            // 
            // txtCommercialRegNo
            // 
            this.txtCommercialRegNo.AnimateReadOnly = false;
            this.txtCommercialRegNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCommercialRegNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCommercialRegNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCommercialRegNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCommercialRegNo.Depth = 0;
            this.txtCommercialRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCommercialRegNo.HideSelection = false;
            this.txtCommercialRegNo.LeadingIcon = null;
            this.txtCommercialRegNo.Location = new System.Drawing.Point(613, 471);
            this.txtCommercialRegNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCommercialRegNo.MaxLength = 50;
            this.txtCommercialRegNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCommercialRegNo.Name = "txtCommercialRegNo";
            this.txtCommercialRegNo.PasswordChar = '\0';
            this.txtCommercialRegNo.PrefixSuffixText = null;
            this.txtCommercialRegNo.ReadOnly = false;
            this.txtCommercialRegNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCommercialRegNo.SelectedText = "";
            this.txtCommercialRegNo.SelectionLength = 0;
            this.txtCommercialRegNo.SelectionStart = 0;
            this.txtCommercialRegNo.ShortcutsEnabled = true;
            this.txtCommercialRegNo.Size = new System.Drawing.Size(587, 36);
            this.txtCommercialRegNo.TabIndex = 14;
            this.txtCommercialRegNo.TabStop = false;
            this.txtCommercialRegNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCommercialRegNo.TrailingIcon = null;
            this.txtCommercialRegNo.UseSystemPasswordChar = false;
            this.txtCommercialRegNo.UseTallSize = false;
            // 
            // lblGuarantorWorkPlace
            // 
            this.lblGuarantorWorkPlace.AutoSize = true;
            this.lblGuarantorWorkPlace.Depth = 0;
            this.lblGuarantorWorkPlace.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGuarantorWorkPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGuarantorWorkPlace.Location = new System.Drawing.Point(470, 385);
            this.lblGuarantorWorkPlace.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGuarantorWorkPlace.Name = "lblGuarantorWorkPlace";
            this.lblGuarantorWorkPlace.Size = new System.Drawing.Size(102, 17);
            this.lblGuarantorWorkPlace.TabIndex = 27;
            this.lblGuarantorWorkPlace.Text = "جهة عمل الكفيل:";
            // 
            // txtGuarantorWorkPlace
            // 
            this.txtGuarantorWorkPlace.AnimateReadOnly = false;
            this.txtGuarantorWorkPlace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtGuarantorWorkPlace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtGuarantorWorkPlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtGuarantorWorkPlace.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtGuarantorWorkPlace.Depth = 0;
            this.txtGuarantorWorkPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGuarantorWorkPlace.HideSelection = false;
            this.txtGuarantorWorkPlace.LeadingIcon = null;
            this.txtGuarantorWorkPlace.Location = new System.Drawing.Point(0, 406);
            this.txtGuarantorWorkPlace.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuarantorWorkPlace.MaxLength = 200;
            this.txtGuarantorWorkPlace.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGuarantorWorkPlace.Name = "txtGuarantorWorkPlace";
            this.txtGuarantorWorkPlace.PasswordChar = '\0';
            this.txtGuarantorWorkPlace.PrefixSuffixText = null;
            this.txtGuarantorWorkPlace.ReadOnly = false;
            this.txtGuarantorWorkPlace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGuarantorWorkPlace.SelectedText = "";
            this.txtGuarantorWorkPlace.SelectionLength = 0;
            this.txtGuarantorWorkPlace.SelectionStart = 0;
            this.txtGuarantorWorkPlace.ShortcutsEnabled = true;
            this.txtGuarantorWorkPlace.Size = new System.Drawing.Size(587, 36);
            this.txtGuarantorWorkPlace.TabIndex = 13;
            this.txtGuarantorWorkPlace.TabStop = false;
            this.txtGuarantorWorkPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGuarantorWorkPlace.TrailingIcon = null;
            this.txtGuarantorWorkPlace.UseSystemPasswordChar = false;
            this.txtGuarantorWorkPlace.UseTallSize = false;
            // 
            // lblGuarantorMobile
            // 
            this.lblGuarantorMobile.AutoSize = true;
            this.lblGuarantorMobile.Depth = 0;
            this.lblGuarantorMobile.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGuarantorMobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGuarantorMobile.Location = new System.Drawing.Point(1092, 385);
            this.lblGuarantorMobile.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGuarantorMobile.Name = "lblGuarantorMobile";
            this.lblGuarantorMobile.Size = new System.Drawing.Size(77, 17);
            this.lblGuarantorMobile.TabIndex = 25;
            this.lblGuarantorMobile.Text = "جوال الكفيل:";
            // 
            // txtGuarantorMobile
            // 
            this.txtGuarantorMobile.AnimateReadOnly = false;
            this.txtGuarantorMobile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtGuarantorMobile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtGuarantorMobile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtGuarantorMobile.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtGuarantorMobile.Depth = 0;
            this.txtGuarantorMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGuarantorMobile.HideSelection = false;
            this.txtGuarantorMobile.LeadingIcon = null;
            this.txtGuarantorMobile.Location = new System.Drawing.Point(613, 406);
            this.txtGuarantorMobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuarantorMobile.MaxLength = 30;
            this.txtGuarantorMobile.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGuarantorMobile.Name = "txtGuarantorMobile";
            this.txtGuarantorMobile.PasswordChar = '\0';
            this.txtGuarantorMobile.PrefixSuffixText = null;
            this.txtGuarantorMobile.ReadOnly = false;
            this.txtGuarantorMobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGuarantorMobile.SelectedText = "";
            this.txtGuarantorMobile.SelectionLength = 0;
            this.txtGuarantorMobile.SelectionStart = 0;
            this.txtGuarantorMobile.ShortcutsEnabled = true;
            this.txtGuarantorMobile.Size = new System.Drawing.Size(587, 36);
            this.txtGuarantorMobile.TabIndex = 12;
            this.txtGuarantorMobile.TabStop = false;
            this.txtGuarantorMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGuarantorMobile.TrailingIcon = null;
            this.txtGuarantorMobile.UseSystemPasswordChar = false;
            this.txtGuarantorMobile.UseTallSize = false;
            // 
            // lblGuarantorNationalId
            // 
            this.lblGuarantorNationalId.AutoSize = true;
            this.lblGuarantorNationalId.Depth = 0;
            this.lblGuarantorNationalId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGuarantorNationalId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGuarantorNationalId.Location = new System.Drawing.Point(470, 320);
            this.lblGuarantorNationalId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGuarantorNationalId.Name = "lblGuarantorNationalId";
            this.lblGuarantorNationalId.Size = new System.Drawing.Size(105, 17);
            this.lblGuarantorNationalId.TabIndex = 23;
            this.lblGuarantorNationalId.Text = "رقم هوية الكفيل:";
            // 
            // txtGuarantorNationalId
            // 
            this.txtGuarantorNationalId.AnimateReadOnly = false;
            this.txtGuarantorNationalId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtGuarantorNationalId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtGuarantorNationalId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtGuarantorNationalId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtGuarantorNationalId.Depth = 0;
            this.txtGuarantorNationalId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGuarantorNationalId.HideSelection = false;
            this.txtGuarantorNationalId.LeadingIcon = null;
            this.txtGuarantorNationalId.Location = new System.Drawing.Point(0, 341);
            this.txtGuarantorNationalId.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuarantorNationalId.MaxLength = 50;
            this.txtGuarantorNationalId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGuarantorNationalId.Name = "txtGuarantorNationalId";
            this.txtGuarantorNationalId.PasswordChar = '\0';
            this.txtGuarantorNationalId.PrefixSuffixText = null;
            this.txtGuarantorNationalId.ReadOnly = false;
            this.txtGuarantorNationalId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGuarantorNationalId.SelectedText = "";
            this.txtGuarantorNationalId.SelectionLength = 0;
            this.txtGuarantorNationalId.SelectionStart = 0;
            this.txtGuarantorNationalId.ShortcutsEnabled = true;
            this.txtGuarantorNationalId.Size = new System.Drawing.Size(587, 36);
            this.txtGuarantorNationalId.TabIndex = 11;
            this.txtGuarantorNationalId.TabStop = false;
            this.txtGuarantorNationalId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGuarantorNationalId.TrailingIcon = null;
            this.txtGuarantorNationalId.UseSystemPasswordChar = false;
            this.txtGuarantorNationalId.UseTallSize = false;
            // 
            // lblGuarantorName
            // 
            this.lblGuarantorName.AutoSize = true;
            this.lblGuarantorName.Depth = 0;
            this.lblGuarantorName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGuarantorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGuarantorName.Location = new System.Drawing.Point(1092, 320);
            this.lblGuarantorName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGuarantorName.Name = "lblGuarantorName";
            this.lblGuarantorName.Size = new System.Drawing.Size(74, 17);
            this.lblGuarantorName.TabIndex = 21;
            this.lblGuarantorName.Text = "اسم الكفيل:";
            // 
            // txtGuarantorName
            // 
            this.txtGuarantorName.AnimateReadOnly = false;
            this.txtGuarantorName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtGuarantorName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtGuarantorName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtGuarantorName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtGuarantorName.Depth = 0;
            this.txtGuarantorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGuarantorName.HideSelection = false;
            this.txtGuarantorName.LeadingIcon = null;
            this.txtGuarantorName.Location = new System.Drawing.Point(613, 341);
            this.txtGuarantorName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuarantorName.MaxLength = 200;
            this.txtGuarantorName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGuarantorName.Name = "txtGuarantorName";
            this.txtGuarantorName.PasswordChar = '\0';
            this.txtGuarantorName.PrefixSuffixText = null;
            this.txtGuarantorName.ReadOnly = false;
            this.txtGuarantorName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGuarantorName.SelectedText = "";
            this.txtGuarantorName.SelectionLength = 0;
            this.txtGuarantorName.SelectionStart = 0;
            this.txtGuarantorName.ShortcutsEnabled = true;
            this.txtGuarantorName.Size = new System.Drawing.Size(587, 36);
            this.txtGuarantorName.TabIndex = 10;
            this.txtGuarantorName.TabStop = false;
            this.txtGuarantorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGuarantorName.TrailingIcon = null;
            this.txtGuarantorName.UseSystemPasswordChar = false;
            this.txtGuarantorName.UseTallSize = false;
            // 
            // lblTenantStatus
            // 
            this.lblTenantStatus.AutoSize = true;
            this.lblTenantStatus.Depth = 0;
            this.lblTenantStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTenantStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTenantStatus.Location = new System.Drawing.Point(470, 255);
            this.lblTenantStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTenantStatus.Name = "lblTenantStatus";
            this.lblTenantStatus.Size = new System.Drawing.Size(88, 17);
            this.lblTenantStatus.TabIndex = 19;
            this.lblTenantStatus.Text = "حالة المستأجر:";
            // 
            // cmbTenantStatus
            // 
            this.cmbTenantStatus.AutoResize = false;
            this.cmbTenantStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTenantStatus.Depth = 0;
            this.cmbTenantStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTenantStatus.DropDownHeight = 174;
            this.cmbTenantStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenantStatus.DropDownWidth = 121;
            this.cmbTenantStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbTenantStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTenantStatus.FormattingEnabled = true;
            this.cmbTenantStatus.IntegralHeight = false;
            this.cmbTenantStatus.ItemHeight = 43;
            this.cmbTenantStatus.Items.AddRange(new object[] {
            "نشط",
            "غير نشط",
            "محظور",
            "معلق"});
            this.cmbTenantStatus.Location = new System.Drawing.Point(0, 276);
            this.cmbTenantStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTenantStatus.MaxDropDownItems = 4;
            this.cmbTenantStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTenantStatus.Name = "cmbTenantStatus";
            this.cmbTenantStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbTenantStatus.Size = new System.Drawing.Size(587, 49);
            this.cmbTenantStatus.StartIndex = 0;
            this.cmbTenantStatus.TabIndex = 9;
            // 
            // lblWorkPlace
            // 
            this.lblWorkPlace.AutoSize = true;
            this.lblWorkPlace.Depth = 0;
            this.lblWorkPlace.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWorkPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWorkPlace.Location = new System.Drawing.Point(1092, 255);
            this.lblWorkPlace.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWorkPlace.Name = "lblWorkPlace";
            this.lblWorkPlace.Size = new System.Drawing.Size(65, 17);
            this.lblWorkPlace.TabIndex = 17;
            this.lblWorkPlace.Text = "جهة العمل:";
            // 
            // txtWorkPlace
            // 
            this.txtWorkPlace.AnimateReadOnly = false;
            this.txtWorkPlace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtWorkPlace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtWorkPlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtWorkPlace.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtWorkPlace.Depth = 0;
            this.txtWorkPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtWorkPlace.HideSelection = false;
            this.txtWorkPlace.LeadingIcon = null;
            this.txtWorkPlace.Location = new System.Drawing.Point(613, 276);
            this.txtWorkPlace.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkPlace.MaxLength = 200;
            this.txtWorkPlace.MouseState = MaterialSkin.MouseState.OUT;
            this.txtWorkPlace.Name = "txtWorkPlace";
            this.txtWorkPlace.PasswordChar = '\0';
            this.txtWorkPlace.PrefixSuffixText = null;
            this.txtWorkPlace.ReadOnly = false;
            this.txtWorkPlace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtWorkPlace.SelectedText = "";
            this.txtWorkPlace.SelectionLength = 0;
            this.txtWorkPlace.SelectionStart = 0;
            this.txtWorkPlace.ShortcutsEnabled = true;
            this.txtWorkPlace.Size = new System.Drawing.Size(587, 36);
            this.txtWorkPlace.TabIndex = 8;
            this.txtWorkPlace.TabStop = false;
            this.txtWorkPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWorkPlace.TrailingIcon = null;
            this.txtWorkPlace.UseSystemPasswordChar = false;
            this.txtWorkPlace.UseTallSize = false;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Depth = 0;
            this.lblJobTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblJobTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblJobTitle.Location = new System.Drawing.Point(470, 190);
            this.lblJobTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(107, 17);
            this.lblJobTitle.TabIndex = 15;
            this.lblJobTitle.Text = "المسمى الوظيفي:";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.AnimateReadOnly = false;
            this.txtJobTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtJobTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtJobTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtJobTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtJobTitle.Depth = 0;
            this.txtJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtJobTitle.HideSelection = false;
            this.txtJobTitle.LeadingIcon = null;
            this.txtJobTitle.Location = new System.Drawing.Point(0, 211);
            this.txtJobTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtJobTitle.MaxLength = 100;
            this.txtJobTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.PasswordChar = '\0';
            this.txtJobTitle.PrefixSuffixText = null;
            this.txtJobTitle.ReadOnly = false;
            this.txtJobTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtJobTitle.SelectedText = "";
            this.txtJobTitle.SelectionLength = 0;
            this.txtJobTitle.SelectionStart = 0;
            this.txtJobTitle.ShortcutsEnabled = true;
            this.txtJobTitle.Size = new System.Drawing.Size(587, 36);
            this.txtJobTitle.TabIndex = 7;
            this.txtJobTitle.TabStop = false;
            this.txtJobTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJobTitle.TrailingIcon = null;
            this.txtJobTitle.UseSystemPasswordChar = false;
            this.txtJobTitle.UseTallSize = false;
            // 
            // lblSocialStatus
            // 
            this.lblSocialStatus.AutoSize = true;
            this.lblSocialStatus.Depth = 0;
            this.lblSocialStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSocialStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSocialStatus.Location = new System.Drawing.Point(1092, 190);
            this.lblSocialStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSocialStatus.Name = "lblSocialStatus";
            this.lblSocialStatus.Size = new System.Drawing.Size(107, 17);
            this.lblSocialStatus.TabIndex = 13;
            this.lblSocialStatus.Text = "الحالة الاجتماعية:";
            // 
            // cmbSocialStatus
            // 
            this.cmbSocialStatus.AutoResize = false;
            this.cmbSocialStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSocialStatus.Depth = 0;
            this.cmbSocialStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSocialStatus.DropDownHeight = 174;
            this.cmbSocialStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSocialStatus.DropDownWidth = 121;
            this.cmbSocialStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbSocialStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSocialStatus.FormattingEnabled = true;
            this.cmbSocialStatus.IntegralHeight = false;
            this.cmbSocialStatus.ItemHeight = 43;
            this.cmbSocialStatus.Items.AddRange(new object[] {
            "أعزب",
            "متزوج",
            "مطلق",
            "أرمل"});
            this.cmbSocialStatus.Location = new System.Drawing.Point(613, 211);
            this.cmbSocialStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSocialStatus.MaxDropDownItems = 4;
            this.cmbSocialStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSocialStatus.Name = "cmbSocialStatus";
            this.cmbSocialStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSocialStatus.Size = new System.Drawing.Size(587, 49);
            this.cmbSocialStatus.StartIndex = 0;
            this.cmbSocialStatus.TabIndex = 6;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Depth = 0;
            this.lblNationality.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNationality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNationality.Location = new System.Drawing.Point(470, 125);
            this.lblNationality.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(54, 17);
            this.lblNationality.TabIndex = 11;
            this.lblNationality.Text = "الجنسية:";
            // 
            // cmbNationality
            // 
            this.cmbNationality.AutoResize = false;
            this.cmbNationality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbNationality.Depth = 0;
            this.cmbNationality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbNationality.DropDownHeight = 174;
            this.cmbNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNationality.DropDownWidth = 121;
            this.cmbNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbNationality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbNationality.FormattingEnabled = true;
            this.cmbNationality.IntegralHeight = false;
            this.cmbNationality.ItemHeight = 43;
            this.cmbNationality.Items.AddRange(new object[] {
            "سعودي",
            "مصري",
            "سوري",
            "أردني",
            "لبناني",
            "فلسطيني",
            "عراقي",
            "يمني",
            "أخرى"});
            this.cmbNationality.Location = new System.Drawing.Point(0, 146);
            this.cmbNationality.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNationality.MaxDropDownItems = 4;
            this.cmbNationality.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbNationality.Name = "cmbNationality";
            this.cmbNationality.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbNationality.Size = new System.Drawing.Size(587, 49);
            this.cmbNationality.StartIndex = 0;
            this.cmbNationality.TabIndex = 5;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Depth = 0;
            this.lblBirthDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBirthDate.Location = new System.Drawing.Point(1092, 125);
            this.lblBirthDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(79, 17);
            this.lblBirthDate.TabIndex = 9;
            this.lblBirthDate.Text = "تاريخ الميلاد:";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CustomFormat = "yyyy-MM-dd";
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(613, 146);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpBirthDate.RightToLeftLayout = true;
            this.dtpBirthDate.Size = new System.Drawing.Size(587, 22);
            this.dtpBirthDate.TabIndex = 4;
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.AutoSize = true;
            this.lblMobileNo.Depth = 0;
            this.lblMobileNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMobileNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMobileNo.Location = new System.Drawing.Point(470, 60);
            this.lblMobileNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(68, 17);
            this.lblMobileNo.TabIndex = 7;
            this.lblMobileNo.Text = "رقم الجوال:";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.AnimateReadOnly = false;
            this.txtMobileNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMobileNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMobileNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMobileNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMobileNo.Depth = 0;
            this.txtMobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMobileNo.HideSelection = false;
            this.txtMobileNo.LeadingIcon = null;
            this.txtMobileNo.Location = new System.Drawing.Point(0, 81);
            this.txtMobileNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMobileNo.MaxLength = 30;
            this.txtMobileNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.PasswordChar = '\0';
            this.txtMobileNo.PrefixSuffixText = null;
            this.txtMobileNo.ReadOnly = false;
            this.txtMobileNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMobileNo.SelectedText = "";
            this.txtMobileNo.SelectionLength = 0;
            this.txtMobileNo.SelectionStart = 0;
            this.txtMobileNo.ShortcutsEnabled = true;
            this.txtMobileNo.Size = new System.Drawing.Size(587, 36);
            this.txtMobileNo.TabIndex = 3;
            this.txtMobileNo.TabStop = false;
            this.txtMobileNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMobileNo.TrailingIcon = null;
            this.txtMobileNo.UseSystemPasswordChar = false;
            this.txtMobileNo.UseTallSize = false;
            // 
            // lblNationalIdNo
            // 
            this.lblNationalIdNo.AutoSize = true;
            this.lblNationalIdNo.Depth = 0;
            this.lblNationalIdNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNationalIdNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNationalIdNo.Location = new System.Drawing.Point(1092, 60);
            this.lblNationalIdNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNationalIdNo.Name = "lblNationalIdNo";
            this.lblNationalIdNo.Size = new System.Drawing.Size(66, 17);
            this.lblNationalIdNo.TabIndex = 5;
            this.lblNationalIdNo.Text = "رقم الهوية:";
            // 
            // txtNationalIdNo
            // 
            this.txtNationalIdNo.AnimateReadOnly = false;
            this.txtNationalIdNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNationalIdNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNationalIdNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNationalIdNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNationalIdNo.Depth = 0;
            this.txtNationalIdNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNationalIdNo.HideSelection = false;
            this.txtNationalIdNo.LeadingIcon = null;
            this.txtNationalIdNo.Location = new System.Drawing.Point(613, 81);
            this.txtNationalIdNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNationalIdNo.MaxLength = 50;
            this.txtNationalIdNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNationalIdNo.Name = "txtNationalIdNo";
            this.txtNationalIdNo.PasswordChar = '\0';
            this.txtNationalIdNo.PrefixSuffixText = null;
            this.txtNationalIdNo.ReadOnly = false;
            this.txtNationalIdNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNationalIdNo.SelectedText = "";
            this.txtNationalIdNo.SelectionLength = 0;
            this.txtNationalIdNo.SelectionStart = 0;
            this.txtNationalIdNo.ShortcutsEnabled = true;
            this.txtNationalIdNo.Size = new System.Drawing.Size(587, 36);
            this.txtNationalIdNo.TabIndex = 2;
            this.txtNationalIdNo.TabStop = false;
            this.txtNationalIdNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNationalIdNo.TrailingIcon = null;
            this.txtNationalIdNo.UseSystemPasswordChar = false;
            this.txtNationalIdNo.UseTallSize = false;
            // 
            // lblTenantName
            // 
            this.lblTenantName.AutoSize = true;
            this.lblTenantName.Depth = 0;
            this.lblTenantName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTenantName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTenantName.Location = new System.Drawing.Point(470, 0);
            this.lblTenantName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTenantName.Name = "lblTenantName";
            this.lblTenantName.Size = new System.Drawing.Size(89, 17);
            this.lblTenantName.TabIndex = 3;
            this.lblTenantName.Text = "اسم المستأجر:";
            // 
            // txtTenantName
            // 
            this.txtTenantName.AnimateReadOnly = false;
            this.txtTenantName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTenantName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTenantName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTenantName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenantName.Depth = 0;
            this.txtTenantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenantName.HideSelection = true;
            this.txtTenantName.LeadingIcon = null;
            this.txtTenantName.Location = new System.Drawing.Point(0, 21);
            this.txtTenantName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenantName.MaxLength = 200;
            this.txtTenantName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenantName.Name = "txtTenantName";
            this.txtTenantName.PasswordChar = '\0';
            this.txtTenantName.PrefixSuffixText = null;
            this.txtTenantName.ReadOnly = false;
            this.txtTenantName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTenantName.SelectedText = "";
            this.txtTenantName.SelectionLength = 0;
            this.txtTenantName.SelectionStart = 0;
            this.txtTenantName.ShortcutsEnabled = true;
            this.txtTenantName.Size = new System.Drawing.Size(587, 36);
            this.txtTenantName.TabIndex = 1;
            this.txtTenantName.TabStop = false;
            this.txtTenantName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTenantName.TrailingIcon = null;
            this.txtTenantName.UseSystemPasswordChar = false;
            this.txtTenantName.UseTallSize = false;
            // 
            // lblTenantNo
            // 
            this.lblTenantNo.AutoSize = true;
            this.lblTenantNo.Depth = 0;
            this.lblTenantNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTenantNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTenantNo.Location = new System.Drawing.Point(1089, 0);
            this.lblTenantNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTenantNo.Name = "lblTenantNo";
            this.lblTenantNo.Size = new System.Drawing.Size(84, 17);
            this.lblTenantNo.TabIndex = 1;
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
            this.txtTenantNo.HideSelection = true;
            this.txtTenantNo.LeadingIcon = null;
            this.txtTenantNo.Location = new System.Drawing.Point(613, 21);
            this.txtTenantNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenantNo.MaxLength = 50;
            this.txtTenantNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenantNo.Name = "txtTenantNo";
            this.txtTenantNo.PasswordChar = '\0';
            this.txtTenantNo.PrefixSuffixText = null;
            this.txtTenantNo.ReadOnly = false;
            this.txtTenantNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenantNo.SelectedText = "";
            this.txtTenantNo.SelectionLength = 0;
            this.txtTenantNo.SelectionStart = 0;
            this.txtTenantNo.ShortcutsEnabled = true;
            this.txtTenantNo.Size = new System.Drawing.Size(587, 36);
            this.txtTenantNo.TabIndex = 0;
            this.txtTenantNo.TabStop = false;
            this.txtTenantNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTenantNo.TrailingIcon = null;
            this.txtTenantNo.UseSystemPasswordChar = false;
            this.txtTenantNo.UseTallSize = false;
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.White;
            this.pnlDataGrid.Controls.Add(this.dgvTenants);
            this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGrid.Location = new System.Drawing.Point(0, 974);
            this.pnlDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlDataGrid.Size = new System.Drawing.Size(1267, 357);
            this.pnlDataGrid.TabIndex = 2;
            // 
            // dgvTenants
            // 
            this.dgvTenants.AllowUserToAddRows = false;
            this.dgvTenants.AllowUserToDeleteRows = false;
            this.dgvTenants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTenants.BackgroundColor = System.Drawing.Color.White;
            this.dgvTenants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTenants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTenants.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvTenants.Location = new System.Drawing.Point(27, 25);
            this.dgvTenants.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTenants.MultiSelect = false;
            this.dgvTenants.Name = "dgvTenants";
            this.dgvTenants.ReadOnly = true;
            this.dgvTenants.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTenants.RowHeadersWidth = 51;
            this.dgvTenants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTenants.Size = new System.Drawing.Size(1213, 307);
            this.dgvTenants.TabIndex = 0;
            // 
            // UC_Tenants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Tenants";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1267, 1331);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlFields.ResumeLayout(false);
            this.pnlFields.PerformLayout();
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlFields;
        private MaterialSkin.Controls.MaterialTextBox2 txtTenantNo;
        private MaterialSkin.Controls.MaterialTextBox2 txtTenantName;
        private MaterialSkin.Controls.MaterialTextBox2 txtNationalIdNo;
        private MaterialSkin.Controls.MaterialTextBox2 txtMobileNo;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private MaterialSkin.Controls.MaterialComboBox cmbNationality;
        private MaterialSkin.Controls.MaterialComboBox cmbSocialStatus;
        private MaterialSkin.Controls.MaterialTextBox2 txtJobTitle;
        private MaterialSkin.Controls.MaterialTextBox2 txtWorkPlace;
        private MaterialSkin.Controls.MaterialComboBox cmbTenantStatus;
        private MaterialSkin.Controls.MaterialTextBox2 txtGuarantorName;
        private MaterialSkin.Controls.MaterialTextBox2 txtGuarantorNationalId;
        private MaterialSkin.Controls.MaterialTextBox2 txtGuarantorMobile;
        private MaterialSkin.Controls.MaterialTextBox2 txtGuarantorWorkPlace;
        private MaterialSkin.Controls.MaterialTextBox2 txtCommercialRegNo;
        private MaterialSkin.Controls.MaterialLabel lblTenantNo;
        private MaterialSkin.Controls.MaterialLabel lblTenantName;
        private MaterialSkin.Controls.MaterialLabel lblNationalIdNo;
        private MaterialSkin.Controls.MaterialLabel lblMobileNo;
        private MaterialSkin.Controls.MaterialLabel lblBirthDate;
        private MaterialSkin.Controls.MaterialLabel lblNationality;
        private MaterialSkin.Controls.MaterialLabel lblSocialStatus;
        private MaterialSkin.Controls.MaterialLabel lblJobTitle;
        private MaterialSkin.Controls.MaterialLabel lblWorkPlace;
        private MaterialSkin.Controls.MaterialLabel lblTenantStatus;
        private MaterialSkin.Controls.MaterialLabel lblGuarantorName;
        private MaterialSkin.Controls.MaterialLabel lblGuarantorNationalId;
        private MaterialSkin.Controls.MaterialLabel lblGuarantorMobile;
        private MaterialSkin.Controls.MaterialLabel lblGuarantorWorkPlace;
        private MaterialSkin.Controls.MaterialLabel lblCommercialRegNo;
        private System.Windows.Forms.Panel pnlButtons;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dgvTenants;
    }
}
