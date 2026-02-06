using System;
using System.Windows.Forms;
using Dari.Properties;

namespace Dari
{
    /// <summary>
    /// شاشة إعدادات الاتصال بالسيرفر.
    /// </summary>
    public partial class UC_SettingsConnection : UserControl
    {
        public UC_SettingsConnection()
        {
            InitializeComponent();
            if (DesignMode) return;

            if (btnClose != null)
                btnClose.Click += BtnClose_Click;
            if (btnSave != null)
                btnSave.Click += BtnSave_Click;

            Load += UC_SettingsConnection_Load;
        }

        private void UC_SettingsConnection_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            LoadFromSettings();
        }

        private void LoadFromSettings()
        {
            try
            {
                txtServer.Text = Settings.Default.Server ?? "";
                txtDatabase.Text = Settings.Default.Database ?? "";
                txtUser.Text = Settings.Default.ID ?? "";
                txtPassword.Text = Settings.Default.Password ?? "";
            }
            catch { /* ignore */ }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Server = txtServer?.Text?.Trim() ?? "";
                Settings.Default.Database = txtDatabase?.Text?.Trim() ?? "";
                Settings.Default.ID = txtUser?.Text?.Trim() ?? "";
                Settings.Default.Password = txtPassword?.Text ?? "";
                Settings.Default.Save();
                MessageBox.Show("تم حفظ إعدادات الاتصال بنجاح.", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ عند الحفظ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (FindForm() is Form1 mainForm)
            {
                mainForm.ShowHome();
                return;
            }
            Visible = false;
        }
    }
}
