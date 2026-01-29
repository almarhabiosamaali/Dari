using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Dari
{
    partial class UC_Receipts
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
            this.lblReceiptNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtReceiptNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblTenantNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenantNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblReceiptType = new MaterialSkin.Controls.MaterialLabel();
            this.cmbReceiptType = new MaterialSkin.Controls.MaterialComboBox();
            this.lblReceiptDate = new MaterialSkin.Controls.MaterialLabel();
            this.dtpReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.lblBillYear = new MaterialSkin.Controls.MaterialLabel();
            this.cmbBillYear = new MaterialSkin.Controls.MaterialComboBox();
            this.lblBillMonth = new MaterialSkin.Controls.MaterialLabel();
            this.cmbBillMonth = new MaterialSkin.Controls.MaterialComboBox();
            this.lblAmount = new MaterialSkin.Controls.MaterialLabel();
            this.txtAmount = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblReferenceNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtReferenceNo = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblNarration = new MaterialSkin.Controls.MaterialLabel();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dgvReceipts = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlFields.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).BeginInit();
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
            this.lblTitle.Location = new System.Drawing.Point(1135, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(105, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "سندات القبض";
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
            this.pnlForm.Size = new System.Drawing.Size(1267, 520);
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
            this.pnlButtons.Location = new System.Drawing.Point(27, 397);
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
            this.btnSave.TabIndex = 8;
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
            this.btnSearch.TabIndex = 7;
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
            this.btnDelete.TabIndex = 6;
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
            this.btnEdit.TabIndex = 5;
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
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "➕ إضافة";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            //
            // pnlFields
            //
            this.pnlFields.Controls.Add(this.lblReceiptNo);
            this.pnlFields.Controls.Add(this.txtReceiptNo);
            this.pnlFields.Controls.Add(this.lblTenantNo);
            this.pnlFields.Controls.Add(this.txtTenantNo);
            this.pnlFields.Controls.Add(this.lblReceiptType);
            this.pnlFields.Controls.Add(this.cmbReceiptType);
            this.pnlFields.Controls.Add(this.lblReceiptDate);
            this.pnlFields.Controls.Add(this.dtpReceiptDate);
            this.pnlFields.Controls.Add(this.lblBillYear);
            this.pnlFields.Controls.Add(this.cmbBillYear);
            this.pnlFields.Controls.Add(this.lblBillMonth);
            this.pnlFields.Controls.Add(this.cmbBillMonth);
            this.pnlFields.Controls.Add(this.lblAmount);
            this.pnlFields.Controls.Add(this.txtAmount);
            this.pnlFields.Controls.Add(this.lblReferenceNo);
            this.pnlFields.Controls.Add(this.txtReferenceNo);
            this.pnlFields.Controls.Add(this.lblNarration);
            this.pnlFields.Controls.Add(this.txtNarration);
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFields.Location = new System.Drawing.Point(27, 25);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlFields.Size = new System.Drawing.Size(1213, 470);
            this.pnlFields.TabIndex = 0;
            //
            // lblReceiptNo
            //
            this.lblReceiptNo.AutoSize = true;
            this.lblReceiptNo.Depth = 0;
            this.lblReceiptNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblReceiptNo.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblReceiptNo.Location = new System.Drawing.Point(1097, 0);
            this.lblReceiptNo.Name = "lblReceiptNo";
            this.lblReceiptNo.Size = new System.Drawing.Size(79, 19);
            this.lblReceiptNo.TabIndex = 1;
            this.lblReceiptNo.Text = "رقم السند:";
            //
            // txtReceiptNo
            //
            this.txtReceiptNo.AnimateReadOnly = false;
            this.txtReceiptNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtReceiptNo.Depth = 0;
            this.txtReceiptNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtReceiptNo.HideSelection = true;
            this.txtReceiptNo.LeadingIcon = null;
            this.txtReceiptNo.Location = new System.Drawing.Point(613, 21);
            this.txtReceiptNo.MaxLength = 50;
            this.txtReceiptNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.PasswordChar = '\0';
            this.txtReceiptNo.PrefixSuffixText = null;
            this.txtReceiptNo.ReadOnly = false;
            this.txtReceiptNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtReceiptNo.Size = new System.Drawing.Size(587, 36);
            this.txtReceiptNo.TabIndex = 0;
            this.txtReceiptNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtReceiptNo.TrailingIcon = null;
            this.txtReceiptNo.UseSystemPasswordChar = false;
            this.txtReceiptNo.UseTallSize = false;
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
            // lblReceiptType
            //
            this.lblReceiptType.AutoSize = true;
            this.lblReceiptType.Depth = 0;
            this.lblReceiptType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblReceiptType.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblReceiptType.Location = new System.Drawing.Point(1085, 60);
            this.lblReceiptType.Name = "lblReceiptType";
            this.lblReceiptType.Size = new System.Drawing.Size(91, 19);
            this.lblReceiptType.TabIndex = 5;
            this.lblReceiptType.Text = "نوع السند:";
            //
            // cmbReceiptType
            //
            this.cmbReceiptType.AutoResize = false;
            this.cmbReceiptType.BackColor = System.Drawing.Color.White;
            this.cmbReceiptType.Depth = 0;
            this.cmbReceiptType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbReceiptType.DropDownHeight = 174;
            this.cmbReceiptType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReceiptType.DropDownWidth = 121;
            this.cmbReceiptType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbReceiptType.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            this.cmbReceiptType.FormattingEnabled = true;
            this.cmbReceiptType.IntegralHeight = false;
            this.cmbReceiptType.ItemHeight = 43;
            this.cmbReceiptType.Items.AddRange(new object[] { "قبض", "صرف", "أخرى" });
            this.cmbReceiptType.Location = new System.Drawing.Point(613, 81);
            this.cmbReceiptType.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbReceiptType.Name = "cmbReceiptType";
            this.cmbReceiptType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbReceiptType.Size = new System.Drawing.Size(587, 49);
            this.cmbReceiptType.StartIndex = 0;
            this.cmbReceiptType.TabIndex = 2;
            //
            // lblReceiptDate
            //
            this.lblReceiptDate.AutoSize = true;
            this.lblReceiptDate.Depth = 0;
            this.lblReceiptDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblReceiptDate.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblReceiptDate.Location = new System.Drawing.Point(515, 60);
            this.lblReceiptDate.Name = "lblReceiptDate";
            this.lblReceiptDate.Size = new System.Drawing.Size(55, 19);
            this.lblReceiptDate.TabIndex = 7;
            this.lblReceiptDate.Text = "التاريخ:";
            //
            // dtpReceiptDate
            //
            this.dtpReceiptDate.CustomFormat = "yyyy-MM-dd";
            this.dtpReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReceiptDate.Location = new System.Drawing.Point(0, 81);
            this.dtpReceiptDate.Name = "dtpReceiptDate";
            this.dtpReceiptDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpReceiptDate.RightToLeftLayout = true;
            this.dtpReceiptDate.Size = new System.Drawing.Size(587, 22);
            this.dtpReceiptDate.TabIndex = 3;
            //
            // lblBillYear
            //
            this.lblBillYear.AutoSize = true;
            this.lblBillYear.Depth = 0;
            this.lblBillYear.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBillYear.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblBillYear.Location = new System.Drawing.Point(1115, 135);
            this.lblBillYear.Name = "lblBillYear";
            this.lblBillYear.Size = new System.Drawing.Size(41, 19);
            this.lblBillYear.TabIndex = 9;
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
            this.cmbBillYear.Location = new System.Drawing.Point(613, 156);
            this.cmbBillYear.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBillYear.Name = "cmbBillYear";
            this.cmbBillYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbBillYear.Size = new System.Drawing.Size(587, 49);
            this.cmbBillYear.StartIndex = 0;
            this.cmbBillYear.TabIndex = 4;
            //
            // lblBillMonth
            //
            this.lblBillMonth.AutoSize = true;
            this.lblBillMonth.Depth = 0;
            this.lblBillMonth.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBillMonth.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblBillMonth.Location = new System.Drawing.Point(509, 135);
            this.lblBillMonth.Name = "lblBillMonth";
            this.lblBillMonth.Size = new System.Drawing.Size(43, 19);
            this.lblBillMonth.TabIndex = 11;
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
            this.cmbBillMonth.Location = new System.Drawing.Point(0, 156);
            this.cmbBillMonth.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBillMonth.Name = "cmbBillMonth";
            this.cmbBillMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbBillMonth.Size = new System.Drawing.Size(587, 49);
            this.cmbBillMonth.StartIndex = 0;
            this.cmbBillMonth.TabIndex = 5;
            //
            // lblAmount
            //
            this.lblAmount.AutoSize = true;
            this.lblAmount.Depth = 0;
            this.lblAmount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblAmount.Location = new System.Drawing.Point(1125, 210);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 19);
            this.lblAmount.TabIndex = 13;
            this.lblAmount.Text = "المبلغ:";
            //
            // txtAmount
            //
            this.txtAmount.AnimateReadOnly = false;
            this.txtAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAmount.Depth = 0;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAmount.HideSelection = false;
            this.txtAmount.LeadingIcon = null;
            this.txtAmount.Location = new System.Drawing.Point(613, 231);
            this.txtAmount.MaxLength = 20;
            this.txtAmount.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PrefixSuffixText = null;
            this.txtAmount.ReadOnly = false;
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAmount.Size = new System.Drawing.Size(587, 36);
            this.txtAmount.TabIndex = 6;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.TrailingIcon = null;
            this.txtAmount.UseSystemPasswordChar = false;
            this.txtAmount.UseTallSize = false;
            //
            // lblReferenceNo
            //
            this.lblReferenceNo.AutoSize = true;
            this.lblReferenceNo.Depth = 0;
            this.lblReferenceNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblReferenceNo.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblReferenceNo.Location = new System.Drawing.Point(495, 210);
            this.lblReferenceNo.Name = "lblReferenceNo";
            this.lblReferenceNo.Size = new System.Drawing.Size(84, 19);
            this.lblReferenceNo.TabIndex = 15;
            this.lblReferenceNo.Text = "الرقم المرجعي:";
            //
            // txtReferenceNo
            //
            this.txtReferenceNo.AnimateReadOnly = false;
            this.txtReferenceNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtReferenceNo.Depth = 0;
            this.txtReferenceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtReferenceNo.HideSelection = false;
            this.txtReferenceNo.LeadingIcon = null;
            this.txtReferenceNo.Location = new System.Drawing.Point(0, 231);
            this.txtReferenceNo.MaxLength = 50;
            this.txtReferenceNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtReferenceNo.Name = "txtReferenceNo";
            this.txtReferenceNo.PasswordChar = '\0';
            this.txtReferenceNo.PrefixSuffixText = null;
            this.txtReferenceNo.ReadOnly = false;
            this.txtReferenceNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtReferenceNo.Size = new System.Drawing.Size(587, 36);
            this.txtReferenceNo.TabIndex = 7;
            this.txtReferenceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtReferenceNo.TrailingIcon = null;
            this.txtReferenceNo.UseSystemPasswordChar = false;
            this.txtReferenceNo.UseTallSize = false;
            //
            // lblNarration
            //
            this.lblNarration.AutoSize = true;
            this.lblNarration.Depth = 0;
            this.lblNarration.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNarration.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
            this.lblNarration.Location = new System.Drawing.Point(1135, 275);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(41, 19);
            this.lblNarration.TabIndex = 17;
            this.lblNarration.Text = "البيان:";
            //
            // txtNarration
            //
            this.txtNarration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNarration.Location = new System.Drawing.Point(613, 296);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNarration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNarration.Size = new System.Drawing.Size(587, 80);
            this.txtNarration.TabIndex = 8;
            //
            // pnlDataGrid
            //
            this.pnlDataGrid.BackColor = System.Drawing.Color.White;
            this.pnlDataGrid.Controls.Add(this.dgvReceipts);
            this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGrid.Location = new System.Drawing.Point(0, 594);
            this.pnlDataGrid.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlDataGrid.Size = new System.Drawing.Size(1267, 437);
            this.pnlDataGrid.TabIndex = 2;
            //
            // dgvReceipts
            //
            this.dgvReceipts.AllowUserToAddRows = false;
            this.dgvReceipts.AllowUserToDeleteRows = false;
            this.dgvReceipts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceipts.BackgroundColor = System.Drawing.Color.White;
            this.dgvReceipts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReceipts.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.dgvReceipts.Location = new System.Drawing.Point(27, 25);
            this.dgvReceipts.MultiSelect = false;
            this.dgvReceipts.Name = "dgvReceipts";
            this.dgvReceipts.ReadOnly = true;
            this.dgvReceipts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvReceipts.RowHeadersWidth = 51;
            this.dgvReceipts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceipts.Size = new System.Drawing.Size(1213, 387);
            this.dgvReceipts.TabIndex = 0;
            //
            // UC_Receipts
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlDataGrid);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_Receipts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1267, 1031);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlFields.ResumeLayout(false);
            this.pnlFields.PerformLayout();
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlFields;
        private MaterialSkin.Controls.MaterialLabel lblReceiptNo;
        private MaterialSkin.Controls.MaterialTextBox2 txtReceiptNo;
        private MaterialSkin.Controls.MaterialLabel lblTenantNo;
        private MaterialSkin.Controls.MaterialTextBox2 txtTenantNo;
        private MaterialSkin.Controls.MaterialLabel lblReceiptType;
        private MaterialSkin.Controls.MaterialComboBox cmbReceiptType;
        private MaterialSkin.Controls.MaterialLabel lblReceiptDate;
        private System.Windows.Forms.DateTimePicker dtpReceiptDate;
        private MaterialSkin.Controls.MaterialLabel lblBillYear;
        private MaterialSkin.Controls.MaterialComboBox cmbBillYear;
        private MaterialSkin.Controls.MaterialLabel lblBillMonth;
        private MaterialSkin.Controls.MaterialComboBox cmbBillMonth;
        private MaterialSkin.Controls.MaterialLabel lblAmount;
        private MaterialSkin.Controls.MaterialTextBox2 txtAmount;
        private MaterialSkin.Controls.MaterialLabel lblReferenceNo;
        private MaterialSkin.Controls.MaterialTextBox2 txtReferenceNo;
        private MaterialSkin.Controls.MaterialLabel lblNarration;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Panel pnlButtons;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dgvReceipts;
    }
}
