namespace Game_library
{
    partial class New_Game
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
            this.previewBoxImg = new System.Windows.Forms.PictureBox();
            this.btnSaveGame = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_title = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text_genre = new System.Windows.Forms.TextBox();
            this.text_description = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.text_imgFile = new System.Windows.Forms.TextBox();
            this.btnSearchImg = new XanderUI.XUIButton();
            this.btnSearchGamePath = new XanderUI.XUIButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.text_gameFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previewBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // previewBoxImg
            // 
            this.previewBoxImg.BackgroundImage = global::Game_library.Properties.Resources.Logo;
            this.previewBoxImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previewBoxImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewBoxImg.InitialImage = global::Game_library.Properties.Resources.Logo;
            this.previewBoxImg.Location = new System.Drawing.Point(821, 72);
            this.previewBoxImg.Name = "previewBoxImg";
            this.previewBoxImg.Size = new System.Drawing.Size(253, 305);
            this.previewBoxImg.TabIndex = 0;
            this.previewBoxImg.TabStop = false;
            // 
            // btnSaveGame
            // 
            this.btnSaveGame.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.btnSaveGame.ButtonImage = null;
            this.btnSaveGame.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnSaveGame.ButtonText = "Save";
            this.btnSaveGame.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnSaveGame.ClickTextColor = System.Drawing.Color.White;
            this.btnSaveGame.CornerRadius = 5;
            this.btnSaveGame.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGame.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSaveGame.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnSaveGame.HoverTextColor = System.Drawing.Color.White;
            this.btnSaveGame.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSaveGame.Location = new System.Drawing.Point(944, 578);
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.Size = new System.Drawing.Size(164, 51);
            this.btnSaveGame.TabIndex = 6;
            this.btnSaveGame.TextColor = System.Drawing.Color.White;
            this.btnSaveGame.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(861, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "PreView";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel1.Location = new System.Drawing.Point(50, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 2);
            this.panel1.TabIndex = 9;
            // 
            // text_title
            // 
            this.text_title.BackColor = System.Drawing.Color.White;
            this.text_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_title.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_title.ForeColor = System.Drawing.Color.Black;
            this.text_title.HideSelection = false;
            this.text_title.Location = new System.Drawing.Point(50, 122);
            this.text_title.Name = "text_title";
            this.text_title.Size = new System.Drawing.Size(378, 29);
            this.text_title.TabIndex = 8;
            this.text_title.TabStop = false;
            this.text_title.Text = "Tittle";
            this.text_title.Click += new System.EventHandler(this.text_title_Click);
            this.text_title.Leave += new System.EventHandler(this.text_title_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel2.Location = new System.Drawing.Point(50, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 2);
            this.panel2.TabIndex = 12;
            // 
            // text_genre
            // 
            this.text_genre.BackColor = System.Drawing.Color.White;
            this.text_genre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_genre.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_genre.ForeColor = System.Drawing.Color.Black;
            this.text_genre.HideSelection = false;
            this.text_genre.Location = new System.Drawing.Point(50, 200);
            this.text_genre.Name = "text_genre";
            this.text_genre.Size = new System.Drawing.Size(416, 29);
            this.text_genre.TabIndex = 11;
            this.text_genre.TabStop = false;
            this.text_genre.Text = "Genre";
            this.text_genre.Click += new System.EventHandler(this.text_genre_Click);
            this.text_genre.Leave += new System.EventHandler(this.text_genre_Leave);
            // 
            // text_description
            // 
            this.text_description.BackColor = System.Drawing.Color.White;
            this.text_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_description.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_description.ForeColor = System.Drawing.Color.Black;
            this.text_description.HideSelection = false;
            this.text_description.Location = new System.Drawing.Point(50, 512);
            this.text_description.Multiline = true;
            this.text_description.Name = "text_description";
            this.text_description.Size = new System.Drawing.Size(854, 117);
            this.text_description.TabIndex = 13;
            this.text_description.TabStop = false;
            this.text_description.Text = "Description";
            this.text_description.Click += new System.EventHandler(this.text_description_Click);
            this.text_description.Leave += new System.EventHandler(this.text_description_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel3.Location = new System.Drawing.Point(19, 644);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 2);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel4.Location = new System.Drawing.Point(50, 335);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(632, 2);
            this.panel4.TabIndex = 14;
            // 
            // text_imgFile
            // 
            this.text_imgFile.BackColor = System.Drawing.Color.White;
            this.text_imgFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_imgFile.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_imgFile.ForeColor = System.Drawing.Color.Black;
            this.text_imgFile.HideSelection = false;
            this.text_imgFile.Location = new System.Drawing.Point(48, 300);
            this.text_imgFile.Name = "text_imgFile";
            this.text_imgFile.Size = new System.Drawing.Size(632, 29);
            this.text_imgFile.TabIndex = 13;
            this.text_imgFile.TabStop = false;
            this.text_imgFile.Text = "Image File";
            this.text_imgFile.Click += new System.EventHandler(this.text_imgFile_Click);
            this.text_imgFile.TextChanged += new System.EventHandler(this.text_imgFile_TextChanged);
            this.text_imgFile.Leave += new System.EventHandler(this.text_imgFile_Leave);
            // 
            // btnSearchImg
            // 
            this.btnSearchImg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.btnSearchImg.ButtonImage = null;
            this.btnSearchImg.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnSearchImg.ButtonText = "Search";
            this.btnSearchImg.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnSearchImg.ClickTextColor = System.Drawing.Color.White;
            this.btnSearchImg.CornerRadius = 5;
            this.btnSearchImg.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchImg.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearchImg.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnSearchImg.HoverTextColor = System.Drawing.Color.White;
            this.btnSearchImg.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSearchImg.Location = new System.Drawing.Point(50, 343);
            this.btnSearchImg.Name = "btnSearchImg";
            this.btnSearchImg.Size = new System.Drawing.Size(112, 34);
            this.btnSearchImg.TabIndex = 15;
            this.btnSearchImg.TextColor = System.Drawing.Color.White;
            this.btnSearchImg.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearchImg.Click += new System.EventHandler(this.btnSearchImg_Click);
            // 
            // btnSearchGamePath
            // 
            this.btnSearchGamePath.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.btnSearchGamePath.ButtonImage = null;
            this.btnSearchGamePath.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnSearchGamePath.ButtonText = "Search";
            this.btnSearchGamePath.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnSearchGamePath.ClickTextColor = System.Drawing.Color.White;
            this.btnSearchGamePath.CornerRadius = 5;
            this.btnSearchGamePath.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchGamePath.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearchGamePath.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnSearchGamePath.HoverTextColor = System.Drawing.Color.White;
            this.btnSearchGamePath.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSearchGamePath.Location = new System.Drawing.Point(50, 454);
            this.btnSearchGamePath.Name = "btnSearchGamePath";
            this.btnSearchGamePath.Size = new System.Drawing.Size(112, 34);
            this.btnSearchGamePath.TabIndex = 19;
            this.btnSearchGamePath.TextColor = System.Drawing.Color.White;
            this.btnSearchGamePath.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearchGamePath.Click += new System.EventHandler(this.btnSearchGamePath_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel5.Location = new System.Drawing.Point(50, 440);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(633, 2);
            this.panel5.TabIndex = 18;
            // 
            // text_gameFile
            // 
            this.text_gameFile.BackColor = System.Drawing.Color.White;
            this.text_gameFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_gameFile.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_gameFile.ForeColor = System.Drawing.Color.Black;
            this.text_gameFile.HideSelection = false;
            this.text_gameFile.Location = new System.Drawing.Point(50, 405);
            this.text_gameFile.Name = "text_gameFile";
            this.text_gameFile.Size = new System.Drawing.Size(630, 29);
            this.text_gameFile.TabIndex = 17;
            this.text_gameFile.TabStop = false;
            this.text_gameFile.Text = "Game Path";
            this.text_gameFile.Click += new System.EventHandler(this.text_gameFile_Click);
            this.text_gameFile.Leave += new System.EventHandler(this.text_gameFile_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.label2.Location = new System.Drawing.Point(451, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 56);
            this.label2.TabIndex = 20;
            this.label2.Text = "New Game";
            // 
            // New_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchGamePath);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.text_gameFile);
            this.Controls.Add(this.btnSearchImg);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.text_imgFile);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.text_description);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.text_genre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.text_title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveGame);
            this.Controls.Add(this.previewBoxImg);
            this.Name = "New_Game";
            this.Size = new System.Drawing.Size(1134, 673);
            ((System.ComponentModel.ISupportInitialize)(this.previewBoxImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox previewBoxImg;
        private XanderUI.XUIButton btnSaveGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox text_title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox text_genre;
        private System.Windows.Forms.TextBox text_description;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox text_imgFile;
        private XanderUI.XUIButton btnSearchImg;
        private XanderUI.XUIButton btnSearchGamePath;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox text_gameFile;
        private System.Windows.Forms.Label label2;
    }
}
