using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Game_library
{
    public partial class GameBanner : UserControl
    {
        

        
        public GameBanner()
        {
            InitializeComponent();
        }

        

        #region Props

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

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(gamepath);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            editGame game1 = new editGame();
            GameEdit game = new GameEdit();
            game1.GetGameToEdit(title);
            game.ShowDialog();
            


        }
    }
}
