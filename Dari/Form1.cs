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

namespace Dari
{
    public partial class Form1 : MaterialForm
    {
        private bool isMenuCollapsed = false;
        private const int MENU_EXPANDED_WIDTH = 250;
        private const int MENU_COLLAPSED_WIDTH = 60;

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
                btnDataManagement.Text = "📊";
            }
            else
            {
                // عند الفتح: إظهار النصوص الكاملة
                btnSettings.Text = "⚙️ الإعدادات";
                btnReports.Text = "📈 التقارير";
                btnOperations.Text = "💼 العمليات";
                btnDataManagement.Text = "📊 البيانات الأساسية";
            }
        }

        private void BtnDataManagement_Click(object sender, EventArgs e)
        {
            lblHeaderTitle.Text = "البيانات الأساسية";
            // هنا سيتم فتح شاشة البيانات الأساسية لاحقاً
        }

        private void BtnOperations_Click(object sender, EventArgs e)
        {
            lblHeaderTitle.Text = "العمليات";
            // هنا سيتم فتح شاشة العمليات لاحقاً
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            lblHeaderTitle.Text = "التقارير";
            // هنا سيتم فتح شاشة التقارير لاحقاً
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            lblHeaderTitle.Text = "الإعدادات";
            // هنا سيتم فتح شاشة الإعدادات لاحقاً
        }
    }
}
