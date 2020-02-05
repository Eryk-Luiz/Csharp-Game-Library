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
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.WindowsMinimize = new System.Windows.Forms.Panel();
            this.WindowClose = new System.Windows.Forms.Panel();
            this.logo = new XanderUI.XUICustomPictureBox();
            this.labelLoggedUser = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
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
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1271, 48);
            this.HeaderPanel.TabIndex = 1;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            // 
            // WindowsMinimize
            // 
            this.WindowsMinimize.BackgroundImage = global::Game_library.Properties.Resources.minimizeWindow_24px;
            this.WindowsMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WindowsMinimize.Location = new System.Drawing.Point(1186, 12);
            this.WindowsMinimize.Name = "WindowsMinimize";
            this.WindowsMinimize.Size = new System.Drawing.Size(33, 30);
            this.WindowsMinimize.TabIndex = 4;
            this.WindowsMinimize.Click += new System.EventHandler(this.panel6_Click);
            // 
            // WindowClose
            // 
            this.WindowClose.BackgroundImage = global::Game_library.Properties.Resources.closeWindow_24px;
            this.WindowClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WindowClose.Location = new System.Drawing.Point(1225, 12);
            this.WindowClose.Name = "WindowClose";
            this.WindowClose.Size = new System.Drawing.Size(33, 30);
            this.WindowClose.TabIndex = 3;
            this.WindowClose.Click += new System.EventHandler(this.panel5_Click);
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
            this.logo.Location = new System.Drawing.Point(-11, -16);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(95, 80);
            this.logo.TabIndex = 5;
            this.logo.Text = "xuiCustomPictureBox1";
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // labelLoggedUser
            // 
            this.labelLoggedUser.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoggedUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.labelLoggedUser.Location = new System.Drawing.Point(472, 12);
            this.labelLoggedUser.Name = "labelLoggedUser";
            this.labelLoggedUser.Size = new System.Drawing.Size(311, 23);
            this.labelLoggedUser.TabIndex = 6;
            this.labelLoggedUser.Text = "USER";
            this.labelLoggedUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1271, 727);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.HeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel WindowClose;
        private System.Windows.Forms.Panel WindowsMinimize;
        private XanderUI.XUICustomPictureBox logo;
        private System.Windows.Forms.Label labelLoggedUser;
    }
}