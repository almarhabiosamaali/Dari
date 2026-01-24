namespace Dari
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnMenuToggle = new MaterialSkin.Controls.MaterialButton();
            this.btnSettings = new MaterialSkin.Controls.MaterialButton();
            this.btnReports = new MaterialSkin.Controls.MaterialButton();
            this.btnOperations = new MaterialSkin.Controls.MaterialButton();
            this.pnlOperationsSubMenu = new System.Windows.Forms.Panel();
            this.btnReceipts = new MaterialSkin.Controls.MaterialButton();
            this.btnInvoices = new MaterialSkin.Controls.MaterialButton();
            this.btnDataManagement = new MaterialSkin.Controls.MaterialButton();
            this.pnlDataSubMenu = new System.Windows.Forms.Panel();
            this.btnContracts = new MaterialSkin.Controls.MaterialButton();
            this.btnTenants = new MaterialSkin.Controls.MaterialButton();
            this.btnApartments = new MaterialSkin.Controls.MaterialButton();
            this.btnBuildings = new MaterialSkin.Controls.MaterialButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new MaterialSkin.Controls.MaterialLabel();
            this.pnlSidebar.SuspendLayout();
            this.pnlOperationsSubMenu.SuspendLayout();
            this.pnlDataSubMenu.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pnlSidebar.Controls.Add(this.btnMenuToggle);
            this.pnlSidebar.Controls.Add(this.btnSettings);
            this.pnlSidebar.Controls.Add(this.btnReports);
            this.pnlSidebar.Controls.Add(this.btnOperations);
            this.pnlSidebar.Controls.Add(this.pnlOperationsSubMenu);
            this.pnlSidebar.Controls.Add(this.btnDataManagement);
            this.pnlSidebar.Controls.Add(this.pnlDataSubMenu);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(3, 64);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 633);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnMenuToggle
            // 
            this.btnMenuToggle.AutoSize = false;
            this.btnMenuToggle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMenuToggle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMenuToggle.Depth = 0;
            this.btnMenuToggle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuToggle.DrawShadows = false;
            this.btnMenuToggle.HighEmphasis = false;
            this.btnMenuToggle.Icon = null;
            this.btnMenuToggle.Location = new System.Drawing.Point(0, 500);
            this.btnMenuToggle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMenuToggle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMenuToggle.Name = "btnMenuToggle";
            this.btnMenuToggle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMenuToggle.Size = new System.Drawing.Size(250, 50);
            this.btnMenuToggle.TabIndex = 0;
            this.btnMenuToggle.Text = "☰";
            this.btnMenuToggle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnMenuToggle.UseAccentColor = false;
            this.btnMenuToggle.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.AutoSize = false;
            this.btnSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSettings.Depth = 0;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.DrawShadows = false;
            this.btnSettings.HighEmphasis = false;
            this.btnSettings.Icon = null;
            this.btnSettings.Location = new System.Drawing.Point(0, 450);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSettings.Size = new System.Drawing.Size(250, 50);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "⚙️ الإعدادات";
            this.btnSettings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnSettings.UseAccentColor = false;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.AutoSize = false;
            this.btnReports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReports.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReports.Depth = 0;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.DrawShadows = false;
            this.btnReports.HighEmphasis = false;
            this.btnReports.Icon = null;
            this.btnReports.Location = new System.Drawing.Point(0, 400);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReports.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReports.Name = "btnReports";
            this.btnReports.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReports.Size = new System.Drawing.Size(250, 50);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "📈 التقارير";
            this.btnReports.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnReports.UseAccentColor = false;
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnOperations
            // 
            this.btnOperations.AutoSize = false;
            this.btnOperations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOperations.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOperations.Depth = 0;
            this.btnOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOperations.DrawShadows = false;
            this.btnOperations.HighEmphasis = false;
            this.btnOperations.Icon = null;
            this.btnOperations.Location = new System.Drawing.Point(0, 350);
            this.btnOperations.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOperations.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOperations.Name = "btnOperations";
            this.btnOperations.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOperations.Size = new System.Drawing.Size(250, 50);
            this.btnOperations.TabIndex = 3;
            this.btnOperations.Text = "💼 العمليات";
            this.btnOperations.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnOperations.UseAccentColor = false;
            this.btnOperations.UseVisualStyleBackColor = true;
            // 
            // pnlOperationsSubMenu
            // 
            this.pnlOperationsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.pnlOperationsSubMenu.Controls.Add(this.btnReceipts);
            this.pnlOperationsSubMenu.Controls.Add(this.btnInvoices);
            this.pnlOperationsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperationsSubMenu.Location = new System.Drawing.Point(0, 250);
            this.pnlOperationsSubMenu.Name = "pnlOperationsSubMenu";
            this.pnlOperationsSubMenu.Size = new System.Drawing.Size(250, 100);
            this.pnlOperationsSubMenu.TabIndex = 6;
            this.pnlOperationsSubMenu.Visible = false;
            // 
            // btnReceipts
            // 
            this.btnReceipts.AutoSize = false;
            this.btnReceipts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReceipts.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReceipts.Depth = 0;
            this.btnReceipts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceipts.DrawShadows = false;
            this.btnReceipts.HighEmphasis = false;
            this.btnReceipts.Icon = null;
            this.btnReceipts.Location = new System.Drawing.Point(0, 50);
            this.btnReceipts.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReceipts.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReceipts.Name = "btnReceipts";
            this.btnReceipts.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReceipts.Size = new System.Drawing.Size(250, 50);
            this.btnReceipts.TabIndex = 1;
            this.btnReceipts.Text = "  💰 سندات القبض";
            this.btnReceipts.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnReceipts.UseAccentColor = false;
            this.btnReceipts.UseVisualStyleBackColor = true;
            // 
            // btnInvoices
            // 
            this.btnInvoices.AutoSize = false;
            this.btnInvoices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInvoices.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInvoices.Depth = 0;
            this.btnInvoices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvoices.DrawShadows = false;
            this.btnInvoices.HighEmphasis = false;
            this.btnInvoices.Icon = null;
            this.btnInvoices.Location = new System.Drawing.Point(0, 0);
            this.btnInvoices.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInvoices.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInvoices.Size = new System.Drawing.Size(250, 50);
            this.btnInvoices.TabIndex = 0;
            this.btnInvoices.Text = "  📋 الفواتير";
            this.btnInvoices.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnInvoices.UseAccentColor = false;
            this.btnInvoices.UseVisualStyleBackColor = true;
            // 
            // btnDataManagement
            // 
            this.btnDataManagement.AutoSize = false;
            this.btnDataManagement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDataManagement.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDataManagement.Depth = 0;
            this.btnDataManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDataManagement.DrawShadows = false;
            this.btnDataManagement.HighEmphasis = false;
            this.btnDataManagement.Icon = null;
            this.btnDataManagement.Location = new System.Drawing.Point(0, 200);
            this.btnDataManagement.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDataManagement.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDataManagement.Name = "btnDataManagement";
            this.btnDataManagement.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDataManagement.Size = new System.Drawing.Size(250, 50);
            this.btnDataManagement.TabIndex = 4;
            this.btnDataManagement.Text = "📊 البيانات الأساسية";
            this.btnDataManagement.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnDataManagement.UseAccentColor = false;
            this.btnDataManagement.UseVisualStyleBackColor = true;
            // 
            // pnlDataSubMenu
            // 
            this.pnlDataSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.pnlDataSubMenu.Controls.Add(this.btnContracts);
            this.pnlDataSubMenu.Controls.Add(this.btnTenants);
            this.pnlDataSubMenu.Controls.Add(this.btnApartments);
            this.pnlDataSubMenu.Controls.Add(this.btnBuildings);
            this.pnlDataSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDataSubMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlDataSubMenu.Name = "pnlDataSubMenu";
            this.pnlDataSubMenu.Size = new System.Drawing.Size(250, 200);
            this.pnlDataSubMenu.TabIndex = 5;
            this.pnlDataSubMenu.Visible = false;
            // 
            // btnContracts
            // 
            this.btnContracts.AutoSize = false;
            this.btnContracts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContracts.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnContracts.Depth = 0;
            this.btnContracts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContracts.DrawShadows = false;
            this.btnContracts.HighEmphasis = false;
            this.btnContracts.Icon = null;
            this.btnContracts.Location = new System.Drawing.Point(0, 150);
            this.btnContracts.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnContracts.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnContracts.Size = new System.Drawing.Size(250, 50);
            this.btnContracts.TabIndex = 3;
            this.btnContracts.Text = "  📄 بيانات العقود";
            this.btnContracts.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnContracts.UseAccentColor = false;
            this.btnContracts.UseVisualStyleBackColor = true;
            // 
            // btnTenants
            // 
            this.btnTenants.AutoSize = false;
            this.btnTenants.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTenants.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTenants.Depth = 0;
            this.btnTenants.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTenants.DrawShadows = false;
            this.btnTenants.HighEmphasis = false;
            this.btnTenants.Icon = null;
            this.btnTenants.Location = new System.Drawing.Point(0, 100);
            this.btnTenants.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTenants.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTenants.Name = "btnTenants";
            this.btnTenants.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTenants.Size = new System.Drawing.Size(250, 50);
            this.btnTenants.TabIndex = 2;
            this.btnTenants.Text = "  👥 بيانات المستأجر";
            this.btnTenants.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnTenants.UseAccentColor = false;
            this.btnTenants.UseVisualStyleBackColor = true;
            // 
            // btnApartments
            // 
            this.btnApartments.AutoSize = false;
            this.btnApartments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApartments.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnApartments.Depth = 0;
            this.btnApartments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnApartments.DrawShadows = false;
            this.btnApartments.HighEmphasis = false;
            this.btnApartments.Icon = null;
            this.btnApartments.Location = new System.Drawing.Point(0, 50);
            this.btnApartments.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnApartments.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnApartments.Name = "btnApartments";
            this.btnApartments.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnApartments.Size = new System.Drawing.Size(250, 50);
            this.btnApartments.TabIndex = 1;
            this.btnApartments.Text = "  🏠 بيانات الشقق";
            this.btnApartments.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnApartments.UseAccentColor = false;
            this.btnApartments.UseVisualStyleBackColor = true;
            // 
            // btnBuildings
            // 
            this.btnBuildings.AutoSize = false;
            this.btnBuildings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuildings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuildings.Depth = 0;
            this.btnBuildings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuildings.DrawShadows = false;
            this.btnBuildings.HighEmphasis = false;
            this.btnBuildings.Icon = null;
            this.btnBuildings.Location = new System.Drawing.Point(0, 0);
            this.btnBuildings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuildings.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuildings.Name = "btnBuildings";
            this.btnBuildings.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuildings.Size = new System.Drawing.Size(250, 50);
            this.btnBuildings.TabIndex = 0;
            this.btnBuildings.Text = "  🏢 بيانات العقار";
            this.btnBuildings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnBuildings.UseAccentColor = false;
            this.btnBuildings.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.lblHeaderTitle);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(253, 64);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(944, 633);
            this.pnlContent.TabIndex = 1;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Depth = 0;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(163, 20);
            this.lblHeaderTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(138, 19);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "مرحباً بك في نظام إدارة الإيجارات";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام إدارة إيجارات المباني";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlSidebar.ResumeLayout(false);
            this.pnlOperationsSubMenu.ResumeLayout(false);
            this.pnlDataSubMenu.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private MaterialSkin.Controls.MaterialButton btnMenuToggle;
        private MaterialSkin.Controls.MaterialButton btnSettings;
        private MaterialSkin.Controls.MaterialButton btnReports;
        private MaterialSkin.Controls.MaterialButton btnOperations;
        private System.Windows.Forms.Panel pnlOperationsSubMenu;
        private MaterialSkin.Controls.MaterialButton btnInvoices;
        private MaterialSkin.Controls.MaterialButton btnReceipts;
        private System.Windows.Forms.Panel pnlContent;
        private MaterialSkin.Controls.MaterialLabel lblHeaderTitle;
        private MaterialSkin.Controls.MaterialButton btnDataManagement;
        private System.Windows.Forms.Panel pnlDataSubMenu;
        private MaterialSkin.Controls.MaterialButton btnContracts;
        private MaterialSkin.Controls.MaterialButton btnTenants;
        private MaterialSkin.Controls.MaterialButton btnApartments;
        private MaterialSkin.Controls.MaterialButton btnBuildings;
    }
}
