using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Dari.Clas;

namespace Dari
{
    public partial class Form1 : MaterialForm
    {
        private bool isMenuCollapsed = false;
        private bool isDataSubMenuExpanded = false;
        private bool isOperationsSubMenuExpanded = false;
        private bool isReportsSubMenuExpanded = false;
        private const int MENU_EXPANDED_WIDTH = 250;
        private const int MENU_COLLAPSED_WIDTH = 60;
        private UserControl currentUserControl = null;

        public Form1()
        {
            InitializeComponent();
            
            // إعداد MaterialSkin مع دعم RTL للعربية
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue700, Primary.Blue800,
                Primary.Blue500, Accent.Blue200,
                TextShade.WHITE
            );
            
            // تفعيل دعم RTL للعربية
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            
            // إعداد القائمة الجانبية
            SetupSidebarMenu();
            
            // ربط الأحداث
            btnMenuToggle.Click += BtnMenuToggle_Click;
            btnDataManagement.Click += BtnDataManagement_Click;
            btnOperations.Click += BtnOperations_Click;
            btnReports.Click += BtnReports_Click;
            btnSettings.Click += BtnSettings_Click;
            
            // ربط أحداث القائمة الفرعية للبيانات
            btnBuildings.Click += BtnBuildings_Click;
            btnApartments.Click += BtnApartments_Click;
            btnTenants.Click += BtnTenants_Click;
            btnContracts.Click += BtnContracts_Click;
            
            // ربط أحداث القائمة الفرعية للعمليات
            btnRentLoad.Click += BtnRentLoad_Click;
            btnInvoices.Click += BtnInvoices_Click;
            btnReceipts.Click += BtnReceipts_Click;
            btnAccountStatement.Click += BtnAccountStatement_Click;
            btnTenantMonthlyStatement.Click += BtnTenantMonthlyStatement_Click;
            btnAvailableBuildingsApartments.Click += BtnAvailableBuildingsApartments_Click;

            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var overlay = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                ShowInTaskbar = false,
                BackColor = Color.Black,
                Opacity = 0.65,
                Size = Size,
                Location = Location,
                StartPosition = FormStartPosition.Manual
            };
            overlay.Show(this);

            using (var formLogin = new FormLogin())
            {
                formLogin.StartPosition = FormStartPosition.CenterParent;
                if (formLogin.ShowDialog(this) != DialogResult.OK)
                {
                    overlay.Close();
                    overlay.Dispose();
                    Application.Exit();
                    return;
                }
            }

            overlay.Close();
            overlay.Dispose();

            if (CurrentUser.ShowConnectionSettingsNext)
            {
                CurrentUser.ShowConnectionSettingsNext = false;
                lblHeaderTitle.Text = "إعدادات الاتصال بالسيرفر";
                ShowUserControl(new UC_SettingsConnection());
            }
        }

        private void SetupSidebarMenu()
        {
            // القائمة مفتوحة افتراضياً
            isMenuCollapsed = false;
            pnlSidebar.Width = MENU_EXPANDED_WIDTH;
            
            // إعداد الأزرار
            UpdateMenuButtons();
        }

        private void BtnMenuToggle_Click(object sender, EventArgs e)
        {
            ToggleMenu();
        }

        private void ToggleMenu()
        {
            isMenuCollapsed = !isMenuCollapsed;
            
            // تحريك القائمة مع تأثير سلس
            if (isMenuCollapsed)
            {
                // طي القائمة - عرض الأيقونات فقط
                pnlSidebar.Width = MENU_COLLAPSED_WIDTH;
            }
            else
            {
                // فتح القائمة - عرض النصوص الكاملة
                pnlSidebar.Width = MENU_EXPANDED_WIDTH;
            }
            
            UpdateMenuButtons();
        }

        private void UpdateMenuButtons()
        {
            // زر القائمة يبقى أيقونة فقط
            btnMenuToggle.Text = "☰";
            
            if (isMenuCollapsed)
            {
                // عند الطي: إظهار الأيقونات فقط
                btnSettings.Text = "⚙️";
                btnReports.Text = "📈";
                btnOperations.Text = "💼";
                
                // إخفاء القوائم الفرعية عند طي القائمة
                pnlDataSubMenu.Visible = false;
                pnlOperationsSubMenu.Visible = false;
                pnlReportsSubMenu.Visible = false;
                isDataSubMenuExpanded = false;
                isOperationsSubMenuExpanded = false;
                isReportsSubMenuExpanded = false;
                
                if (isDataSubMenuExpanded)
                    btnDataManagement.Text = "📊 ▼";
                else
                    btnDataManagement.Text = "📊";
                
                if (isOperationsSubMenuExpanded)
                    btnOperations.Text = "💼 ▼";
                else
                    btnOperations.Text = "💼";
                
                if (isReportsSubMenuExpanded)
                    btnReports.Text = "📈 ▼";
                else
                    btnReports.Text = "📈";
            }
            else
            {
                // عند الفتح: إظهار النصوص الكاملة
                btnSettings.Text = "⚙️ الإعدادات";
                btnReports.Text = "📈 التقارير";
                btnOperations.Text = "💼 العمليات";
                
                // تحديث نص البيانات الأساسية حسب حالة القائمة الفرعية
                if (isDataSubMenuExpanded)
                    btnDataManagement.Text = "📊 البيانات الأساسية ▼";
                else
                    btnDataManagement.Text = "📊 البيانات الأساسية";
                
                // تحديث نص العمليات حسب حالة القائمة الفرعية
                if (isOperationsSubMenuExpanded)
                    btnOperations.Text = "💼 العمليات ▼";
                else
                    btnOperations.Text = "💼 العمليات";
                
                // تحديث نص التقارير حسب حالة القائمة الفرعية
                if (isReportsSubMenuExpanded)
                    btnReports.Text = "📈 التقارير ▼";
                else
                    btnReports.Text = "📈 التقارير";
            }
        }

        private void BtnDataManagement_Click(object sender, EventArgs e)
        {
            // تبديل حالة القائمة الفرعية
            ToggleDataSubMenu();
        }

        private void ToggleDataSubMenu()
        {
            isDataSubMenuExpanded = !isDataSubMenuExpanded;
            
            if (isDataSubMenuExpanded)
            {
                // إزالة القائمة الفرعية من Controls
                if (pnlSidebar.Controls.Contains(pnlDataSubMenu))
                {
                    pnlSidebar.Controls.Remove(pnlDataSubMenu);
                }
                
                // إضافة القائمة الفرعية بعد الزر الرئيسي مباشرة
                int dataIndex = pnlSidebar.Controls.IndexOf(btnDataManagement);
                pnlSidebar.Controls.Add(pnlDataSubMenu);
                pnlSidebar.Controls.SetChildIndex(pnlDataSubMenu, dataIndex + 1);
                
                pnlDataSubMenu.Visible = true;
            }
            else
            {
                pnlDataSubMenu.Visible = false;
            }
            
            // تحديث نص الزر لإظهار السهم
            if (isDataSubMenuExpanded)
            {
                if (isMenuCollapsed)
                    btnDataManagement.Text = "📊 ▼";
                else
                    btnDataManagement.Text = "📊 البيانات الأساسية ▼";
            }
            else
            {
                if (isMenuCollapsed)
                    btnDataManagement.Text = "📊";
                else
                    btnDataManagement.Text = "📊 البيانات الأساسية";
            }
        }

        private void BtnBuildings_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_Buildings());
        }

        private void ShowUserControl(UserControl userControl)
        {
            // إزالة User Control الحالي إن وجد
            if (currentUserControl != null)
            {
                pnlContent.Controls.Remove(currentUserControl);
                currentUserControl.Dispose();
            }
            
            // إضافة User Control الجديد
            currentUserControl = userControl;
            currentUserControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(currentUserControl);
        }

        public void ShowHome()
        {
            // إزالة User Control الحالي إن وجد
            if (currentUserControl != null)
            {
                pnlContent.Controls.Remove(currentUserControl);
                currentUserControl.Dispose();
                currentUserControl = null;
            }

            pnlContent.Controls.Clear();

            // إعادة إظهار العنوان الافتراضي داخل المحتوى
            if (lblHeaderTitle != null)
            {
                lblHeaderTitle.Text = "مرحباً بك في نظام إدارة الإيجارات";
                pnlContent.Controls.Add(lblHeaderTitle);
            }
        }

        private void BtnApartments_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_Apartments());
        }

        private void BtnTenants_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_Tenants());
        }

        private void BtnContracts_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_Contracts());
        }

        private void BtnOperations_Click(object sender, EventArgs e)
        {
            // تبديل حالة القائمة الفرعية
            ToggleOperationsSubMenu();
        }

        private void ToggleOperationsSubMenu()
        {
            isOperationsSubMenuExpanded = !isOperationsSubMenuExpanded;
            
            if (isOperationsSubMenuExpanded)
            {
                // إزالة القائمة الفرعية من Controls
                if (pnlSidebar.Controls.Contains(pnlOperationsSubMenu))
                {
                    pnlSidebar.Controls.Remove(pnlOperationsSubMenu);
                }
                
                // إضافة القائمة الفرعية بعد الزر الرئيسي مباشرة
                int operationsIndex = pnlSidebar.Controls.IndexOf(btnOperations);
                pnlSidebar.Controls.Add(pnlOperationsSubMenu);
                pnlSidebar.Controls.SetChildIndex(pnlOperationsSubMenu, operationsIndex + 1);
                
                pnlOperationsSubMenu.Visible = true;
            }
            else
            {
                pnlOperationsSubMenu.Visible = false;
            }
            
            // تحديث نص الزر لإظهار السهم
            if (isOperationsSubMenuExpanded)
            {
                if (isMenuCollapsed)
                    btnOperations.Text = "💼 ▼";
                else
                    btnOperations.Text = "💼 العمليات ▼";
            }
            else
            {
                if (isMenuCollapsed)
                    btnOperations.Text = "💼";
                else
                    btnOperations.Text = "💼 العمليات";
            }
        }

        private void BtnRentLoad_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_RentCalculation());
        }

        private void BtnInvoices_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_TenantInvoices());
        }

        private void BtnReceipts_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_Receipts());
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            ToggleReportsSubMenu();
        }

        private void ToggleReportsSubMenu()
        {
            isReportsSubMenuExpanded = !isReportsSubMenuExpanded;
            
            if (isReportsSubMenuExpanded)
            {
                if (pnlSidebar.Controls.Contains(pnlReportsSubMenu))
                    pnlSidebar.Controls.Remove(pnlReportsSubMenu);
                int reportsIndex = pnlSidebar.Controls.IndexOf(btnReports);
                pnlSidebar.Controls.Add(pnlReportsSubMenu);
                pnlSidebar.Controls.SetChildIndex(pnlReportsSubMenu, reportsIndex + 1);
                pnlReportsSubMenu.Visible = true;
            }
            else
                pnlReportsSubMenu.Visible = false;
            
            if (isReportsSubMenuExpanded)
                btnReports.Text = isMenuCollapsed ? "📈 ▼" : "📈 التقارير ▼";
            else
                btnReports.Text = isMenuCollapsed ? "📈" : "📈 التقارير";
        }

        private void BtnAccountStatement_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_ReportAccountStatement());
        }

        private void BtnTenantMonthlyStatement_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_TenantMonthlyStatement());
        }

        private void BtnAvailableBuildingsApartments_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_ReportAvailableBuildingsApartments());
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            lblHeaderTitle.Text = "الإعدادات";
            ShowUserControl(new UC_SettingsConnection());
        }
    }
}
