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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.libraryPanel = new System.Windows.Forms.Panel();
            this.libraryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(138, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(996, 673);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // libraryPanel
            // 
            this.libraryPanel.Controls.Add(this.textBox2);
            this.libraryPanel.Controls.Add(this.textBox1);
            this.libraryPanel.Controls.Add(this.flowLayoutPanel1);
            this.libraryPanel.Controls.Add(this.button1);
            this.libraryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryPanel.Location = new System.Drawing.Point(0, 0);
            this.libraryPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.libraryPanel.Name = "libraryPanel";
            this.libraryPanel.Size = new System.Drawing.Size(1512, 828);
            this.libraryPanel.TabIndex = 4;
            // 
            // library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.libraryPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "library";
            this.Size = new System.Drawing.Size(1512, 828);
            this.libraryPanel.ResumeLayout(false);
            this.libraryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel libraryPanel;
    }
}
