using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Dari
{
    partial class UC_Apartments
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
            this.lblFloorNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtFloorNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblBathroomsCount = new MaterialSkin.Controls.MaterialLabel();
            this.txtBathroomsCount = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblKitchensCount = new MaterialSkin.Controls.MaterialLabel();
            this.txtKitchensCount = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblRoomsCount = new MaterialSkin.Controls.MaterialLabel();
            this.txtRoomsCount = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblRentStatus = new MaterialSkin.Controls.MaterialLabel();
            this.cmbRentStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.lblApartmentStatus = new MaterialSkin.Controls.MaterialLabel();
            this.cmbApartmentStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.lblApartmentType = new MaterialSkin.Controls.MaterialLabel();
            this.cmbApartmentType = new MaterialSkin.Controls.MaterialComboBox();
            this.lblAreaSqm = new MaterialSkin.Controls.MaterialLabel();
            this.txtAreaSqm = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblPropertyNo = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPropertyNo = new MaterialSkin.Controls.MaterialComboBox();
            this.lblApartmentNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtApartmentNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dgvApartments = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlFields.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartments)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(81, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "بيانات الشقق";
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
            this.pnlFields.Controls.Add(this.lblFloorNo);
            this.pnlFields.Controls.Add(this.txtFloorNo);
            this.pnlFields.Controls.Add(this.lblBathroomsCount);
            this.pnlFields.Controls.Add(this.txtBathroomsCount);
            this.pnlFields.Controls.Add(this.lblKitchensCount);
            this.pnlFields.Controls.Add(this.txtKitchensCount);
            this.pnlFields.Controls.Add(this.lblRoomsCount);
            this.pnlFields.Controls.Add(this.txtRoomsCount);
            this.pnlFields.Controls.Add(this.lblRentStatus);
            this.pnlFields.Controls.Add(this.cmbRentStatus);
            this.pnlFields.Controls.Add(this.lblApartmentStatus);
            this.pnlFields.Controls.Add(this.cmbApartmentStatus);
            this.pnlFields.Controls.Add(this.lblApartmentType);
            this.pnlFields.Controls.Add(this.cmbApartmentType);
            this.pnlFields.Controls.Add(this.lblAreaSqm);
            this.pnlFields.Controls.Add(this.txtAreaSqm);
            this.pnlFields.Controls.Add(this.lblPropertyNo);
            this.pnlFields.Controls.Add(this.cmbPropertyNo);
            this.pnlFields.Controls.Add(this.lblApartmentNo);
            this.pnlFields.Controls.Add(this.txtApartmentNo);
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFields.Location = new System.Drawing.Point(27, 25);
            this.pnlFields.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlFields.Size = new System.Drawing.Size(1213, 550);
            this.pnlFields.TabIndex = 0;
            // 
            // lblFloorNo
            // 
            this.lblFloorNo.AutoSize = true;
            this.lblFloorNo.Depth = 0;
            this.lblFloorNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFloorNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFloorNo.Location = new System.Drawing.Point(1090, 316);
            this.lblFloorNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFloorNo.Name = "lblFloorNo";
            this.lblFloorNo.Size = new System.Drawing.Size(67, 17);
            this.lblFloorNo.TabIndex = 19;
            this.lblFloorNo.Text = "رقم الطابق:";
            // 
            // txtFloorNo
            // 
            this.txtFloorNo.AnimateReadOnly = false;
            this.txtFloorNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFloorNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFloorNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFloorNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFloorNo.Depth = 0;
            this.txtFloorNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFloorNo.HideSelection = false;
            this.txtFloorNo.LeadingIcon = null;
            this.txtFloorNo.Location = new System.Drawing.Point(613, 341);
            this.txtFloorNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtFloorNo.MaxLength = 10;
            this.txtFloorNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFloorNo.Name = "txtFloorNo";
            this.txtFloorNo.PasswordChar = '\0';
            this.txtFloorNo.PrefixSuffixText = null;
            this.txtFloorNo.ReadOnly = false;
            this.txtFloorNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFloorNo.SelectedText = "";
            this.txtFloorNo.SelectionLength = 0;
            this.txtFloorNo.SelectionStart = 0;
            this.txtFloorNo.ShortcutsEnabled = true;
            this.txtFloorNo.Size = new System.Drawing.Size(587, 36);
            this.txtFloorNo.TabIndex = 9;
            this.txtFloorNo.TabStop = false;
            this.txtFloorNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFloorNo.TrailingIcon = null;
            this.txtFloorNo.UseSystemPasswordChar = false;
            this.txtFloorNo.UseTallSize = false;
            // 
            // lblBathroomsCount
            // 
            this.lblBathroomsCount.AutoSize = true;
            this.lblBathroomsCount.Depth = 0;
            this.lblBathroomsCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBathroomsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBathroomsCount.Location = new System.Drawing.Point(495, 320);
            this.lblBathroomsCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBathroomsCount.Name = "lblBathroomsCount";
            this.lblBathroomsCount.Size = new System.Drawing.Size(87, 17);
            this.lblBathroomsCount.TabIndex = 17;
            this.lblBathroomsCount.Text = "عدد الحمامات:";
            // 
            // txtBathroomsCount
            // 
            this.txtBathroomsCount.AnimateReadOnly = false;
            this.txtBathroomsCount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBathroomsCount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBathroomsCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBathroomsCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBathroomsCount.Depth = 0;
            this.txtBathroomsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBathroomsCount.HideSelection = false;
            this.txtBathroomsCount.LeadingIcon = null;
            this.txtBathroomsCount.Location = new System.Drawing.Point(0, 341);
            this.txtBathroomsCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtBathroomsCount.MaxLength = 10;
            this.txtBathroomsCount.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBathroomsCount.Name = "txtBathroomsCount";
            this.txtBathroomsCount.PasswordChar = '\0';
            this.txtBathroomsCount.PrefixSuffixText = null;
            this.txtBathroomsCount.ReadOnly = false;
            this.txtBathroomsCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBathroomsCount.SelectedText = "";
            this.txtBathroomsCount.SelectionLength = 0;
            this.txtBathroomsCount.SelectionStart = 0;
            this.txtBathroomsCount.ShortcutsEnabled = true;
            this.txtBathroomsCount.Size = new System.Drawing.Size(587, 36);
            this.txtBathroomsCount.TabIndex = 8;
            this.txtBathroomsCount.TabStop = false;
            this.txtBathroomsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBathroomsCount.TrailingIcon = null;
            this.txtBathroomsCount.UseSystemPasswordChar = false;
            this.txtBathroomsCount.UseTallSize = false;
            // 
            // lblKitchensCount
            // 
            this.lblKitchensCount.AutoSize = true;
            this.lblKitchensCount.Depth = 0;
            this.lblKitchensCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblKitchensCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKitchensCount.Location = new System.Drawing.Point(1097, 255);
            this.lblKitchensCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblKitchensCount.Name = "lblKitchensCount";
            this.lblKitchensCount.Size = new System.Drawing.Size(76, 17);
            this.lblKitchensCount.TabIndex = 15;
            this.lblKitchensCount.Text = "عدد المطابخ:";
            // 
            // txtKitchensCount
            // 
            this.txtKitchensCount.AnimateReadOnly = false;
            this.txtKitchensCount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtKitchensCount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtKitchensCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtKitchensCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtKitchensCount.Depth = 0;
            this.txtKitchensCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtKitchensCount.HideSelection = false;
            this.txtKitchensCount.LeadingIcon = null;
            this.txtKitchensCount.Location = new System.Drawing.Point(613, 276);
            this.txtKitchensCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtKitchensCount.MaxLength = 10;
            this.txtKitchensCount.MouseState = MaterialSkin.MouseState.OUT;
            this.txtKitchensCount.Name = "txtKitchensCount";
            this.txtKitchensCount.PasswordChar = '\0';
            this.txtKitchensCount.PrefixSuffixText = null;
            this.txtKitchensCount.ReadOnly = false;
            this.txtKitchensCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtKitchensCount.SelectedText = "";
            this.txtKitchensCount.SelectionLength = 0;
            this.txtKitchensCount.SelectionStart = 0;
            this.txtKitchensCount.ShortcutsEnabled = true;
            this.txtKitchensCount.Size = new System.Drawing.Size(587, 36);
            this.txtKitchensCount.TabIndex = 7;
            this.txtKitchensCount.TabStop = false;
            this.txtKitchensCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKitchensCount.TrailingIcon = null;
            this.txtKitchensCount.UseSystemPasswordChar = false;
            this.txtKitchensCount.UseTallSize = false;
            // 
            // lblRoomsCount
            // 
            this.lblRoomsCount.AutoSize = true;
            this.lblRoomsCount.Depth = 0;
            this.lblRoomsCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRoomsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRoomsCount.Location = new System.Drawing.Point(498, 255);
            this.lblRoomsCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRoomsCount.Name = "lblRoomsCount";
            this.lblRoomsCount.Size = new System.Drawing.Size(66, 17);
            this.lblRoomsCount.TabIndex = 13;
            this.lblRoomsCount.Text = "عدد الغرف:";
            // 
            // txtRoomsCount
            // 
            this.txtRoomsCount.AnimateReadOnly = false;
            this.txtRoomsCount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtRoomsCount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtRoomsCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRoomsCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRoomsCount.Depth = 0;
            this.txtRoomsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRoomsCount.HideSelection = false;
            this.txtRoomsCount.LeadingIcon = null;
            this.txtRoomsCount.Location = new System.Drawing.Point(0, 276);
            this.txtRoomsCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomsCount.MaxLength = 10;
            this.txtRoomsCount.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRoomsCount.Name = "txtRoomsCount";
            this.txtRoomsCount.PasswordChar = '\0';
            this.txtRoomsCount.PrefixSuffixText = null;
            this.txtRoomsCount.ReadOnly = false;
            this.txtRoomsCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRoomsCount.SelectedText = "";
            this.txtRoomsCount.SelectionLength = 0;
            this.txtRoomsCount.SelectionStart = 0;
            this.txtRoomsCount.ShortcutsEnabled = true;
            this.txtRoomsCount.Size = new System.Drawing.Size(587, 36);
            this.txtRoomsCount.TabIndex = 6;
            this.txtRoomsCount.TabStop = false;
            this.txtRoomsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRoomsCount.TrailingIcon = null;
            this.txtRoomsCount.UseSystemPasswordChar = false;
            this.txtRoomsCount.UseTallSize = false;
            // 
            // lblRentStatus
            // 
            this.lblRentStatus.AutoSize = true;
            this.lblRentStatus.Depth = 0;
            this.lblRentStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRentStatus.Location = new System.Drawing.Point(1097, 190);
            this.lblRentStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRentStatus.Name = "lblRentStatus";
            this.lblRentStatus.Size = new System.Drawing.Size(72, 17);
            this.lblRentStatus.TabIndex = 11;
            this.lblRentStatus.Text = "حالة الإيجار:";
            // 
            // cmbRentStatus
            // 
            this.cmbRentStatus.AutoResize = false;
            this.cmbRentStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbRentStatus.Depth = 0;
            this.cmbRentStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbRentStatus.DropDownHeight = 174;
            this.cmbRentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRentStatus.DropDownWidth = 121;
            this.cmbRentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbRentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbRentStatus.FormattingEnabled = true;
            this.cmbRentStatus.IntegralHeight = false;
            this.cmbRentStatus.ItemHeight = 43;
            this.cmbRentStatus.Items.AddRange(new object[] {
            "متاح",
            "مؤجر",
            "صيانة",
            "محجوز"});
            this.cmbRentStatus.Location = new System.Drawing.Point(613, 211);
            this.cmbRentStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRentStatus.MaxDropDownItems = 4;
            this.cmbRentStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbRentStatus.Name = "cmbRentStatus";
            this.cmbRentStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbRentStatus.Size = new System.Drawing.Size(587, 49);
            this.cmbRentStatus.StartIndex = 0;
            this.cmbRentStatus.TabIndex = 5;
            // 
            // lblApartmentStatus
            // 
            this.lblApartmentStatus.AutoSize = true;
            this.lblApartmentStatus.Depth = 0;
            this.lblApartmentStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblApartmentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblApartmentStatus.Location = new System.Drawing.Point(495, 190);
            this.lblApartmentStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblApartmentStatus.Name = "lblApartmentStatus";
            this.lblApartmentStatus.Size = new System.Drawing.Size(69, 17);
            this.lblApartmentStatus.TabIndex = 9;
            this.lblApartmentStatus.Text = "حالة الشقة:";
            // 
            // cmbApartmentStatus
            // 
            this.cmbApartmentStatus.AutoResize = false;
            this.cmbApartmentStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbApartmentStatus.Depth = 0;
            this.cmbApartmentStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbApartmentStatus.DropDownHeight = 174;
            this.cmbApartmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApartmentStatus.DropDownWidth = 121;
            this.cmbApartmentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbApartmentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbApartmentStatus.FormattingEnabled = true;
            this.cmbApartmentStatus.IntegralHeight = false;
            this.cmbApartmentStatus.ItemHeight = 43;
            this.cmbApartmentStatus.Items.AddRange(new object[] {
            "جديد",
            "مستعمل",
            "تحت الإنشاء",
            "مشغول"});
            this.cmbApartmentStatus.Location = new System.Drawing.Point(0, 211);
            this.cmbApartmentStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbApartmentStatus.MaxDropDownItems = 4;
            this.cmbApartmentStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbApartmentStatus.Name = "cmbApartmentStatus";
            this.cmbApartmentStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbApartmentStatus.Size = new System.Drawing.Size(587, 49);
            this.cmbApartmentStatus.StartIndex = 0;
            this.cmbApartmentStatus.TabIndex = 4;
            // 
            // lblApartmentType
            // 
            this.lblApartmentType.AutoSize = true;
            this.lblApartmentType.Depth = 0;
            this.lblApartmentType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblApartmentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblApartmentType.Location = new System.Drawing.Point(1097, 125);
            this.lblApartmentType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblApartmentType.Name = "lblApartmentType";
            this.lblApartmentType.Size = new System.Drawing.Size(64, 17);
            this.lblApartmentType.TabIndex = 7;
            this.lblApartmentType.Text = "نوع الشقة:";
            // 
            // cmbApartmentType
            // 
            this.cmbApartmentType.AutoResize = false;
            this.cmbApartmentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbApartmentType.Depth = 0;
            this.cmbApartmentType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbApartmentType.DropDownHeight = 174;
            this.cmbApartmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApartmentType.DropDownWidth = 121;
            this.cmbApartmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbApartmentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbApartmentType.FormattingEnabled = true;
            this.cmbApartmentType.IntegralHeight = false;
            this.cmbApartmentType.ItemHeight = 43;
            this.cmbApartmentType.Items.AddRange(new object[] {
            "استوديو",
            "غرفة واحدة",
            "غرفتين",
            "ثلاث غرف",
            "أربع غرف",
            "خمس غرف",
            "بنتهاوس",
            "دوبلكس"});
            this.cmbApartmentType.Location = new System.Drawing.Point(613, 146);
            this.cmbApartmentType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbApartmentType.MaxDropDownItems = 4;
            this.cmbApartmentType.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbApartmentType.Name = "cmbApartmentType";
            this.cmbApartmentType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbApartmentType.Size = new System.Drawing.Size(587, 49);
            this.cmbApartmentType.StartIndex = 0;
            this.cmbApartmentType.TabIndex = 3;
            // 
            // lblAreaSqm
            // 
            this.lblAreaSqm.AutoSize = true;
            this.lblAreaSqm.Depth = 0;
            this.lblAreaSqm.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAreaSqm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAreaSqm.Location = new System.Drawing.Point(495, 125);
            this.lblAreaSqm.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAreaSqm.Name = "lblAreaSqm";
            this.lblAreaSqm.Size = new System.Drawing.Size(82, 17);
            this.lblAreaSqm.TabIndex = 5;
            this.lblAreaSqm.Text = "المساحة (م²):";
            // 
            // txtAreaSqm
            // 
            this.txtAreaSqm.AnimateReadOnly = false;
            this.txtAreaSqm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAreaSqm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAreaSqm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAreaSqm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAreaSqm.Depth = 0;
            this.txtAreaSqm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAreaSqm.HideSelection = false;
            this.txtAreaSqm.LeadingIcon = null;
            this.txtAreaSqm.Location = new System.Drawing.Point(0, 146);
            this.txtAreaSqm.Margin = new System.Windows.Forms.Padding(4);
            this.txtAreaSqm.MaxLength = 20;
            this.txtAreaSqm.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAreaSqm.Name = "txtAreaSqm";
            this.txtAreaSqm.PasswordChar = '\0';
            this.txtAreaSqm.PrefixSuffixText = null;
            this.txtAreaSqm.ReadOnly = false;
            this.txtAreaSqm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAreaSqm.SelectedText = "";
            this.txtAreaSqm.SelectionLength = 0;
            this.txtAreaSqm.SelectionStart = 0;
            this.txtAreaSqm.ShortcutsEnabled = true;
            this.txtAreaSqm.Size = new System.Drawing.Size(587, 36);
            this.txtAreaSqm.TabIndex = 2;
            this.txtAreaSqm.TabStop = false;
            this.txtAreaSqm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAreaSqm.TrailingIcon = null;
            this.txtAreaSqm.UseSystemPasswordChar = false;
            this.txtAreaSqm.UseTallSize = false;
            // 
            // lblPropertyNo
            // 
            this.lblPropertyNo.AutoSize = true;
            this.lblPropertyNo.Depth = 0;
            this.lblPropertyNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPropertyNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPropertyNo.Location = new System.Drawing.Point(1097, 60);
            this.lblPropertyNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPropertyNo.Name = "lblPropertyNo";
            this.lblPropertyNo.Size = new System.Drawing.Size(61, 17);
            this.lblPropertyNo.TabIndex = 3;
            this.lblPropertyNo.Text = "رقم العقار:";
            // 
            // cmbPropertyNo
            // 
            this.cmbPropertyNo.AutoResize = false;
            this.cmbPropertyNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPropertyNo.Depth = 0;
            this.cmbPropertyNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPropertyNo.DropDownHeight = 174;
            this.cmbPropertyNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPropertyNo.DropDownWidth = 121;
            this.cmbPropertyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbPropertyNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPropertyNo.FormattingEnabled = true;
            this.cmbPropertyNo.IntegralHeight = false;
            this.cmbPropertyNo.ItemHeight = 43;
            this.cmbPropertyNo.Location = new System.Drawing.Point(613, 81);
            this.cmbPropertyNo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPropertyNo.MaxDropDownItems = 4;
            this.cmbPropertyNo.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPropertyNo.Name = "cmbPropertyNo";
            this.cmbPropertyNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbPropertyNo.Size = new System.Drawing.Size(587, 49);
            this.cmbPropertyNo.StartIndex = 0;
            this.cmbPropertyNo.TabIndex = 1;
            // 
            // lblApartmentNo
            // 
            this.lblApartmentNo.AutoSize = true;
            this.lblApartmentNo.Depth = 0;
            this.lblApartmentNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblApartmentNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblApartmentNo.Location = new System.Drawing.Point(1094, 0);
            this.lblApartmentNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblApartmentNo.Name = "lblApartmentNo";
            this.lblApartmentNo.Size = new System.Drawing.Size(65, 17);
            this.lblApartmentNo.TabIndex = 1;
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
            this.txtApartmentNo.HideSelection = true;
            this.txtApartmentNo.LeadingIcon = null;
            this.txtApartmentNo.Location = new System.Drawing.Point(613, 21);
            this.txtApartmentNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtApartmentNo.MaxLength = 50;
            this.txtApartmentNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApartmentNo.Name = "txtApartmentNo";
            this.txtApartmentNo.PasswordChar = '\0';
            this.txtApartmentNo.PrefixSuffixText = null;
            this.txtApartmentNo.ReadOnly = false;
            this.txtApartmentNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtApartmentNo.SelectedText = "";
            this.txtApartmentNo.SelectionLength = 0;
            this.txtApartmentNo.SelectionStart = 0;
            this.txtApartmentNo.ShortcutsEnabled = true;
            this.txtApartmentNo.Size = new System.Drawing.Size(587, 36);
            this.txtApartmentNo.TabIndex = 0;
            this.txtApartmentNo.TabStop = false;
            this.txtApartmentNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtApartmentNo.TrailingIcon = null;
            this.txtApartmentNo.UseSystemPasswordChar = false;
            this.txtApartmentNo.UseTallSize = false;
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.White;
            this.pnlDataGrid.Controls.Add(this.dgvApartments);
            this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGrid.Location = new System.Drawing.Point(0, 674);
            this.pnlDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlDataGrid.Size = new System.Drawing.Size(1267, 357);
            this.pnlDataGrid.TabIndex = 2;
            // 
            // dgvApartments
            // 
            this.dgvApartments.AllowUserToAddRows = false;
            this.dgvApartments.AllowUserToDeleteRows = false;
            this.dgvApartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApartments.BackgroundColor = System.Drawing.Color.White;
            this.dgvApartments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvApartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvApartments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvApartments.Location = new System.Drawing.Point(27, 25);
            this.dgvApartments.Margin = new System.Windows.Forms.Padding(4);
            this.dgvApartments.MultiSelect = false;
            this.dgvApartments.Name = "dgvApartments";
            this.dgvApartments.ReadOnly = true;
            this.dgvApartments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvApartments.RowHeadersWidth = 51;
            this.dgvApartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApartments.Size = new System.Drawing.Size(1213, 307);
            this.dgvApartments.TabIndex = 0;
            // 
            // UC_Apartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlDataGrid);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Apartments";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1267, 1031);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlFields.ResumeLayout(false);
            this.pnlFields.PerformLayout();
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlFields;
        private MaterialSkin.Controls.MaterialTextBox2 txtApartmentNo;
        private MaterialSkin.Controls.MaterialComboBox cmbPropertyNo;
        private MaterialSkin.Controls.MaterialTextBox2 txtAreaSqm;
        private MaterialSkin.Controls.MaterialComboBox cmbApartmentType;
        private MaterialSkin.Controls.MaterialComboBox cmbApartmentStatus;
        private MaterialSkin.Controls.MaterialComboBox cmbRentStatus;
        private MaterialSkin.Controls.MaterialTextBox2 txtRoomsCount;
        private MaterialSkin.Controls.MaterialTextBox2 txtKitchensCount;
        private MaterialSkin.Controls.MaterialTextBox2 txtBathroomsCount;
        private MaterialSkin.Controls.MaterialTextBox2 txtFloorNo;
        private MaterialSkin.Controls.MaterialLabel lblApartmentNo;
        private MaterialSkin.Controls.MaterialLabel lblPropertyNo;
        private MaterialSkin.Controls.MaterialLabel lblAreaSqm;
        private MaterialSkin.Controls.MaterialLabel lblApartmentType;
        private MaterialSkin.Controls.MaterialLabel lblApartmentStatus;
        private MaterialSkin.Controls.MaterialLabel lblRentStatus;
        private MaterialSkin.Controls.MaterialLabel lblRoomsCount;
        private MaterialSkin.Controls.MaterialLabel lblKitchensCount;
        private MaterialSkin.Controls.MaterialLabel lblBathroomsCount;
        private MaterialSkin.Controls.MaterialLabel lblFloorNo;
        private System.Windows.Forms.Panel pnlButtons;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dgvApartments;
    }
}
