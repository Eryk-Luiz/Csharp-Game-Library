namespace Game_library
{
    partial class editGame
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveEditGame = new XanderUI.XUIButton();
            this.previewBoxImg = new System.Windows.Forms.PictureBox();
            this.text_title_edit = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_genre_edit = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text_imgFile_edit = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSearchImg = new XanderUI.XUIButton();
            this.text_gameFile_edit = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSearchGamePath = new XanderUI.XUIButton();
            this.text_description_edit = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.game = new System.Windows.Forms.TextBox();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.xuiButton2 = new XanderUI.XUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.previewBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel3.Location = new System.Drawing.Point(21, 799);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1467, 2);
            this.panel3.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(999, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "PreView";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveEditGame
            // 
            this.btnSaveEditGame.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.btnSaveEditGame.ButtonImage = null;
            this.btnSaveEditGame.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnSaveEditGame.ButtonText = "EDIT";
            this.btnSaveEditGame.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnSaveEditGame.ClickTextColor = System.Drawing.Color.White;
            this.btnSaveEditGame.CornerRadius = 5;
            this.btnSaveEditGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEditGame.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEditGame.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSaveEditGame.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnSaveEditGame.HoverTextColor = System.Drawing.Color.White;
            this.btnSaveEditGame.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSaveEditGame.Location = new System.Drawing.Point(1061, 549);
            this.btnSaveEditGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveEditGame.Name = "btnSaveEditGame";
            this.btnSaveEditGame.Size = new System.Drawing.Size(201, 52);
            this.btnSaveEditGame.TabIndex = 27;
            this.btnSaveEditGame.TextColor = System.Drawing.Color.White;
            this.btnSaveEditGame.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSaveEditGame.Click += new System.EventHandler(this.btnSaveEditGame_Click);
            // 
            // previewBoxImg
            // 
            this.previewBoxImg.BackgroundImage = global::Game_library.Properties.Resources.Logo;
            this.previewBoxImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previewBoxImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewBoxImg.InitialImage = global::Game_library.Properties.Resources.Logo;
            this.previewBoxImg.Location = new System.Drawing.Point(989, 143);
            this.previewBoxImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.previewBoxImg.Name = "previewBoxImg";
            this.previewBoxImg.Size = new System.Drawing.Size(273, 286);
            this.previewBoxImg.TabIndex = 22;
            this.previewBoxImg.TabStop = false;
            // 
            // text_title_edit
            // 
            this.text_title_edit.BackColor = System.Drawing.Color.White;
            this.text_title_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_title_edit.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_title_edit.ForeColor = System.Drawing.Color.Black;
            this.text_title_edit.HideSelection = false;
            this.text_title_edit.Location = new System.Drawing.Point(32, 132);
            this.text_title_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_title_edit.MaxLength = 50;
            this.text_title_edit.Name = "text_title_edit";
            this.text_title_edit.Size = new System.Drawing.Size(504, 36);
            this.text_title_edit.TabIndex = 21;
            this.text_title_edit.Text = "Tittle";
            this.text_title_edit.Click += new System.EventHandler(this.text_title_edit_Click);
            this.text_title_edit.Leave += new System.EventHandler(this.text_title_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel1.Location = new System.Drawing.Point(11, 90);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1291, 2);
            this.panel1.TabIndex = 29;
            // 
            // text_genre_edit
            // 
            this.text_genre_edit.BackColor = System.Drawing.Color.White;
            this.text_genre_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_genre_edit.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_genre_edit.ForeColor = System.Drawing.Color.Black;
            this.text_genre_edit.HideSelection = false;
            this.text_genre_edit.Location = new System.Drawing.Point(32, 228);
            this.text_genre_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_genre_edit.MaxLength = 50;
            this.text_genre_edit.Name = "text_genre_edit";
            this.text_genre_edit.Size = new System.Drawing.Size(555, 36);
            this.text_genre_edit.TabIndex = 23;
            this.text_genre_edit.Text = "Genre";
            this.text_genre_edit.Leave += new System.EventHandler(this.text_genre_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel2.Location = new System.Drawing.Point(32, 271);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 2);
            this.panel2.TabIndex = 30;
            // 
            // text_imgFile_edit
            // 
            this.text_imgFile_edit.BackColor = System.Drawing.Color.White;
            this.text_imgFile_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_imgFile_edit.Cursor = System.Windows.Forms.Cursors.No;
            this.text_imgFile_edit.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_imgFile_edit.ForeColor = System.Drawing.Color.Black;
            this.text_imgFile_edit.HideSelection = false;
            this.text_imgFile_edit.Location = new System.Drawing.Point(32, 295);
            this.text_imgFile_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_imgFile_edit.Name = "text_imgFile_edit";
            this.text_imgFile_edit.Size = new System.Drawing.Size(843, 36);
            this.text_imgFile_edit.TabIndex = 31;
            this.text_imgFile_edit.TabStop = false;
            this.text_imgFile_edit.Text = "Image File";
            this.text_imgFile_edit.Click += new System.EventHandler(this.text_imgFile_Click);
            this.text_imgFile_edit.Leave += new System.EventHandler(this.text_imgFile_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel4.Location = new System.Drawing.Point(35, 338);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(843, 2);
            this.panel4.TabIndex = 33;
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
            this.btnSearchImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchImg.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchImg.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearchImg.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnSearchImg.HoverTextColor = System.Drawing.Color.White;
            this.btnSearchImg.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSearchImg.Location = new System.Drawing.Point(32, 350);
            this.btnSearchImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchImg.Name = "btnSearchImg";
            this.btnSearchImg.Size = new System.Drawing.Size(149, 42);
            this.btnSearchImg.TabIndex = 24;
            this.btnSearchImg.TextColor = System.Drawing.Color.White;
            this.btnSearchImg.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearchImg.Click += new System.EventHandler(this.btnSearchImg_Click);
            // 
            // text_gameFile_edit
            // 
            this.text_gameFile_edit.BackColor = System.Drawing.Color.White;
            this.text_gameFile_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_gameFile_edit.Cursor = System.Windows.Forms.Cursors.No;
            this.text_gameFile_edit.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_gameFile_edit.ForeColor = System.Drawing.Color.Black;
            this.text_gameFile_edit.HideSelection = false;
            this.text_gameFile_edit.Location = new System.Drawing.Point(35, 425);
            this.text_gameFile_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_gameFile_edit.Name = "text_gameFile_edit";
            this.text_gameFile_edit.Size = new System.Drawing.Size(840, 36);
            this.text_gameFile_edit.TabIndex = 34;
            this.text_gameFile_edit.TabStop = false;
            this.text_gameFile_edit.Text = "Game Path";
            this.text_gameFile_edit.Click += new System.EventHandler(this.text_gameFile_Click);
            this.text_gameFile_edit.Leave += new System.EventHandler(this.text_gameFile_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel5.Location = new System.Drawing.Point(35, 468);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(844, 2);
            this.panel5.TabIndex = 35;
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
            this.btnSearchGamePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchGamePath.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchGamePath.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearchGamePath.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnSearchGamePath.HoverTextColor = System.Drawing.Color.White;
            this.btnSearchGamePath.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSearchGamePath.Location = new System.Drawing.Point(35, 478);
            this.btnSearchGamePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchGamePath.Name = "btnSearchGamePath";
            this.btnSearchGamePath.Size = new System.Drawing.Size(149, 42);
            this.btnSearchGamePath.TabIndex = 25;
            this.btnSearchGamePath.TextColor = System.Drawing.Color.White;
            this.btnSearchGamePath.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearchGamePath.Click += new System.EventHandler(this.btnSearchGamePath_Click);
            // 
            // text_description_edit
            // 
            this.text_description_edit.BackColor = System.Drawing.Color.White;
            this.text_description_edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_description_edit.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_description_edit.ForeColor = System.Drawing.Color.Black;
            this.text_description_edit.HideSelection = false;
            this.text_description_edit.Location = new System.Drawing.Point(32, 549);
            this.text_description_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_description_edit.Multiline = true;
            this.text_description_edit.Name = "text_description_edit";
            this.text_description_edit.Size = new System.Drawing.Size(1009, 121);
            this.text_description_edit.TabIndex = 26;
            this.text_description_edit.Text = "Description";
            this.text_description_edit.Click += new System.EventHandler(this.text_description_Click);
            this.text_description_edit.Leave += new System.EventHandler(this.text_description_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel6.Location = new System.Drawing.Point(35, 176);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(557, 2);
            this.panel6.TabIndex = 31;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ItemHeight = 36;
            this.comboBox1.Items.AddRange(new object[] {
            "\"\""});
            this.comboBox1.Location = new System.Drawing.Point(568, 24);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.MaxDropDownItems = 100;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(355, 44);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // game
            // 
            this.game.BackColor = System.Drawing.Color.White;
            this.game.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.game.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game.ForeColor = System.Drawing.Color.Black;
            this.game.HideSelection = false;
            this.game.Location = new System.Drawing.Point(306, 27);
            this.game.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(255, 36);
            this.game.TabIndex = 37;
            this.game.Text = "Choose a Game";
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.xuiButton1.ButtonImage = null;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.xuiButton1.ButtonText = "DELETE";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiButton1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(1061, 619);
            this.xuiButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(201, 52);
            this.xuiButton1.TabIndex = 38;
            this.xuiButton1.TextColor = System.Drawing.Color.White;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // xuiButton2
            // 
            this.xuiButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.xuiButton2.ButtonImage = null;
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.xuiButton2.ButtonText = "CANCEL";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.xuiButton2.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton2.CornerRadius = 5;
            this.xuiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiButton2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.xuiButton2.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(1061, 24);
            this.xuiButton2.Margin = new System.Windows.Forms.Padding(4);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(189, 52);
            this.xuiButton2.TabIndex = 39;
            this.xuiButton2.TextColor = System.Drawing.Color.White;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.Click += new System.EventHandler(this.xuiButton2_Click);
            // 
            // editGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.xuiButton2);
            this.Controls.Add(this.xuiButton1);
            this.Controls.Add(this.game);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btnSearchGamePath);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.text_gameFile_edit);
            this.Controls.Add(this.btnSearchImg);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.text_imgFile_edit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.text_description_edit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.text_genre_edit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.text_title_edit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveEditGame);
            this.Controls.Add(this.previewBoxImg);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "editGame";
            this.Size = new System.Drawing.Size(1300, 681);
            this.Load += new System.EventHandler(this.editGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previewBoxImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton btnSaveEditGame;
        private System.Windows.Forms.PictureBox previewBoxImg;
        private System.Windows.Forms.TextBox text_title_edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox text_genre_edit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox text_imgFile_edit;
        private System.Windows.Forms.Panel panel4;
        private XanderUI.XUIButton btnSearchImg;
        private System.Windows.Forms.TextBox text_gameFile_edit;
        private System.Windows.Forms.Panel panel5;
        private XanderUI.XUIButton btnSearchGamePath;
        private System.Windows.Forms.TextBox text_description_edit;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox game;
        public System.Windows.Forms.ComboBox comboBox1;
        private XanderUI.XUIButton xuiButton1;
        private XanderUI.XUIButton xuiButton2;
    }
}
