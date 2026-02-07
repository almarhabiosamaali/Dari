using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Dari.Clas;

namespace Dari
{
    /// <summary>
    /// شاشة تسجيل الدخول — تظهر في منتصف الشاشة الرئيسية حتى يتم الدخول بنجاح.
    /// </summary>
    public partial class FormLogin : MaterialForm
    {
        private readonly UserLogin _userLogin;

        public FormLogin()
        {
            InitializeComponent();
            _userLogin = new UserLogin();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue700, Primary.Blue800,
                Primary.Blue500, Accent.Blue200,
                TextShade.WHITE
            );

            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;

            if (btnLogin != null) btnLogin.Click += BtnLogin_Click;
            if (btnCancel != null) btnCancel.Click += BtnCancel_Click;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string signInName = txtSignInName?.Text?.Trim();
            string pwd = txtPassword?.Text ?? "";

            if (string.IsNullOrEmpty(signInName))
            {
                MessageBox.Show("يرجى إدخال اسم المستخدم.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSignInName?.Focus();
                return;
            }

            // دخول ADMIN / ADMIN@123 → تحويل لشاشة إعدادات الاتصال بدون استدعاء قاعدة البيانات
            if (string.Equals(signInName, "ADMIN", StringComparison.OrdinalIgnoreCase) && pwd == "ADMIN@123")
            {
                CurrentUser.ShowConnectionSettingsNext = true;
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            try
            {
                DataTable dt = _userLogin.Login(signInName, pwd);
                if (dt != null && dt.Rows.Count > 0)
                {
                    CurrentUser.SetFromRow(dt.Rows[0]);
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الاتصال: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة.", "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtPassword?.Focus();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
