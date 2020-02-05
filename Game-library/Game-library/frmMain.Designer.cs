namespace Game_library
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.labelLoggedUser = new System.Windows.Forms.Label();
            this.logo = new XanderUI.XUICustomPictureBox();
            this.WindowsMinimize = new System.Windows.Forms.Panel();
            this.WindowClose = new System.Windows.Forms.Panel();
            this.PanelAsideLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.libraryPanel = new System.Windows.Forms.Panel();
            this.btnLibrary = new XanderUI.XUIButton();
            this.btnSettings = new XanderUI.XUIButton();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.HeaderPanel.SuspendLayout();
            this.PanelAsideLeft.SuspendLayout();
            this.libraryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.HeaderPanel.Controls.Add(this.labelLoggedUser);
            this.HeaderPanel.Controls.Add(this.logo);
            this.HeaderPanel.Controls.Add(this.WindowsMinimize);
            this.HeaderPanel.Controls.Add(this.WindowClose);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1695, 66);
            this.HeaderPanel.TabIndex = 1;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            // 
            // labelLoggedUser
            // 
            this.labelLoggedUser.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoggedUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.labelLoggedUser.Location = new System.Drawing.Point(639, 9);
            this.labelLoggedUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoggedUser.Name = "labelLoggedUser";
            this.labelLoggedUser.Size = new System.Drawing.Size(415, 54);
            this.labelLoggedUser.TabIndex = 6;
            this.labelLoggedUser.Text = "USER";
            this.labelLoggedUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::Game_library.Properties.Resources.Logo;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Color1 = System.Drawing.Color.DodgerBlue;
            this.logo.Color2 = System.Drawing.Color.DodgerBlue;
            this.logo.FilterAlpha = 200;
            this.logo.FilterEnabled = true;
            this.logo.Image = null;
            this.logo.IsElipse = false;
            this.logo.IsParallax = false;
            this.logo.Location = new System.Drawing.Point(13, -15);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(146, 102);
            this.logo.TabIndex = 5;
            this.logo.Text = "xuiCustomPictureBox1";
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // WindowsMinimize
            // 
            this.WindowsMinimize.BackgroundImage = global::Game_library.Properties.Resources.minimizeWindow_24px;
            this.WindowsMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WindowsMinimize.Location = new System.Drawing.Point(1581, 15);
            this.WindowsMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WindowsMinimize.Name = "WindowsMinimize";
            this.WindowsMinimize.Size = new System.Drawing.Size(44, 37);
            this.WindowsMinimize.TabIndex = 4;
            this.WindowsMinimize.Click += new System.EventHandler(this.panel6_Click);
            // 
            // WindowClose
            // 
            this.WindowClose.BackgroundImage = global::Game_library.Properties.Resources.closeWindow_24px;
            this.WindowClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WindowClose.Location = new System.Drawing.Point(1633, 15);
            this.WindowClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WindowClose.Name = "WindowClose";
            this.WindowClose.Size = new System.Drawing.Size(44, 37);
            this.WindowClose.TabIndex = 3;
            this.WindowClose.Click += new System.EventHandler(this.panel5_Click);
            // 
            // PanelAsideLeft
            // 
            this.PanelAsideLeft.BackColor = System.Drawing.SystemColors.Highlight;
            this.PanelAsideLeft.Controls.Add(this.btnSettings);
            this.PanelAsideLeft.Controls.Add(this.btnLibrary);
            this.PanelAsideLeft.Controls.Add(this.panel1);
            this.PanelAsideLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelAsideLeft.Location = new System.Drawing.Point(0, 66);
            this.PanelAsideLeft.Name = "PanelAsideLeft";
            this.PanelAsideLeft.Size = new System.Drawing.Size(183, 829);
            this.PanelAsideLeft.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 2);
            this.panel1.TabIndex = 0;
            // 
            // libraryPanel
            // 
            this.libraryPanel.Controls.Add(this.xuiButton1);
            this.libraryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryPanel.Location = new System.Drawing.Point(183, 66);
            this.libraryPanel.Name = "libraryPanel";
            this.libraryPanel.Size = new System.Drawing.Size(1512, 829);
            this.libraryPanel.TabIndex = 3;
            // 
            // btnLibrary
            // 
            this.btnLibrary.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLibrary.ButtonImage = null;
            this.btnLibrary.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnLibrary.ButtonText = "Library";
            this.btnLibrary.ClickBackColor = System.Drawing.Color.Transparent;
            this.btnLibrary.ClickTextColor = System.Drawing.Color.White;
            this.btnLibrary.CornerRadius = 5;
            this.btnLibrary.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrary.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLibrary.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.btnLibrary.HoverTextColor = System.Drawing.Color.White;
            this.btnLibrary.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnLibrary.Location = new System.Drawing.Point(0, 338);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(183, 73);
            this.btnLibrary.TabIndex = 1;
            this.btnLibrary.TextColor = System.Drawing.Color.White;
            this.btnLibrary.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSettings.ButtonImage = null;
            this.btnSettings.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnSettings.ButtonText = "Settings";
            this.btnSettings.ClickBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.ClickTextColor = System.Drawing.Color.White;
            this.btnSettings.CornerRadius = 5;
            this.btnSettings.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSettings.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.btnSettings.HoverTextColor = System.Drawing.Color.White;
            this.btnSettings.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSettings.Location = new System.Drawing.Point(0, 417);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(183, 73);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.TextColor = System.Drawing.Color.White;
            this.btnSettings.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.xuiButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton1.ButtonImage")));
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.Dark;
            this.xuiButton1.ButtonText = "Button";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(27, 28);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(200, 50);
            this.xuiButton1.TabIndex = 0;
            this.xuiButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1695, 895);
            this.Controls.Add(this.libraryPanel);
            this.Controls.Add(this.PanelAsideLeft);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0;0;0;0";
            this.HeaderPanel.ResumeLayout(false);
            this.PanelAsideLeft.ResumeLayout(false);
            this.libraryPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel WindowClose;
        private System.Windows.Forms.Panel WindowsMinimize;
        private XanderUI.XUICustomPictureBox logo;
        private System.Windows.Forms.Label labelLoggedUser;
        private System.Windows.Forms.Panel PanelAsideLeft;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton btnLibrary;
        private System.Windows.Forms.Panel libraryPanel;
        private XanderUI.XUIButton btnSettings;
        private XanderUI.XUIButton xuiButton1;
    }
}