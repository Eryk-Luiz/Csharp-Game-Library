﻿namespace Game_library
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.texte_genteFilter = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_filter_title = new System.Windows.Forms.TextBox();
            this.btnFilter = new XanderUI.XUIButton();
            this.libraryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 80);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1347, 655);
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
            this.libraryPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.libraryPanel.Name = "libraryPanel";
            this.libraryPanel.Size = new System.Drawing.Size(1367, 738);
            this.libraryPanel.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel4.Location = new System.Drawing.Point(3, 71);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1292, 2);
            this.panel4.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel2.Location = new System.Drawing.Point(635, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 2);
            this.panel2.TabIndex = 9;
            // 
            // texte_genteFilter
            // 
            this.texte_genteFilter.BackColor = System.Drawing.Color.White;
            this.texte_genteFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texte_genteFilter.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texte_genteFilter.ForeColor = System.Drawing.Color.Black;
            this.texte_genteFilter.HideSelection = false;
            this.texte_genteFilter.Location = new System.Drawing.Point(635, 15);
            this.texte_genteFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.texte_genteFilter.Name = "texte_genteFilter";
            this.texte_genteFilter.Size = new System.Drawing.Size(281, 24);
            this.texte_genteFilter.TabIndex = 8;
            this.texte_genteFilter.TabStop = false;
            this.texte_genteFilter.Text = "Genre";
            this.texte_genteFilter.Click += new System.EventHandler(this.texte_genteFilter_Click);
            this.texte_genteFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.texte_genteFilter_KeyDown);
            this.texte_genteFilter.Leave += new System.EventHandler(this.texte_genteFilter_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel1.Location = new System.Drawing.Point(264, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 2);
            this.panel1.TabIndex = 7;
            // 
            // text_filter_title
            // 
            this.text_filter_title.BackColor = System.Drawing.Color.White;
            this.text_filter_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_filter_title.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_filter_title.ForeColor = System.Drawing.Color.Black;
            this.text_filter_title.HideSelection = false;
            this.text_filter_title.Location = new System.Drawing.Point(264, 15);
            this.text_filter_title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_filter_title.Name = "text_filter_title";
            this.text_filter_title.Size = new System.Drawing.Size(281, 24);
            this.text_filter_title.TabIndex = 6;
            this.text_filter_title.TabStop = false;
            this.text_filter_title.Text = "Game";
            this.text_filter_title.Click += new System.EventHandler(this.text_filter_title_Click);
            this.text_filter_title.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_filter_title_KeyDown);
            this.text_filter_title.Leave += new System.EventHandler(this.text_filter_title_Leave);
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
            this.btnFilter.Location = new System.Drawing.Point(1009, 9);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(136, 42);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.TextColor = System.Drawing.Color.White;
            this.btnFilter.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.libraryPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "library";
            this.Size = new System.Drawing.Size(1367, 738);
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
