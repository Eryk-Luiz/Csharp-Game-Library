namespace Game_library
{
    partial class GameBanner
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLogin = new XanderUI.XUIButton();
            this.gameBannerImg = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.label_disc = new System.Windows.Forms.Label();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.label_date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameBannerImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.btnLogin.ButtonImage = null;
            this.btnLogin.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnLogin.ButtonText = "View More";
            this.btnLogin.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnLogin.ClickTextColor = System.Drawing.Color.White;
            this.btnLogin.CornerRadius = 5;
            this.btnLogin.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnLogin.HoverTextColor = System.Drawing.Color.White;
            this.btnLogin.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnLogin.Location = new System.Drawing.Point(892, 202);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(191, 42);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // gameBannerImg
            // 
            this.gameBannerImg.BackgroundImage = global::Game_library.Properties.Resources.resident_evil_3;
            this.gameBannerImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameBannerImg.Location = new System.Drawing.Point(4, 4);
            this.gameBannerImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gameBannerImg.Name = "gameBannerImg";
            this.gameBannerImg.Size = new System.Drawing.Size(273, 287);
            this.gameBannerImg.TabIndex = 0;
            this.gameBannerImg.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel2.Location = new System.Drawing.Point(285, 124);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 2);
            this.panel2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel1.Location = new System.Drawing.Point(285, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 2);
            this.panel1.TabIndex = 14;
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(285, 26);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(557, 28);
            this.label_title.TabIndex = 17;
            this.label_title.Text = "Title";
            // 
            // label_genre
            // 
            this.label_genre.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_genre.ForeColor = System.Drawing.Color.White;
            this.label_genre.Location = new System.Drawing.Point(285, 92);
            this.label_genre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(555, 28);
            this.label_genre.TabIndex = 18;
            this.label_genre.Text = "genre";
            // 
            // label_disc
            // 
            this.label_disc.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_disc.ForeColor = System.Drawing.Color.White;
            this.label_disc.Location = new System.Drawing.Point(288, 148);
            this.label_disc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_disc.Name = "label_disc";
            this.label_disc.Size = new System.Drawing.Size(552, 96);
            this.label_disc.TabIndex = 19;
            this.label_disc.Text = "Discription";
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.xuiButton1.ButtonImage = null;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.xuiButton1.ButtonText = "Start Game";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(892, 26);
            this.xuiButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(191, 153);
            this.xuiButton1.TabIndex = 20;
            this.xuiButton1.TextColor = System.Drawing.Color.White;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // label_date
            // 
            this.label_date.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.Black;
            this.label_date.Location = new System.Drawing.Point(283, 263);
            this.label_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(557, 28);
            this.label_date.TabIndex = 21;
            this.label_date.Text = "Date";
            // 
            // GameBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.xuiButton1);
            this.Controls.Add(this.label_disc);
            this.Controls.Add(this.label_genre);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.gameBannerImg);
            this.Margin = new System.Windows.Forms.Padding(100, 43, 1, 1);
            this.Name = "GameBanner";
            this.Size = new System.Drawing.Size(1111, 299);
            ((System.ComponentModel.ISupportInitialize)(this.gameBannerImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gameBannerImg;
        private XanderUI.XUIButton btnLogin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.Label label_disc;
        private XanderUI.XUIButton xuiButton1;
        private System.Windows.Forms.Label label_date;
    }
}
