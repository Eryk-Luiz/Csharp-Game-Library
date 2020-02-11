using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Game_library
{
    public partial class GameBanner : UserControl
    {
        

        
        public GameBanner()
        {
            InitializeComponent();
        }

        #region Propriedades do UserControl

        [Category("Custom props")]
        private string _Title;
        public string title
        {
            get { return _Title; }
            set { _Title = value; label_title.Text = value; }
        }


        [Category("Custom props")]
        private string _description;
        public string description
        {
            get { return _description; }
            set { _description = value; label_disc.Text = value; }
        }


        [Category("Custom props")]
        private string _genre;
        public string genre
        {
            get { return _genre; }
            set { _genre = value; label_genre.Text = value; }
        }


        [Category("Custom props")]
        private string _img;
        public string img
        {
            get { return _img; }
            set { _img = value; gameBannerImg.BackgroundImage = Image.FromFile(value); }
        }


        private string _gamepath;
        public string gamepath
        {
            get { return _gamepath; }
            set { _gamepath = value; }
        }



        private string _date;
        public string date
        {
            get { return _date; }
            set { _date = value; label_date.Text = value; }
        }


        #endregion

        private void btnStartGame_Click(object sender, EventArgs e)
        {

            
            if (File.Exists(gamepath))
            {
                System.Diagnostics.Process.Start(gamepath);
            }
            else
            {
                MessageBox.Show("Game Path Not Found");
            }
            
        }
        private void btnEditGame_Click(object sender, EventArgs e)
        {
            editGame game = new editGame();
            
            game.GetGameToEdit(title);
            
        }
    }
}
