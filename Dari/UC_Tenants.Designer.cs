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
            this.pnlIdImage = new System.Windows.Forms.Panel();
            this.lblIdImage = new MaterialSkin.Controls.MaterialLabel();
            this.lblIdImageName = new MaterialSkin.Controls.MaterialLabel();
            this.btnIdImageUpload = new MaterialSkin.Controls.MaterialButton();
            this.btnIdImageOpen = new MaterialSkin.Controls.MaterialButton();
            this.btnIdImageDelete = new MaterialSkin.Controls.MaterialButton();
            this.pnlContractImage = new System.Windows.Forms.Panel();
            this.lblContractImage = new MaterialSkin.Controls.MaterialLabel();
            this.lblContractImageName = new MaterialSkin.Controls.MaterialLabel();
            this.btnContractImageUpload = new MaterialSkin.Controls.MaterialButton();
            this.btnContractImageOpen = new MaterialSkin.Controls.MaterialButton();
            this.btnContractImageDelete = new MaterialSkin.Controls.MaterialButton();
            this.pnlGuaranteeImage = new System.Windows.Forms.Panel();
            this.lblGuaranteeImage = new MaterialSkin.Controls.MaterialLabel();
            this.lblGuaranteeImageName = new MaterialSkin.Controls.MaterialLabel();
            this.btnGuaranteeImageUpload = new MaterialSkin.Controls.MaterialButton();
            this.btnGuaranteeImageOpen = new MaterialSkin.Controls.MaterialButton();
            this.btnGuaranteeImageDelete = new MaterialSkin.Controls.MaterialButton();
            this.pnlGuarantorIdImage = new System.Windows.Forms.Panel();
            this.lblGuarantorIdImage = new MaterialSkin.Controls.MaterialLabel();
            this.lblGuarantorIdImageName = new MaterialSkin.Controls.MaterialLabel();
            this.btnGuarantorIdImageUpload = new MaterialSkin.Controls.MaterialButton();
            this.btnGuarantorIdImageOpen = new MaterialSkin.Controls.MaterialButton();
            this.btnGuarantorIdImageDelete = new MaterialSkin.Controls.MaterialButton();
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
            this.pnlIdImage.SuspendLayout();
            this.pnlContractImage.SuspendLayout();
            this.pnlGuaranteeImage.SuspendLayout();
            this.pnlGuarantorIdImage.SuspendLayout();
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
            this.pnlButtons.Location = new System.Drawing.Point(22, 713);
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
            this.pnlFields.Controls.Add(this.pnlIdImage);
            this.pnlFields.Controls.Add(this.pnlContractImage);
            this.pnlFields.Controls.Add(this.pnlGuaranteeImage);
            this.pnlFields.Controls.Add(this.pnlGuarantorIdImage);
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
            this.pnlFields.Size = new System.Drawing.Size(1213, 680);
            this.pnlFields.TabIndex = 0;
            // 
            // pnlIdImage
            // 
            this.pnlIdImage.Controls.Add(this.lblIdImage);
            this.pnlIdImage.Controls.Add(this.lblIdImageName);
            this.pnlIdImage.Controls.Add(this.btnIdImageUpload);
            this.pnlIdImage.Controls.Add(this.btnIdImageOpen);
            this.pnlIdImage.Controls.Add(this.btnIdImageDelete);
            this.pnlIdImage.Location = new System.Drawing.Point(613, 520);
            this.pnlIdImage.Name = "pnlIdImage";
            this.pnlIdImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlIdImage.Size = new System.Drawing.Size(587, 60);
            this.pnlIdImage.TabIndex = 50;
            // 
            // lblIdImage
            // 
            this.lblIdImage.AutoSize = true;
            this.lblIdImage.Depth = 0;
            this.lblIdImage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIdImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdImage.Location = new System.Drawing.Point(479, 0);
            this.lblIdImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdImage.Name = "lblIdImage";
            this.lblIdImage.Size = new System.Drawing.Size(75, 17);
            this.lblIdImage.TabIndex = 30;
            this.lblIdImage.Text = "صورة الهوية:";
            // 
            // lblIdImageName
            // 
            this.lblIdImageName.AutoSize = true;
            this.lblIdImageName.Depth = 0;
            this.lblIdImageName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIdImageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIdImageName.Location = new System.Drawing.Point(0, 21);
            this.lblIdImageName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdImageName.Name = "lblIdImageName";
            this.lblIdImageName.Size = new System.Drawing.Size(1, 0);
            this.lblIdImageName.TabIndex = 31;
            // 
            // btnIdImageUpload
            // 
            this.btnIdImageUpload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIdImageUpload.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIdImageUpload.Depth = 0;
            this.btnIdImageUpload.HighEmphasis = true;
            this.btnIdImageUpload.Icon = null;
            this.btnIdImageUpload.Location = new System.Drawing.Point(300, 16);
            this.btnIdImageUpload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIdImageUpload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIdImageUpload.Name = "btnIdImageUpload";
            this.btnIdImageUpload.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIdImageUpload.Size = new System.Drawing.Size(64, 36);
            this.btnIdImageUpload.TabIndex = 32;
            this.btnIdImageUpload.Text = "رفع";
            this.btnIdImageUpload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnIdImageUpload.UseAccentColor = false;
            this.btnIdImageUpload.UseVisualStyleBackColor = true;
            // 
            // btnIdImageOpen
            // 
            this.btnIdImageOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIdImageOpen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIdImageOpen.Depth = 0;
            this.btnIdImageOpen.HighEmphasis = true;
            this.btnIdImageOpen.Icon = null;
            this.btnIdImageOpen.Location = new System.Drawing.Point(370, 16);
            this.btnIdImageOpen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIdImageOpen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIdImageOpen.Name = "btnIdImageOpen";
            this.btnIdImageOpen.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIdImageOpen.Size = new System.Drawing.Size(64, 36);
            this.btnIdImageOpen.TabIndex = 33;
            this.btnIdImageOpen.Text = "فتح";
            this.btnIdImageOpen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnIdImageOpen.UseAccentColor = false;
            this.btnIdImageOpen.UseVisualStyleBackColor = true;
            // 
            // btnIdImageDelete
            // 
            this.btnIdImageDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIdImageDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIdImageDelete.Depth = 0;
            this.btnIdImageDelete.HighEmphasis = true;
            this.btnIdImageDelete.Icon = null;
            this.btnIdImageDelete.Location = new System.Drawing.Point(440, 16);
            this.btnIdImageDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIdImageDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIdImageDelete.Name = "btnIdImageDelete";
            this.btnIdImageDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIdImageDelete.Size = new System.Drawing.Size(64, 36);
            this.btnIdImageDelete.TabIndex = 34;
            this.btnIdImageDelete.Text = "حذف";
            this.btnIdImageDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnIdImageDelete.UseAccentColor = false;
            this.btnIdImageDelete.UseVisualStyleBackColor = true;
            // 
            // pnlContractImage
            // 
            this.pnlContractImage.Controls.Add(this.lblContractImage);
            this.pnlContractImage.Controls.Add(this.lblContractImageName);
            this.pnlContractImage.Controls.Add(this.btnContractImageUpload);
            this.pnlContractImage.Controls.Add(this.btnContractImageOpen);
            this.pnlContractImage.Controls.Add(this.btnContractImageDelete);
            this.pnlContractImage.Location = new System.Drawing.Point(0, 520);
            this.pnlContractImage.Name = "pnlContractImage";
            this.pnlContractImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlContractImage.Size = new System.Drawing.Size(587, 60);
            this.pnlContractImage.TabIndex = 51;
            // 
            // lblContractImage
            // 
            this.lblContractImage.AutoSize = true;
            this.lblContractImage.Depth = 0;
            this.lblContractImage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblContractImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblContractImage.Location = new System.Drawing.Point(479, 0);
            this.lblContractImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContractImage.Name = "lblContractImage";
            this.lblContractImage.Size = new System.Drawing.Size(69, 17);
            this.lblContractImage.TabIndex = 35;
            this.lblContractImage.Text = "صورة العقد:";
            // 
            // lblContractImageName
            // 
            this.lblContractImageName.AutoSize = true;
            this.lblContractImageName.Depth = 0;
            this.lblContractImageName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblContractImageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblContractImageName.Location = new System.Drawing.Point(0, 21);
            this.lblContractImageName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContractImageName.Name = "lblContractImageName";
            this.lblContractImageName.Size = new System.Drawing.Size(1, 0);
            this.lblContractImageName.TabIndex = 36;
            // 
            // btnContractImageUpload
            // 
            this.btnContractImageUpload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContractImageUpload.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnContractImageUpload.Depth = 0;
            this.btnContractImageUpload.HighEmphasis = true;
            this.btnContractImageUpload.Icon = null;
            this.btnContractImageUpload.Location = new System.Drawing.Point(300, 16);
            this.btnContractImageUpload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnContractImageUpload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnContractImageUpload.Name = "btnContractImageUpload";
            this.btnContractImageUpload.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnContractImageUpload.Size = new System.Drawing.Size(64, 36);
            this.btnContractImageUpload.TabIndex = 37;
            this.btnContractImageUpload.Text = "رفع";
            this.btnContractImageUpload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnContractImageUpload.UseAccentColor = false;
            this.btnContractImageUpload.UseVisualStyleBackColor = true;
            // 
            // btnContractImageOpen
            // 
            this.btnContractImageOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContractImageOpen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnContractImageOpen.Depth = 0;
            this.btnContractImageOpen.HighEmphasis = true;
            this.btnContractImageOpen.Icon = null;
            this.btnContractImageOpen.Location = new System.Drawing.Point(370, 16);
            this.btnContractImageOpen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnContractImageOpen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnContractImageOpen.Name = "btnContractImageOpen";
            this.btnContractImageOpen.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnContractImageOpen.Size = new System.Drawing.Size(64, 36);
            this.btnContractImageOpen.TabIndex = 38;
            this.btnContractImageOpen.Text = "فتح";
            this.btnContractImageOpen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnContractImageOpen.UseAccentColor = false;
            this.btnContractImageOpen.UseVisualStyleBackColor = true;
            // 
            // btnContractImageDelete
            // 
            this.btnContractImageDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContractImageDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnContractImageDelete.Depth = 0;
            this.btnContractImageDelete.HighEmphasis = true;
            this.btnContractImageDelete.Icon = null;
            this.btnContractImageDelete.Location = new System.Drawing.Point(440, 16);
            this.btnContractImageDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnContractImageDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnContractImageDelete.Name = "btnContractImageDelete";
            this.btnContractImageDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnContractImageDelete.Size = new System.Drawing.Size(64, 36);
            this.btnContractImageDelete.TabIndex = 39;
            this.btnContractImageDelete.Text = "حذف";
            this.btnContractImageDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnContractImageDelete.UseAccentColor = false;
            this.btnContractImageDelete.UseVisualStyleBackColor = true;
            // 
            // pnlGuaranteeImage
            // 
            this.pnlGuaranteeImage.Controls.Add(this.lblGuaranteeImage);
            this.pnlGuaranteeImage.Controls.Add(this.lblGuaranteeImageName);
            this.pnlGuaranteeImage.Controls.Add(this.btnGuaranteeImageUpload);
            this.pnlGuaranteeImage.Controls.Add(this.btnGuaranteeImageOpen);
            this.pnlGuaranteeImage.Controls.Add(this.btnGuaranteeImageDelete);
            this.pnlGuaranteeImage.Location = new System.Drawing.Point(613, 590);
            this.pnlGuaranteeImage.Name = "pnlGuaranteeImage";
            this.pnlGuaranteeImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlGuaranteeImage.Size = new System.Drawing.Size(587, 60);
            this.pnlGuaranteeImage.TabIndex = 52;
            // 
            // lblGuaranteeImage
            // 
            this.lblGuaranteeImage.AutoSize = true;
            this.lblGuaranteeImage.Depth = 0;
            this.lblGuaranteeImage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGuaranteeImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGuaranteeImage.Location = new System.Drawing.Point(479, 0);
            this.lblGuaranteeImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGuaranteeImage.Name = "lblGuaranteeImage";
            this.lblGuaranteeImage.Size = new System.Drawing.Size(81, 17);
            this.lblGuaranteeImage.TabIndex = 40;
            this.lblGuaranteeImage.Text = "صورة الضمان:";
            // 
            // lblGuaranteeImageName
            // 
            this.lblGuaranteeImageName.AutoSize = true;
            this.lblGuaranteeImageName.Depth = 0;
            this.lblGuaranteeImageName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGuaranteeImageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGuaranteeImageName.Location = new System.Drawing.Point(0, 21);
            this.lblGuaranteeImageName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGuaranteeImageName.Name = "lblGuaranteeImageName";
            this.lblGuaranteeImageName.Size = new System.Drawing.Size(1, 0);
            this.lblGuaranteeImageName.TabIndex = 41;
            // 
            // btnGuaranteeImageUpload
            // 
            this.btnGuaranteeImageUpload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuaranteeImageUpload.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuaranteeImageUpload.Depth = 0;
            this.btnGuaranteeImageUpload.HighEmphasis = true;
            this.btnGuaranteeImageUpload.Icon = null;
            this.btnGuaranteeImageUpload.Location = new System.Drawing.Point(300, 16);
            this.btnGuaranteeImageUpload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuaranteeImageUpload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuaranteeImageUpload.Name = "btnGuaranteeImageUpload";
            this.btnGuaranteeImageUpload.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuaranteeImageUpload.Size = new System.Drawing.Size(64, 36);
            this.btnGuaranteeImageUpload.TabIndex = 42;
            this.btnGuaranteeImageUpload.Text = "رفع";
            this.btnGuaranteeImageUpload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnGuaranteeImageUpload.UseAccentColor = false;
            this.btnGuaranteeImageUpload.UseVisualStyleBackColor = true;
            // 
            // btnGuaranteeImageOpen
            // 
            this.btnGuaranteeImageOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuaranteeImageOpen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuaranteeImageOpen.Depth = 0;
            this.btnGuaranteeImageOpen.HighEmphasis = true;
            this.btnGuaranteeImageOpen.Icon = null;
            this.btnGuaranteeImageOpen.Location = new System.Drawing.Point(370, 16);
            this.btnGuaranteeImageOpen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuaranteeImageOpen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuaranteeImageOpen.Name = "btnGuaranteeImageOpen";
            this.btnGuaranteeImageOpen.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuaranteeImageOpen.Size = new System.Drawing.Size(64, 36);
            this.btnGuaranteeImageOpen.TabIndex = 43;
            this.btnGuaranteeImageOpen.Text = "فتح";
            this.btnGuaranteeImageOpen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnGuaranteeImageOpen.UseAccentColor = false;
            this.btnGuaranteeImageOpen.UseVisualStyleBackColor = true;
            // 
            // btnGuaranteeImageDelete
            // 
            this.btnGuaranteeImageDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuaranteeImageDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuaranteeImageDelete.Depth = 0;
            this.btnGuaranteeImageDelete.HighEmphasis = true;
            this.btnGuaranteeImageDelete.Icon = null;
            this.btnGuaranteeImageDelete.Location = new System.Drawing.Point(440, 16);
            this.btnGuaranteeImageDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuaranteeImageDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuaranteeImageDelete.Name = "btnGuaranteeImageDelete";
            this.btnGuaranteeImageDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuaranteeImageDelete.Size = new System.Drawing.Size(64, 36);
            this.btnGuaranteeImageDelete.TabIndex = 44;
            this.btnGuaranteeImageDelete.Text = "حذف";
            this.btnGuaranteeImageDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnGuaranteeImageDelete.UseAccentColor = false;
            this.btnGuaranteeImageDelete.UseVisualStyleBackColor = true;
            // 
            // pnlGuarantorIdImage
            // 
            this.pnlGuarantorIdImage.Controls.Add(this.lblGuarantorIdImage);
            this.pnlGuarantorIdImage.Controls.Add(this.lblGuarantorIdImageName);
            this.pnlGuarantorIdImage.Controls.Add(this.btnGuarantorIdImageUpload);
            this.pnlGuarantorIdImage.Controls.Add(this.btnGuarantorIdImageOpen);
            this.pnlGuarantorIdImage.Controls.Add(this.btnGuarantorIdImageDelete);
            this.pnlGuarantorIdImage.Location = new System.Drawing.Point(0, 590);
            this.pnlGuarantorIdImage.Name = "pnlGuarantorIdImage";
            this.pnlGuarantorIdImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlGuarantorIdImage.Size = new System.Drawing.Size(587, 60);
            this.pnlGuarantorIdImage.TabIndex = 53;
            // 
            // lblGuarantorIdImage
            // 
            this.lblGuarantorIdImage.AutoSize = true;
            this.lblGuarantorIdImage.Depth = 0;
            this.lblGuarantorIdImage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGuarantorIdImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGuarantorIdImage.Location = new System.Drawing.Point(466, 0);
            this.lblGuarantorIdImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGuarantorIdImage.Name = "lblGuarantorIdImage";
            this.lblGuarantorIdImage.Size = new System.Drawing.Size(117, 17);
            this.lblGuarantorIdImage.TabIndex = 45;
            this.lblGuarantorIdImage.Text = "صورة هوية الضامن:";
            // 
            // lblGuarantorIdImageName
            // 
            this.lblGuarantorIdImageName.AutoSize = true;
            this.lblGuarantorIdImageName.Depth = 0;
            this.lblGuarantorIdImageName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGuarantorIdImageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGuarantorIdImageName.Location = new System.Drawing.Point(0, 21);
            this.lblGuarantorIdImageName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGuarantorIdImageName.Name = "lblGuarantorIdImageName";
            this.lblGuarantorIdImageName.Size = new System.Drawing.Size(1, 0);
            this.lblGuarantorIdImageName.TabIndex = 46;
            // 
            // btnGuarantorIdImageUpload
            // 
            this.btnGuarantorIdImageUpload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuarantorIdImageUpload.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuarantorIdImageUpload.Depth = 0;
            this.btnGuarantorIdImageUpload.HighEmphasis = true;
            this.btnGuarantorIdImageUpload.Icon = null;
            this.btnGuarantorIdImageUpload.Location = new System.Drawing.Point(300, 16);
            this.btnGuarantorIdImageUpload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuarantorIdImageUpload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuarantorIdImageUpload.Name = "btnGuarantorIdImageUpload";
            this.btnGuarantorIdImageUpload.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuarantorIdImageUpload.Size = new System.Drawing.Size(64, 36);
            this.btnGuarantorIdImageUpload.TabIndex = 47;
            this.btnGuarantorIdImageUpload.Text = "رفع";
            this.btnGuarantorIdImageUpload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnGuarantorIdImageUpload.UseAccentColor = false;
            this.btnGuarantorIdImageUpload.UseVisualStyleBackColor = true;
            // 
            // btnGuarantorIdImageOpen
            // 
            this.btnGuarantorIdImageOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuarantorIdImageOpen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuarantorIdImageOpen.Depth = 0;
            this.btnGuarantorIdImageOpen.HighEmphasis = true;
            this.btnGuarantorIdImageOpen.Icon = null;
            this.btnGuarantorIdImageOpen.Location = new System.Drawing.Point(370, 16);
            this.btnGuarantorIdImageOpen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuarantorIdImageOpen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuarantorIdImageOpen.Name = "btnGuarantorIdImageOpen";
            this.btnGuarantorIdImageOpen.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuarantorIdImageOpen.Size = new System.Drawing.Size(64, 36);
            this.btnGuarantorIdImageOpen.TabIndex = 48;
            this.btnGuarantorIdImageOpen.Text = "فتح";
            this.btnGuarantorIdImageOpen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnGuarantorIdImageOpen.UseAccentColor = false;
            this.btnGuarantorIdImageOpen.UseVisualStyleBackColor = true;
            // 
            // btnGuarantorIdImageDelete
            // 
            this.btnGuarantorIdImageDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuarantorIdImageDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuarantorIdImageDelete.Depth = 0;
            this.btnGuarantorIdImageDelete.HighEmphasis = true;
            this.btnGuarantorIdImageDelete.Icon = null;
            this.btnGuarantorIdImageDelete.Location = new System.Drawing.Point(440, 16);
            this.btnGuarantorIdImageDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuarantorIdImageDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuarantorIdImageDelete.Name = "btnGuarantorIdImageDelete";
            this.btnGuarantorIdImageDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuarantorIdImageDelete.Size = new System.Drawing.Size(64, 36);
            this.btnGuarantorIdImageDelete.TabIndex = 49;
            this.btnGuarantorIdImageDelete.Text = "حذف";
            this.btnGuarantorIdImageDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnGuarantorIdImageDelete.UseAccentColor = false;
            this.btnGuarantorIdImageDelete.UseVisualStyleBackColor = true;
            // 
            // lblCommercialRegNo
            // 
            this.lblCommercialRegNo.AutoSize = true;
            this.lblCommercialRegNo.Depth = 0;
            this.lblCommercialRegNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCommercialRegNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCommercialRegNo.Location = new System.Drawing.Point(1067, 450);
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
            this.lblGuarantorWorkPlace.Size = new System.Drawing.Size(105, 17);
            this.lblGuarantorWorkPlace.TabIndex = 27;
            this.lblGuarantorWorkPlace.Text = "جهة عمل الضامن:";
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
            this.lblGuarantorMobile.Size = new System.Drawing.Size(80, 17);
            this.lblGuarantorMobile.TabIndex = 25;
            this.lblGuarantorMobile.Text = "جوال الضامن:";
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
            this.lblGuarantorNationalId.Size = new System.Drawing.Size(108, 17);
            this.lblGuarantorNationalId.TabIndex = 23;
            this.lblGuarantorNationalId.Text = "رقم هوية الضامن:";
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
            this.lblGuarantorName.Size = new System.Drawing.Size(77, 17);
            this.lblGuarantorName.TabIndex = 21;
            this.lblGuarantorName.Text = "اسم الضامن:";
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
            this.lblWorkPlace.Location = new System.Drawing.Point(1110, 255);
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
            this.pnlIdImage.ResumeLayout(false);
            this.pnlIdImage.PerformLayout();
            this.pnlContractImage.ResumeLayout(false);
            this.pnlContractImage.PerformLayout();
            this.pnlGuaranteeImage.ResumeLayout(false);
            this.pnlGuaranteeImage.PerformLayout();
            this.pnlGuarantorIdImage.ResumeLayout(false);
            this.pnlGuarantorIdImage.PerformLayout();
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
        // المرفقات - صورة الهوية
        private MaterialSkin.Controls.MaterialLabel lblIdImage;
        private MaterialSkin.Controls.MaterialLabel lblIdImageName;
        private MaterialSkin.Controls.MaterialButton btnIdImageUpload;
        private MaterialSkin.Controls.MaterialButton btnIdImageOpen;
        private MaterialSkin.Controls.MaterialButton btnIdImageDelete;
        // المرفقات - صورة العقد
        private MaterialSkin.Controls.MaterialLabel lblContractImage;
        private MaterialSkin.Controls.MaterialLabel lblContractImageName;
        private MaterialSkin.Controls.MaterialButton btnContractImageUpload;
        private MaterialSkin.Controls.MaterialButton btnContractImageOpen;
        private MaterialSkin.Controls.MaterialButton btnContractImageDelete;
        // المرفقات - صورة الضمان
        private MaterialSkin.Controls.MaterialLabel lblGuaranteeImage;
        private MaterialSkin.Controls.MaterialLabel lblGuaranteeImageName;
        private MaterialSkin.Controls.MaterialButton btnGuaranteeImageUpload;
        private MaterialSkin.Controls.MaterialButton btnGuaranteeImageOpen;
        private MaterialSkin.Controls.MaterialButton btnGuaranteeImageDelete;
        // المرفقات - صورة هوية الضامن
        private MaterialSkin.Controls.MaterialLabel lblGuarantorIdImage;
        private MaterialSkin.Controls.MaterialLabel lblGuarantorIdImageName;
        private MaterialSkin.Controls.MaterialButton btnGuarantorIdImageUpload;
        private MaterialSkin.Controls.MaterialButton btnGuarantorIdImageOpen;
        private MaterialSkin.Controls.MaterialButton btnGuarantorIdImageDelete;
        // Panels للمرفقات
        private System.Windows.Forms.Panel pnlIdImage;
        private System.Windows.Forms.Panel pnlContractImage;
        private System.Windows.Forms.Panel pnlGuaranteeImage;
        private System.Windows.Forms.Panel pnlGuarantorIdImage;
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
