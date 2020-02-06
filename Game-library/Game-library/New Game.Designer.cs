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
            this.logo = new XanderUI.XUICustomPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::Game_library.Properties.Resources.Logo;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Color1 = System.Drawing.Color.DodgerBlue;
            this.logo.Color2 = System.Drawing.Color.DodgerBlue;
            this.logo.FilterAlpha = 200;
            this.logo.FilterEnabled = true;
            this.logo.Image = null;
            this.logo.IsElipse = false;
            this.logo.IsParallax = false;
            this.logo.Location = new System.Drawing.Point(270, 233);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(563, 345);
            this.logo.TabIndex = 6;
            this.logo.Text = "xuiCustomPictureBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 56);
            this.label1.TabIndex = 7;
            this.label1.Text = "In Coming...";
            // 
            // New_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Name = "New_Game";
            this.Size = new System.Drawing.Size(1134, 673);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUICustomPictureBox logo;
        private System.Windows.Forms.Label label1;
    }
}
