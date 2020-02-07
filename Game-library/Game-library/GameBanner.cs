using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_library
{
    public partial class GameBanner : UserControl
    {
        public GameBanner()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modal");
        }




        #region Props

        [Category("Custom props")]
        private string _Title;
        public string title
        {
            get { return _Title; }
            set { _Title = value; gameNameLabel.Text = value; }
        }


        [Category("Custom props")]
        private string _description;
        public string description
        {
            get { return _description; }
            set { _description = value; descriptionLabel.Text = value; }
        }


        [Category("Custom props")]
        private string _genre;
        public string genre
        {
            get { return _genre; }
            set { _genre = value; genreLabel.Text = value; }
        }


        [Category("Custom props")]
        private string _img;
        public string img
        {
            get { return _img; }
            set { _img = value; }
        }
        #endregion


    }
}
