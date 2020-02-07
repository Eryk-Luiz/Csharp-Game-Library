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
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.btnLogin = new XanderUI.XUIButton();
            this.gameBannerImg = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gameBannerImg)).BeginInit();
            this.SuspendLayout();
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameNameLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.gameNameLabel.Location = new System.Drawing.Point(214, 12);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(179, 37);
            this.gameNameLabel.TabIndex = 1;
            this.gameNameLabel.Text = "Game Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(217, 64);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(512, 62);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(214, 235);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(72, 19);
            this.genreLabel.TabIndex = 3;
            this.genreLabel.Text = "Genero:";
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
            this.btnLogin.Location = new System.Drawing.Point(821, 220);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(143, 34);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // gameBannerImg
            // 
            this.gameBannerImg.BackgroundImage = global::Game_library.Properties.Resources.resident_evil_3;
            this.gameBannerImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameBannerImg.Location = new System.Drawing.Point(20, 12);
            this.gameBannerImg.Name = "gameBannerImg";
            this.gameBannerImg.Size = new System.Drawing.Size(188, 242);
            this.gameBannerImg.TabIndex = 0;
            this.gameBannerImg.TabStop = false;
            // 
            // GameBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.gameNameLabel);
            this.Controls.Add(this.gameBannerImg);
            this.Margin = new System.Windows.Forms.Padding(1, 35, 1, 1);
            this.Name = "GameBanner";
            this.Size = new System.Drawing.Size(988, 264);
            ((System.ComponentModel.ISupportInitialize)(this.gameBannerImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gameBannerImg;
        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label genreLabel;
        private XanderUI.XUIButton btnLogin;
        private System.Windows.Forms.Timer timer1;
    }
}
