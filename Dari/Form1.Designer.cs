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
            this.components = new System.ComponentModel.Container();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnDataManagement = new MaterialSkin.Controls.MaterialButton();
            this.btnOperations = new MaterialSkin.Controls.MaterialButton();
            this.btnReports = new MaterialSkin.Controls.MaterialButton();
            this.btnSettings = new MaterialSkin.Controls.MaterialButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new MaterialSkin.Controls.MaterialLabel();
            this.btnMenuToggle = new MaterialSkin.Controls.MaterialButton();
            this.pnlSidebar.SuspendLayout();
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
            this.pnlSidebar.Controls.Add(this.btnDataManagement);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 700);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnMenuToggle
            // 
            this.btnMenuToggle.AutoSize = false;
            this.btnMenuToggle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMenuToggle.Depth = 0;
            this.btnMenuToggle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuToggle.DrawShadows = false;
            this.btnMenuToggle.HighEmphasis = false;
            this.btnMenuToggle.Icon = null;
            this.btnMenuToggle.Location = new System.Drawing.Point(0, 0);
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
            this.btnSettings.Depth = 0;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.DrawShadows = false;
            this.btnSettings.HighEmphasis = false;
            this.btnSettings.Icon = null;
            this.btnSettings.Location = new System.Drawing.Point(0, 50);
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
            this.btnReports.Depth = 0;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.DrawShadows = false;
            this.btnReports.HighEmphasis = false;
            this.btnReports.Icon = null;
            this.btnReports.Location = new System.Drawing.Point(0, 100);
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
            this.btnOperations.Depth = 0;
            this.btnOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOperations.DrawShadows = false;
            this.btnOperations.HighEmphasis = false;
            this.btnOperations.Icon = null;
            this.btnOperations.Location = new System.Drawing.Point(0, 150);
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
            // btnDataManagement
            // 
            this.btnDataManagement.AutoSize = false;
            this.btnDataManagement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.lblHeaderTitle);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(250, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(950, 700);
            this.pnlContent.TabIndex = 1;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Depth = 0;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 20);
            this.lblHeaderTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(200, 19);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "مرحباً بك في نظام إدارة الإيجارات";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام إدارة إيجارات المباني";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.pnlSidebar.ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialButton btnDataManagement;
        private System.Windows.Forms.Panel pnlContent;
        private MaterialSkin.Controls.MaterialLabel lblHeaderTitle;
    }
}
