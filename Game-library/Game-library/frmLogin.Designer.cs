﻿namespace Game_library
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.textLogin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textPasswd = new System.Windows.Forms.TextBox();
            this.btnLogin = new XanderUI.XUIButton();
            this.btnCadastrar = new XanderUI.XUIButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xuiCustomPictureBox1 = new XanderUI.XUICustomPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textLogin
            // 
            this.textLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.textLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLogin.ForeColor = System.Drawing.Color.White;
            this.textLogin.HideSelection = false;
            this.textLogin.Location = new System.Drawing.Point(49, 124);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(242, 24);
            this.textLogin.TabIndex = 1;
            this.textLogin.TabStop = false;
            this.textLogin.Text = "Username";
            this.textLogin.Click += new System.EventHandler(this.textLogin_Click);
            this.textLogin.Leave += new System.EventHandler(this.textLogin_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(49, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 2);
            this.panel1.TabIndex = 2;
            // 
            // textPasswd
            // 
            this.textPasswd.BackColor = System.Drawing.SystemColors.Highlight;
            this.textPasswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPasswd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPasswd.ForeColor = System.Drawing.Color.White;
            this.textPasswd.HideSelection = false;
            this.textPasswd.Location = new System.Drawing.Point(49, 191);
            this.textPasswd.Name = "textPasswd";
            this.textPasswd.Size = new System.Drawing.Size(242, 24);
            this.textPasswd.TabIndex = 3;
            this.textPasswd.TabStop = false;
            this.textPasswd.Text = "Password";
            this.textPasswd.Click += new System.EventHandler(this.textPasswd_Click);
            this.textPasswd.Leave += new System.EventHandler(this.textPasswd_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.btnLogin.ButtonImage = null;
            this.btnLogin.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnLogin.ClickTextColor = System.Drawing.Color.White;
            this.btnLogin.CornerRadius = 5;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLogin.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnLogin.HoverTextColor = System.Drawing.Color.White;
            this.btnLogin.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnLogin.Location = new System.Drawing.Point(49, 275);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(250, 34);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.btnCadastrar.ButtonImage = null;
            this.btnCadastrar.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnCadastrar.ButtonText = "Create Account";
            this.btnCadastrar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnCadastrar.ClickTextColor = System.Drawing.Color.White;
            this.btnCadastrar.CornerRadius = 5;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCadastrar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCadastrar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnCadastrar.HoverTextColor = System.Drawing.Color.White;
            this.btnCadastrar.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnCadastrar.Location = new System.Drawing.Point(49, 327);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(250, 34);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.TextColor = System.Drawing.Color.White;
            this.btnCadastrar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(49, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 2);
            this.panel2.TabIndex = 3;
            // 
            // xuiCustomPictureBox1
            // 
            this.xuiCustomPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.xuiCustomPictureBox1.BackgroundImage = global::Game_library.Properties.Resources.Logo;
            this.xuiCustomPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.xuiCustomPictureBox1.Color1 = System.Drawing.Color.Transparent;
            this.xuiCustomPictureBox1.Color2 = System.Drawing.Color.Transparent;
            this.xuiCustomPictureBox1.FilterAlpha = 200;
            this.xuiCustomPictureBox1.FilterEnabled = true;
            this.xuiCustomPictureBox1.Image = null;
            this.xuiCustomPictureBox1.IsElipse = false;
            this.xuiCustomPictureBox1.IsParallax = false;
            this.xuiCustomPictureBox1.Location = new System.Drawing.Point(56, 3);
            this.xuiCustomPictureBox1.Name = "xuiCustomPictureBox1";
            this.xuiCustomPictureBox1.Size = new System.Drawing.Size(237, 115);
            this.xuiCustomPictureBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(82, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 23);
            this.label2.TabIndex = 7;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(348, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textPasswd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.xuiCustomPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUICustomPictureBox xuiCustomPictureBox1;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textPasswd;
        private XanderUI.XUIButton btnLogin;
        private XanderUI.XUIButton btnCadastrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

