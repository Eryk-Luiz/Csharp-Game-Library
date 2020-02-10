namespace Game_library
{
    partial class library
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.libraryPanel = new System.Windows.Forms.Panel();
            this.btnFilter = new XanderUI.XUIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_filter_title = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.texte_genteFilter = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.libraryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 65);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(974, 488);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // libraryPanel
            // 
            this.libraryPanel.BackColor = System.Drawing.Color.White;
            this.libraryPanel.Controls.Add(this.panel4);
            this.libraryPanel.Controls.Add(this.panel2);
            this.libraryPanel.Controls.Add(this.texte_genteFilter);
            this.libraryPanel.Controls.Add(this.panel1);
            this.libraryPanel.Controls.Add(this.text_filter_title);
            this.libraryPanel.Controls.Add(this.btnFilter);
            this.libraryPanel.Controls.Add(this.flowLayoutPanel1);
            this.libraryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryPanel.Location = new System.Drawing.Point(0, 0);
            this.libraryPanel.Margin = new System.Windows.Forms.Padding(2);
            this.libraryPanel.Name = "libraryPanel";
            this.libraryPanel.Size = new System.Drawing.Size(974, 553);
            this.libraryPanel.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.btnFilter.ButtonImage = null;
            this.btnFilter.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnFilter.ButtonText = "Filter";
            this.btnFilter.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnFilter.ClickTextColor = System.Drawing.Color.White;
            this.btnFilter.CornerRadius = 5;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnFilter.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFilter.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(44)))));
            this.btnFilter.HoverTextColor = System.Drawing.Color.White;
            this.btnFilter.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnFilter.Location = new System.Drawing.Point(757, 7);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(102, 34);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.TextColor = System.Drawing.Color.White;
            this.btnFilter.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel1.Location = new System.Drawing.Point(198, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 2);
            this.panel1.TabIndex = 7;
            // 
            // text_filter_title
            // 
            this.text_filter_title.BackColor = System.Drawing.Color.White;
            this.text_filter_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_filter_title.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_filter_title.ForeColor = System.Drawing.Color.Black;
            this.text_filter_title.HideSelection = false;
            this.text_filter_title.Location = new System.Drawing.Point(198, 12);
            this.text_filter_title.Name = "text_filter_title";
            this.text_filter_title.Size = new System.Drawing.Size(211, 19);
            this.text_filter_title.TabIndex = 6;
            this.text_filter_title.TabStop = false;
            this.text_filter_title.Text = "Game";
            this.text_filter_title.Click += new System.EventHandler(this.text_filter_title_Click);
            this.text_filter_title.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_filter_title_KeyDown);
            this.text_filter_title.Leave += new System.EventHandler(this.text_filter_title_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel2.Location = new System.Drawing.Point(476, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 2);
            this.panel2.TabIndex = 9;
            // 
            // texte_genteFilter
            // 
            this.texte_genteFilter.BackColor = System.Drawing.Color.White;
            this.texte_genteFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texte_genteFilter.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texte_genteFilter.ForeColor = System.Drawing.Color.Black;
            this.texte_genteFilter.HideSelection = false;
            this.texte_genteFilter.Location = new System.Drawing.Point(476, 12);
            this.texte_genteFilter.Name = "texte_genteFilter";
            this.texte_genteFilter.Size = new System.Drawing.Size(211, 19);
            this.texte_genteFilter.TabIndex = 8;
            this.texte_genteFilter.TabStop = false;
            this.texte_genteFilter.Text = "Genre";
            this.texte_genteFilter.Click += new System.EventHandler(this.texte_genteFilter_Click);
            this.texte_genteFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.texte_genteFilter_KeyDown);
            this.texte_genteFilter.Leave += new System.EventHandler(this.texte_genteFilter_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel4.Location = new System.Drawing.Point(2, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(969, 2);
            this.panel4.TabIndex = 10;
            // 
            // library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.libraryPanel);
            this.Name = "library";
            this.Size = new System.Drawing.Size(974, 553);
            this.libraryPanel.ResumeLayout(false);
            this.libraryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel libraryPanel;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private XanderUI.XUIButton btnFilter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox texte_genteFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox text_filter_title;
        private System.Windows.Forms.Panel panel4;
    }
}
