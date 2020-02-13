﻿namespace Game_library
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
            this.logo = new XanderUI.XUICustomPictureBox();
            this.WindowsMinimize = new System.Windows.Forms.Panel();
            this.WindowClose = new System.Windows.Forms.Panel();
            this.labelLoggedUser = new System.Windows.Forms.Label();
            this.PanelAsideLeft = new System.Windows.Forms.Panel();
            this.btnEditGame = new XanderUI.XUIButton();
            this.btnLibrary = new XanderUI.XUIButton();
            this.btnNewGame = new XanderUI.XUIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLibrary = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.HeaderPanel.SuspendLayout();
            this.PanelAsideLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.HeaderPanel.Controls.Add(this.logo);
            this.HeaderPanel.Controls.Add(this.WindowsMinimize);
            this.HeaderPanel.Controls.Add(this.WindowClose);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1162, 54);
            this.HeaderPanel.TabIndex = 1;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
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
            this.logo.Location = new System.Drawing.Point(526, -15);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(110, 83);
            this.logo.TabIndex = 5;
            this.logo.Text = "xuiCustomPictureBox1";
            // 
            // WindowsMinimize
            // 
            this.WindowsMinimize.BackgroundImage = global::Game_library.Properties.Resources.minimizeWindow_24px;
            this.WindowsMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WindowsMinimize.Location = new System.Drawing.Point(1080, 12);
            this.WindowsMinimize.Name = "WindowsMinimize";
            this.WindowsMinimize.Size = new System.Drawing.Size(33, 30);
            this.WindowsMinimize.TabIndex = 4;
            this.WindowsMinimize.Click += new System.EventHandler(this.panel6_Click);
            // 
            // WindowClose
            // 
            this.WindowClose.BackgroundImage = global::Game_library.Properties.Resources.closeWindow_24px;
            this.WindowClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WindowClose.Location = new System.Drawing.Point(1118, 12);
            this.WindowClose.Name = "WindowClose";
            this.WindowClose.Size = new System.Drawing.Size(33, 30);
            this.WindowClose.TabIndex = 3;
            this.WindowClose.Click += new System.EventHandler(this.panel5_Click);
            // 
            // labelLoggedUser
            // 
            this.labelLoggedUser.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoggedUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.labelLoggedUser.Location = new System.Drawing.Point(12, 556);
            this.labelLoggedUser.Name = "labelLoggedUser";
            this.labelLoggedUser.Size = new System.Drawing.Size(117, 35);
            this.labelLoggedUser.TabIndex = 6;
            this.labelLoggedUser.Text = "USER";
            this.labelLoggedUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelAsideLeft
            // 
            this.PanelAsideLeft.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PanelAsideLeft.Controls.Add(this.btnEditGame);
            this.PanelAsideLeft.Controls.Add(this.labelLoggedUser);
            this.PanelAsideLeft.Controls.Add(this.btnLibrary);
            this.PanelAsideLeft.Controls.Add(this.btnNewGame);
            this.PanelAsideLeft.Controls.Add(this.panel1);
            this.PanelAsideLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelAsideLeft.Location = new System.Drawing.Point(0, 54);
            this.PanelAsideLeft.Margin = new System.Windows.Forms.Padding(2);
            this.PanelAsideLeft.Name = "PanelAsideLeft";
            this.PanelAsideLeft.Size = new System.Drawing.Size(137, 600);
            this.PanelAsideLeft.TabIndex = 2;
            // 
            // btnEditGame
            // 
            this.btnEditGame.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEditGame.ButtonImage = null;
            this.btnEditGame.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnEditGame.ButtonText = "EDIT GAME";
            this.btnEditGame.ClickBackColor = System.Drawing.Color.Transparent;
            this.btnEditGame.ClickTextColor = System.Drawing.Color.White;
            this.btnEditGame.CornerRadius = 5;
            this.btnEditGame.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGame.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEditGame.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnEditGame.HoverTextColor = System.Drawing.Color.White;
            this.btnEditGame.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnEditGame.Location = new System.Drawing.Point(-1, 272);
            this.btnEditGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditGame.Name = "btnEditGame";
            this.btnEditGame.Size = new System.Drawing.Size(139, 59);
            this.btnEditGame.TabIndex = 7;
            this.btnEditGame.TextColor = System.Drawing.Color.White;
            this.btnEditGame.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEditGame.Click += new System.EventHandler(this.btnEditGame_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLibrary.ButtonImage = null;
            this.btnLibrary.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnLibrary.ButtonText = "LIBRARY";
            this.btnLibrary.ClickBackColor = System.Drawing.Color.Transparent;
            this.btnLibrary.ClickTextColor = System.Drawing.Color.White;
            this.btnLibrary.CornerRadius = 5;
            this.btnLibrary.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrary.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLibrary.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnLibrary.HoverTextColor = System.Drawing.Color.White;
            this.btnLibrary.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnLibrary.Location = new System.Drawing.Point(-1, 146);
            this.btnLibrary.Margin = new System.Windows.Forms.Padding(2);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(139, 59);
            this.btnLibrary.TabIndex = 3;
            this.btnLibrary.TextColor = System.Drawing.Color.White;
            this.btnLibrary.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNewGame.ButtonImage = null;
            this.btnNewGame.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnNewGame.ButtonText = "NEW GAME";
            this.btnNewGame.ClickBackColor = System.Drawing.Color.Transparent;
            this.btnNewGame.ClickTextColor = System.Drawing.Color.White;
            this.btnNewGame.CornerRadius = 5;
            this.btnNewGame.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNewGame.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnNewGame.HoverTextColor = System.Drawing.Color.White;
            this.btnNewGame.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnNewGame.Location = new System.Drawing.Point(-1, 209);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(139, 59);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.TextColor = System.Drawing.Color.White;
            this.btnNewGame.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 2);
            this.panel1.TabIndex = 0;
            // 
            // panelLibrary
            // 
            this.panelLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLibrary.Location = new System.Drawing.Point(137, 54);
            this.panelLibrary.Name = "panelLibrary";
            this.panelLibrary.Size = new System.Drawing.Size(1025, 600);
            this.panelLibrary.TabIndex = 3;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Column1";
            this.dataGridViewImageColumn1.Image = global::Game_library.Properties.Resources.Logo_ico;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 654);
            this.Controls.Add(this.panelLibrary);
            this.Controls.Add(this.PanelAsideLeft);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Library";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.PanelAsideLeft.ResumeLayout(false);
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
        private XanderUI.XUIButton btnNewGame;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private XanderUI.XUIButton btnLibrary;
        public System.Windows.Forms.Panel panelLibrary;
        private XanderUI.XUIButton btnEditGame;
    }
}