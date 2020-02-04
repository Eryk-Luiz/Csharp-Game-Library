namespace Game_library
{
    partial class frmCadastro
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNewUser = new XanderUI.XUIButton();
            this.textNewPasswd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textNewUser = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textConfirmPasswd = new System.Windows.Forms.TextBox();
            this.btnCancelar = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(45, 124);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 2);
            this.panel2.TabIndex = 8;
            // 
            // btnNewUser
            // 
            this.btnNewUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.btnNewUser.ButtonImage = null;
            this.btnNewUser.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnNewUser.ButtonText = "New User";
            this.btnNewUser.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnNewUser.ClickTextColor = System.Drawing.Color.White;
            this.btnNewUser.CornerRadius = 5;
            this.btnNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnNewUser.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNewUser.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnNewUser.HoverTextColor = System.Drawing.Color.White;
            this.btnNewUser.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnNewUser.Location = new System.Drawing.Point(45, 261);
            this.btnNewUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(333, 42);
            this.btnNewUser.TabIndex = 11;
            this.btnNewUser.TextColor = System.Drawing.Color.White;
            this.btnNewUser.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // textNewPasswd
            // 
            this.textNewPasswd.BackColor = System.Drawing.SystemColors.Highlight;
            this.textNewPasswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNewPasswd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNewPasswd.ForeColor = System.Drawing.Color.White;
            this.textNewPasswd.HideSelection = false;
            this.textNewPasswd.Location = new System.Drawing.Point(45, 93);
            this.textNewPasswd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNewPasswd.Name = "textNewPasswd";
            this.textNewPasswd.Size = new System.Drawing.Size(323, 24);
            this.textNewPasswd.TabIndex = 9;
            this.textNewPasswd.TabStop = false;
            this.textNewPasswd.Text = "Password";
            this.textNewPasswd.Click += new System.EventHandler(this.textNewPasswd_Click);
            this.textNewPasswd.Leave += new System.EventHandler(this.textNewPasswd_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(45, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 2);
            this.panel1.TabIndex = 7;
            // 
            // textNewUser
            // 
            this.textNewUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.textNewUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNewUser.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNewUser.ForeColor = System.Drawing.Color.White;
            this.textNewUser.HideSelection = false;
            this.textNewUser.Location = new System.Drawing.Point(45, 35);
            this.textNewUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNewUser.Name = "textNewUser";
            this.textNewUser.Size = new System.Drawing.Size(323, 24);
            this.textNewUser.TabIndex = 6;
            this.textNewUser.TabStop = false;
            this.textNewUser.Text = "Username";
            this.textNewUser.Click += new System.EventHandler(this.textNewUser_Click);
            this.textNewUser.Leave += new System.EventHandler(this.textNewUser_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(45, 184);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 2);
            this.panel3.TabIndex = 10;
            // 
            // textConfirmPasswd
            // 
            this.textConfirmPasswd.BackColor = System.Drawing.SystemColors.Highlight;
            this.textConfirmPasswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textConfirmPasswd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConfirmPasswd.ForeColor = System.Drawing.Color.White;
            this.textConfirmPasswd.HideSelection = false;
            this.textConfirmPasswd.Location = new System.Drawing.Point(45, 160);
            this.textConfirmPasswd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textConfirmPasswd.Name = "textConfirmPasswd";
            this.textConfirmPasswd.Size = new System.Drawing.Size(323, 24);
            this.textConfirmPasswd.TabIndex = 11;
            this.textConfirmPasswd.TabStop = false;
            this.textConfirmPasswd.Text = "Confirm Password";
            this.textConfirmPasswd.Click += new System.EventHandler(this.textConfirmPasswd_Click);
            this.textConfirmPasswd.Leave += new System.EventHandler(this.textConfirmPasswd_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.btnCancelar.ButtonImage = null;
            this.btnCancelar.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnCancelar.ButtonText = "Cancel";
            this.btnCancelar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnCancelar.ClickTextColor = System.Drawing.Color.White;
            this.btnCancelar.CornerRadius = 5;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCancelar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancelar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnCancelar.HoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnCancelar.Location = new System.Drawing.Point(45, 322);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(333, 42);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(422, 429);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textConfirmPasswd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.textNewPasswd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textNewUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private XanderUI.XUIButton btnNewUser;
        private System.Windows.Forms.TextBox textNewPasswd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textNewUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textConfirmPasswd;
        private XanderUI.XUIButton btnCancelar;
    }
}