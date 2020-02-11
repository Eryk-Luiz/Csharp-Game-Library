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
            this.gameBannerImg = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.label_disc = new System.Windows.Forms.Label();
            this.btnStartGame = new XanderUI.XUIButton();
            this.label_date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameBannerImg)).BeginInit();
            this.SuspendLayout();
            // 
            // gameBannerImg
            // 
            this.gameBannerImg.BackgroundImage = global::Game_library.Properties.Resources.resident_evil_3;
            this.gameBannerImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameBannerImg.Location = new System.Drawing.Point(5, 4);
            this.gameBannerImg.Name = "gameBannerImg";
            this.gameBannerImg.Size = new System.Drawing.Size(174, 206);
            this.gameBannerImg.TabIndex = 0;
            this.gameBannerImg.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel2.Location = new System.Drawing.Point(185, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 2);
            this.panel2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel1.Location = new System.Drawing.Point(185, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 2);
            this.panel1.TabIndex = 14;
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(185, 4);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(418, 23);
            this.label_title.TabIndex = 17;
            this.label_title.Text = "Title";
            // 
            // label_genre
            // 
            this.label_genre.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_genre.ForeColor = System.Drawing.Color.White;
            this.label_genre.Location = new System.Drawing.Point(185, 58);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(416, 23);
            this.label_genre.TabIndex = 18;
            this.label_genre.Text = "genre";
            // 
            // label_disc
            // 
            this.label_disc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_disc.ForeColor = System.Drawing.Color.White;
            this.label_disc.Location = new System.Drawing.Point(187, 103);
            this.label_disc.Name = "label_disc";
            this.label_disc.Size = new System.Drawing.Size(414, 78);
            this.label_disc.TabIndex = 19;
            this.label_disc.Text = "Discription";
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.btnStartGame.ButtonImage = null;
            this.btnStartGame.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnStartGame.ButtonText = "Start Game";
            this.btnStartGame.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnStartGame.ClickTextColor = System.Drawing.Color.White;
            this.btnStartGame.CornerRadius = 5;
            this.btnStartGame.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnStartGame.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnStartGame.HoverTextColor = System.Drawing.Color.White;
            this.btnStartGame.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnStartGame.Location = new System.Drawing.Point(639, 6);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(179, 204);
            this.btnStartGame.TabIndex = 20;
            this.btnStartGame.TextColor = System.Drawing.Color.White;
            this.btnStartGame.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // label_date
            // 
            this.label_date.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.Black;
            this.label_date.Location = new System.Drawing.Point(194, 187);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(418, 23);
            this.label_date.TabIndex = 21;
            this.label_date.Text = "Date";
            // 
            // GameBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.label_disc);
            this.Controls.Add(this.label_genre);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gameBannerImg);
            this.Margin = new System.Windows.Forms.Padding(75, 25, 1, 1);
            this.Name = "GameBanner";
            this.Size = new System.Drawing.Size(833, 217);
            ((System.ComponentModel.ISupportInitialize)(this.gameBannerImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gameBannerImg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.Label label_disc;
        private XanderUI.XUIButton btnStartGame;
        private System.Windows.Forms.Label label_date;
    }
}
