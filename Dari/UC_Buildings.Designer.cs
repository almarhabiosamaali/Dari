using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Dari
{
    partial class UC_Buildings
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
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnEdit = new MaterialSkin.Controls.MaterialButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.pnlFields = new System.Windows.Forms.Panel();
            this.chkIsActive = new MaterialSkin.Controls.MaterialCheckbox();
            this.lblOwnerNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtOwnerNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblAddress = new MaterialSkin.Controls.MaterialLabel();
            this.txtAddress = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblDescription = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescription = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblPropertyType = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPropertyType = new MaterialSkin.Controls.MaterialComboBox();
            this.lblPropertyName = new MaterialSkin.Controls.MaterialLabel();
            this.txtPropertyName = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblPropertyNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtPropertyNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dgvProperties = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlFields.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlHeader.Size = new System.Drawing.Size(1267, 74);
            this.pnlHeader.TabIndex = 0;
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
            this.lblTitle.Size = new System.Drawing.Size(74, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "بيانات العقار";
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
            this.pnlForm.Size = new System.Drawing.Size(1267, 431);
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
            this.pnlButtons.Location = new System.Drawing.Point(27, 308);
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
            this.pnlFields.Controls.Add(this.chkIsActive);
            this.pnlFields.Controls.Add(this.lblOwnerNo);
            this.pnlFields.Controls.Add(this.txtOwnerNo);
            this.pnlFields.Controls.Add(this.lblAddress);
            this.pnlFields.Controls.Add(this.txtAddress);
            this.pnlFields.Controls.Add(this.lblDescription);
            this.pnlFields.Controls.Add(this.txtDescription);
            this.pnlFields.Controls.Add(this.lblPropertyType);
            this.pnlFields.Controls.Add(this.cmbPropertyType);
            this.pnlFields.Controls.Add(this.lblPropertyName);
            this.pnlFields.Controls.Add(this.txtPropertyName);
            this.pnlFields.Controls.Add(this.lblPropertyNo);
            this.pnlFields.Controls.Add(this.txtPropertyNo);
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFields.Location = new System.Drawing.Point(27, 25);
            this.pnlFields.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlFields.Size = new System.Drawing.Size(1213, 381);
            this.pnlFields.TabIndex = 0;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Depth = 0;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkIsActive.Location = new System.Drawing.Point(1137, 242);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(0);
            this.chkIsActive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkIsActive.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.ReadOnly = false;
            this.chkIsActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkIsActive.Ripple = true;
            this.chkIsActive.Size = new System.Drawing.Size(61, 37);
            this.chkIsActive.TabIndex = 6;
            this.chkIsActive.Text = "نشط";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblOwnerNo
            // 
            this.lblOwnerNo.AutoSize = true;
            this.lblOwnerNo.Depth = 0;
            this.lblOwnerNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblOwnerNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOwnerNo.Location = new System.Drawing.Point(495, 191);
            this.lblOwnerNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOwnerNo.Name = "lblOwnerNo";
            this.lblOwnerNo.Size = new System.Drawing.Size(95, 17);
            this.lblOwnerNo.TabIndex = 7;
            this.lblOwnerNo.Text = "رقم مالك العقار:";
            // 
            // txtOwnerNo
            // 
            this.txtOwnerNo.AnimateReadOnly = false;
            this.txtOwnerNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtOwnerNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtOwnerNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtOwnerNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtOwnerNo.Depth = 0;
            this.txtOwnerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOwnerNo.HideSelection = false;
            this.txtOwnerNo.LeadingIcon = null;
            this.txtOwnerNo.Location = new System.Drawing.Point(0, 212);
            this.txtOwnerNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtOwnerNo.MaxLength = 50;
            this.txtOwnerNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOwnerNo.Name = "txtOwnerNo";
            this.txtOwnerNo.PasswordChar = '\0';
            this.txtOwnerNo.PrefixSuffixText = null;
            this.txtOwnerNo.ReadOnly = false;
            this.txtOwnerNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOwnerNo.SelectedText = "";
            this.txtOwnerNo.SelectionLength = 0;
            this.txtOwnerNo.SelectionStart = 0;
            this.txtOwnerNo.ShortcutsEnabled = true;
            this.txtOwnerNo.Size = new System.Drawing.Size(587, 36);
            this.txtOwnerNo.TabIndex = 5;
            this.txtOwnerNo.TabStop = false;
            this.txtOwnerNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOwnerNo.TrailingIcon = null;
            this.txtOwnerNo.UseSystemPasswordChar = false;
            this.txtOwnerNo.UseTallSize = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Depth = 0;
            this.lblAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddress.Location = new System.Drawing.Point(1156, 191);
            this.lblAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 17);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "العنوان:";
            // 
            // txtAddress
            // 
            this.txtAddress.AnimateReadOnly = false;
            this.txtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAddress.Depth = 0;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddress.HideSelection = true;
            this.txtAddress.LeadingIcon = null;
            this.txtAddress.Location = new System.Drawing.Point(613, 212);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.MaxLength = 300;
            this.txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PrefixSuffixText = null;
            this.txtAddress.ReadOnly = false;
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(587, 36);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.TabStop = false;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAddress.TrailingIcon = null;
            this.txtAddress.UseSystemPasswordChar = false;
            this.txtAddress.UseTallSize = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Depth = 0;
            this.lblDescription.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescription.Location = new System.Drawing.Point(1156, 126);
            this.lblDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(45, 17);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "الوصف:";
            // 
            // txtDescription
            // 
            this.txtDescription.AnimateReadOnly = false;
            this.txtDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescription.Depth = 0;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescription.HideSelection = true;
            this.txtDescription.LeadingIcon = null;
            this.txtDescription.Location = new System.Drawing.Point(0, 147);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.MaxLength = 1000;
            this.txtDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PrefixSuffixText = null;
            this.txtDescription.ReadOnly = false;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(1200, 36);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TabStop = false;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescription.TrailingIcon = null;
            this.txtDescription.UseSystemPasswordChar = false;
            this.txtDescription.UseTallSize = false;
            // 
            // lblPropertyType
            // 
            this.lblPropertyType.AutoSize = true;
            this.lblPropertyType.Depth = 0;
            this.lblPropertyType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPropertyType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPropertyType.Location = new System.Drawing.Point(1143, 53);
            this.lblPropertyType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPropertyType.Name = "lblPropertyType";
            this.lblPropertyType.Size = new System.Drawing.Size(60, 17);
            this.lblPropertyType.TabIndex = 10;
            this.lblPropertyType.Text = "نوع العقار:";
            // 
            // cmbPropertyType
            // 
            this.cmbPropertyType.AutoResize = false;
            this.cmbPropertyType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPropertyType.Depth = 0;
            this.cmbPropertyType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPropertyType.DropDownHeight = 174;
            this.cmbPropertyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPropertyType.DropDownWidth = 121;
            this.cmbPropertyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbPropertyType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPropertyType.FormattingEnabled = true;
            this.cmbPropertyType.IntegralHeight = false;
            this.cmbPropertyType.ItemHeight = 43;
            this.cmbPropertyType.Items.AddRange(new object[] {
            "سكني",
            "تجاري",
            "صناعي",
            "مكتبي",
            "أخرى"});
            this.cmbPropertyType.Location = new System.Drawing.Point(613, 74);
            this.cmbPropertyType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPropertyType.MaxDropDownItems = 4;
            this.cmbPropertyType.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPropertyType.Name = "cmbPropertyType";
            this.cmbPropertyType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbPropertyType.Size = new System.Drawing.Size(585, 49);
            this.cmbPropertyType.StartIndex = 0;
            this.cmbPropertyType.TabIndex = 2;
            // 
            // lblPropertyName
            // 
            this.lblPropertyName.AutoSize = true;
            this.lblPropertyName.Depth = 0;
            this.lblPropertyName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPropertyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPropertyName.Location = new System.Drawing.Point(524, 0);
            this.lblPropertyName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPropertyName.Name = "lblPropertyName";
            this.lblPropertyName.Size = new System.Drawing.Size(66, 17);
            this.lblPropertyName.TabIndex = 11;
            this.lblPropertyName.Text = "اسم العقار:";
            // 
            // txtPropertyName
            // 
            this.txtPropertyName.AnimateReadOnly = false;
            this.txtPropertyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPropertyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPropertyName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPropertyName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPropertyName.Depth = 0;
            this.txtPropertyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPropertyName.HideSelection = true;
            this.txtPropertyName.LeadingIcon = null;
            this.txtPropertyName.Location = new System.Drawing.Point(4, 21);
            this.txtPropertyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropertyName.MaxLength = 200;
            this.txtPropertyName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPropertyName.Name = "txtPropertyName";
            this.txtPropertyName.PasswordChar = '\0';
            this.txtPropertyName.PrefixSuffixText = null;
            this.txtPropertyName.ReadOnly = false;
            this.txtPropertyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPropertyName.SelectedText = "";
            this.txtPropertyName.SelectionLength = 0;
            this.txtPropertyName.SelectionStart = 0;
            this.txtPropertyName.ShortcutsEnabled = true;
            this.txtPropertyName.Size = new System.Drawing.Size(587, 36);
            this.txtPropertyName.TabIndex = 1;
            this.txtPropertyName.TabStop = false;
            this.txtPropertyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPropertyName.TrailingIcon = null;
            this.txtPropertyName.UseSystemPasswordChar = false;
            this.txtPropertyName.UseTallSize = false;
            // 
            // lblPropertyNo
            // 
            this.lblPropertyNo.AutoSize = true;
            this.lblPropertyNo.Depth = 0;
            this.lblPropertyNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPropertyNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPropertyNo.Location = new System.Drawing.Point(1140, 0);
            this.lblPropertyNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPropertyNo.Name = "lblPropertyNo";
            this.lblPropertyNo.Size = new System.Drawing.Size(61, 17);
            this.lblPropertyNo.TabIndex = 12;
            this.lblPropertyNo.Text = "رقم العقار:";
            // 
            // txtPropertyNo
            // 
            this.txtPropertyNo.AnimateReadOnly = false;
            this.txtPropertyNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPropertyNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPropertyNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPropertyNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPropertyNo.Depth = 0;
            this.txtPropertyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPropertyNo.HideSelection = true;
            this.txtPropertyNo.LeadingIcon = null;
            this.txtPropertyNo.Location = new System.Drawing.Point(613, 21);
            this.txtPropertyNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropertyNo.MaxLength = 50;
            this.txtPropertyNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPropertyNo.Name = "txtPropertyNo";
            this.txtPropertyNo.PasswordChar = '\0';
            this.txtPropertyNo.PrefixSuffixText = null;
            this.txtPropertyNo.ReadOnly = false;
            this.txtPropertyNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPropertyNo.SelectedText = "";
            this.txtPropertyNo.SelectionLength = 0;
            this.txtPropertyNo.SelectionStart = 0;
            this.txtPropertyNo.ShortcutsEnabled = true;
            this.txtPropertyNo.Size = new System.Drawing.Size(587, 36);
            this.txtPropertyNo.TabIndex = 0;
            this.txtPropertyNo.TabStop = false;
            this.txtPropertyNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPropertyNo.TrailingIcon = null;
            this.txtPropertyNo.UseSystemPasswordChar = false;
            this.txtPropertyNo.UseTallSize = false;
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.White;
            this.pnlDataGrid.Controls.Add(this.dgvProperties);
            this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGrid.Location = new System.Drawing.Point(0, 505);
            this.pnlDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlDataGrid.Size = new System.Drawing.Size(1267, 357);
            this.pnlDataGrid.TabIndex = 2;
            // 
            // dgvProperties
            // 
            this.dgvProperties.AllowUserToAddRows = false;
            this.dgvProperties.AllowUserToDeleteRows = false;
            this.dgvProperties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProperties.BackgroundColor = System.Drawing.Color.White;
            this.dgvProperties.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProperties.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvProperties.Location = new System.Drawing.Point(27, 25);
            this.dgvProperties.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProperties.MultiSelect = false;
            this.dgvProperties.Name = "dgvProperties";
            this.dgvProperties.ReadOnly = true;
            this.dgvProperties.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvProperties.RowHeadersWidth = 51;
            this.dgvProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProperties.Size = new System.Drawing.Size(1213, 307);
            this.dgvProperties.TabIndex = 0;
            // 
            // UC_Buildings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlDataGrid);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Buildings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1267, 862);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlFields.ResumeLayout(false);
            this.pnlFields.PerformLayout();
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlFields;
        private MaterialSkin.Controls.MaterialTextBox2 txtPropertyNo;
        private MaterialSkin.Controls.MaterialTextBox2 txtPropertyName;
        private MaterialSkin.Controls.MaterialComboBox cmbPropertyType;
        private MaterialSkin.Controls.MaterialTextBox2 txtDescription;
        private MaterialSkin.Controls.MaterialTextBox2 txtAddress;
        private MaterialSkin.Controls.MaterialTextBox2 txtOwnerNo;
        private MaterialSkin.Controls.MaterialCheckbox chkIsActive;
        private MaterialSkin.Controls.MaterialLabel lblPropertyNo;
        private MaterialSkin.Controls.MaterialLabel lblPropertyName;
        private MaterialSkin.Controls.MaterialLabel lblPropertyType;
        private MaterialSkin.Controls.MaterialLabel lblDescription;
        private MaterialSkin.Controls.MaterialLabel lblAddress;
        private MaterialSkin.Controls.MaterialLabel lblOwnerNo;
        private System.Windows.Forms.Panel pnlButtons;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dgvProperties;
    }
}
