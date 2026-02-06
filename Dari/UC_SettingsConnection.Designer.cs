using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Dari
{
    partial class UC_SettingsConnection
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
            this.pnlFields = new Panel();
            this.lblServer = new MaterialSkin.Controls.MaterialLabel();
            this.txtServer = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblDatabase = new MaterialSkin.Controls.MaterialLabel();
            this.txtDatabase = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblUser = new MaterialSkin.Controls.MaterialLabel();
            this.txtUser = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblPassword = new MaterialSkin.Controls.MaterialLabel();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlFields.SuspendLayout();
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
            this.lblTitle.Location = new Point(950, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(280, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إعدادات الاتصال بالسيرفر";
            //
            // pnlForm
            //
            this.pnlForm.BackColor = Color.White;
            this.pnlForm.Controls.Add(this.pnlFields);
            this.pnlForm.Dock = DockStyle.Fill;
            this.pnlForm.Location = new Point(0, 74);
            this.pnlForm.Padding = new Padding(27, 25, 27, 25);
            this.pnlForm.RightToLeft = RightToLeft.Yes;
            this.pnlForm.Size = new Size(1267, 559);
            this.pnlForm.TabIndex = 1;
            //
            // pnlFields
            //
            this.pnlFields.Controls.Add(this.lblServer);
            this.pnlFields.Controls.Add(this.txtServer);
            this.pnlFields.Controls.Add(this.lblDatabase);
            this.pnlFields.Controls.Add(this.txtDatabase);
            this.pnlFields.Controls.Add(this.lblUser);
            this.pnlFields.Controls.Add(this.txtUser);
            this.pnlFields.Controls.Add(this.lblPassword);
            this.pnlFields.Controls.Add(this.txtPassword);
            this.pnlFields.Controls.Add(this.btnSave);
            this.pnlFields.Location = new Point(27, 25);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.RightToLeft = RightToLeft.Yes;
            this.pnlFields.Size = new Size(600, 380);
            this.pnlFields.TabIndex = 0;
            //
            // lblServer
            //
            this.lblServer.AutoSize = true;
            this.lblServer.Depth = 0;
            this.lblServer.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblServer.ForeColor = Color.FromArgb(180, 0, 0, 0);
            this.lblServer.Location = new Point(505, 0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new Size(92, 19);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "اسم السيرفر:";
            //
            // txtServer
            //
            this.txtServer.AnimateReadOnly = false;
            this.txtServer.CharacterCasing = CharacterCasing.Normal;
            this.txtServer.Depth = 0;
            this.txtServer.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.txtServer.HideSelection = false;
            this.txtServer.LeadingIcon = null;
            this.txtServer.Location = new Point(0, 21);
            this.txtServer.MaxLength = 200;
            this.txtServer.MouseState = MaterialSkin.MouseState.OUT;
            this.txtServer.Name = "txtServer";
            this.txtServer.PasswordChar = '\0';
            this.txtServer.PrefixSuffixText = null;
            this.txtServer.ReadOnly = false;
            this.txtServer.RightToLeft = RightToLeft.Yes;
            this.txtServer.Size = new Size(487, 36);
            this.txtServer.TabIndex = 1;
            this.txtServer.TextAlign = HorizontalAlignment.Right;
            this.txtServer.TrailingIcon = null;
            this.txtServer.UseSystemPasswordChar = false;
            this.txtServer.UseTallSize = false;
            //
            // lblDatabase
            //
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Depth = 0;
            this.lblDatabase.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblDatabase.ForeColor = Color.FromArgb(180, 0, 0, 0);
            this.lblDatabase.Location = new Point(505, 70);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new Size(92, 19);
            this.lblDatabase.TabIndex = 0;
            this.lblDatabase.Text = "اسم قاعدة البيانات:";
            //
            // txtDatabase
            //
            this.txtDatabase.AnimateReadOnly = false;
            this.txtDatabase.CharacterCasing = CharacterCasing.Normal;
            this.txtDatabase.Depth = 0;
            this.txtDatabase.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.txtDatabase.HideSelection = false;
            this.txtDatabase.LeadingIcon = null;
            this.txtDatabase.Location = new Point(0, 91);
            this.txtDatabase.MaxLength = 200;
            this.txtDatabase.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.PasswordChar = '\0';
            this.txtDatabase.PrefixSuffixText = null;
            this.txtDatabase.ReadOnly = false;
            this.txtDatabase.RightToLeft = RightToLeft.Yes;
            this.txtDatabase.Size = new Size(487, 36);
            this.txtDatabase.TabIndex = 2;
            this.txtDatabase.TextAlign = HorizontalAlignment.Right;
            this.txtDatabase.TrailingIcon = null;
            this.txtDatabase.UseSystemPasswordChar = false;
            this.txtDatabase.UseTallSize = false;
            //
            // lblUser
            //
            this.lblUser.AutoSize = true;
            this.lblUser.Depth = 0;
            this.lblUser.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblUser.ForeColor = Color.FromArgb(180, 0, 0, 0);
            this.lblUser.Location = new Point(505, 140);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new Size(55, 19);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "المستخدم:";
            //
            // txtUser
            //
            this.txtUser.AnimateReadOnly = false;
            this.txtUser.CharacterCasing = CharacterCasing.Normal;
            this.txtUser.Depth = 0;
            this.txtUser.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.txtUser.HideSelection = false;
            this.txtUser.LeadingIcon = null;
            this.txtUser.Location = new Point(0, 161);
            this.txtUser.MaxLength = 200;
            this.txtUser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PrefixSuffixText = null;
            this.txtUser.ReadOnly = false;
            this.txtUser.RightToLeft = RightToLeft.Yes;
            this.txtUser.Size = new Size(487, 36);
            this.txtUser.TabIndex = 3;
            this.txtUser.TextAlign = HorizontalAlignment.Right;
            this.txtUser.TrailingIcon = null;
            this.txtUser.UseSystemPasswordChar = false;
            this.txtUser.UseTallSize = false;
            //
            // lblPassword
            //
            this.lblPassword.AutoSize = true;
            this.lblPassword.Depth = 0;
            this.lblPassword.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.lblPassword.ForeColor = Color.FromArgb(180, 0, 0, 0);
            this.lblPassword.Location = new Point(505, 210);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(68, 19);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "كلمة السر:";
            //
            // txtPassword
            //
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.CharacterCasing = CharacterCasing.Normal;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            this.txtPassword.HideSelection = false;
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new Point(0, 231);
            this.txtPassword.MaxLength = 200;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PrefixSuffixText = null;
            this.txtPassword.ReadOnly = false;
            this.txtPassword.RightToLeft = RightToLeft.Yes;
            this.txtPassword.Size = new Size(487, 36);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextAlign = HorizontalAlignment.Right;
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.UseTallSize = false;
            //
            // btnSave
            //
            this.btnSave.AutoSize = false;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new Point(213, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(200, 50);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "حفظ";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            //
            // UC_SettingsConnection
            //
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_SettingsConnection";
            this.RightToLeft = RightToLeft.Yes;
            this.Size = new Size(1267, 633);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlFields.ResumeLayout(false);
            this.pnlFields.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private Panel pnlForm;
        private Panel pnlFields;
        private MaterialSkin.Controls.MaterialLabel lblServer;
        private MaterialSkin.Controls.MaterialTextBox2 txtServer;
        private MaterialSkin.Controls.MaterialLabel lblDatabase;
        private MaterialSkin.Controls.MaterialTextBox2 txtDatabase;
        private MaterialSkin.Controls.MaterialLabel lblUser;
        private MaterialSkin.Controls.MaterialTextBox2 txtUser;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtPassword;
        private MaterialSkin.Controls.MaterialButton btnSave;
    }
}
