using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace Game_library
{
    public partial class library : UserControl
    {

        public library()
        {
            InitializeComponent();

        }

        public void getGameInfo()
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source = " + CreateDataBase.conString);
            connection.Open();




            DataTable table = new DataTable();

            string query = "SELECT * FROM Games ORDER BY DAT_GAME_INC DESC";

            SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
            adapter.Fill(table);

            adapter.Dispose();
            connection.Close();





            foreach (DataRow line in table.Rows)
            {
                GameBanner game = new GameBanner();
                List<GameBanner> gamelist = new List<GameBanner>();

                var date = line["DAT_GAME_INC"].ToString();
                string DataFormatada = date.Substring(0, 10);

                game.title = line["GAME_TITLE"].ToString();
                game.genre = line["GAME_GENRE"].ToString();
                game.img = line["GAME_IMG_FILE"].ToString();
                game.gamepath = line["GAME_PATH"].ToString();
                game.description = line["GAME_DESCRIPTION"].ToString();
                game.date = DataFormatada;

                gamelist.Add(game);


                flowLayoutPanel1.Controls.Add(game);
                gamelist.Clear();
            }


        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

            if (text_filter_title.Text == "Game" && texte_genteFilter.Text == "Genre")
            {
                flowLayoutPanel1.Controls.Clear();
                getGameInfo();
            }
            else if (text_filter_title.Text != "Game" && texte_genteFilter.Text != "Genre")
            {
                flowLayoutPanel1.Controls.Clear();
                FilterGameList(text_filter_title.Text, texte_genteFilter.Text);
            }
            else
            {
                flowLayoutPanel1.Controls.Clear();
                FilterGameList(text_filter_title.Text);
            }
            

        }

        public void FilterGameList(string gameTittle)
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source =" + CreateDataBase.conString);
            connection.Open();


            DataTable table = new DataTable();

            string query = "SELECT * FROM Games WHERE GAME_TITLE = '" + gameTittle + "'" + "OR GAME_GENRE ='" + texte_genteFilter.Text + "'";
            SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
            adapter.Fill(table);

            foreach (DataRow line in table.Rows)
            {
                


                GameBanner gameFiltered = new GameBanner();
                List<GameBanner> gamelistFiltered = new List<GameBanner>();

                var date = line["DAT_GAME_INC"].ToString();
                string DataFormatada = date.Substring(0, 10);

                gameFiltered.title = line["GAME_TITLE"].ToString();
                gameFiltered.genre = line["GAME_GENRE"].ToString();
                gameFiltered.img = line["GAME_IMG_FILE"].ToString();
                gameFiltered.gamepath = line["GAME_PATH"].ToString();
                gameFiltered.description = line["GAME_DESCRIPTION"].ToString();
                gameFiltered.date = DataFormatada;

                gamelistFiltered.Add(gameFiltered);


                flowLayoutPanel1.Controls.Add(gameFiltered);
                gamelistFiltered.Clear();
            }



        }

        public void FilterGameList(string gameTittle, string genre)
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source =" + CreateDataBase.conString);
            connection.Open();


            DataTable table = new DataTable();

            string query = "SELECT * FROM Games WHERE GAME_TITLE = '" + gameTittle + "'" + "AND GAME_GENRE ='" + genre + "'";
            SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
            adapter.Fill(table);

            foreach (DataRow line in table.Rows)
            {
                GameBanner game = new GameBanner();
                List<GameBanner> gamelist = new List<GameBanner>();


                GameBanner gameFiltered = new GameBanner();
                List<GameBanner> gamelistFiltered = new List<GameBanner>();

                var date = line["DAT_GAME_INC"].ToString();
                string DataFormatada = date.Substring(0, 10);

                gameFiltered.title = line["GAME_TITLE"].ToString();
                gameFiltered.genre = line["GAME_GENRE"].ToString();
                gameFiltered.img = line["GAME_IMG_FILE"].ToString();
                gameFiltered.gamepath = line["GAME_PATH"].ToString();
                gameFiltered.description = line["GAME_DESCRIPTION"].ToString();
                gameFiltered.date = DataFormatada;

                gamelist.Add(gameFiltered);


                flowLayoutPanel1.Controls.Add(gameFiltered);
                gamelist.Clear();
            }



        }

        private void text_filter_title_Click(object sender, EventArgs e)
        {
            if (text_filter_title.Text == "Game")
            {
                text_filter_title.Text = "";
            }
        }

        private void text_filter_title_Leave(object sender, EventArgs e)
        {
            if (text_filter_title.Text == "")
            {
                text_filter_title.Text = "Game";
            }
        }

        private void texte_genteFilter_Click(object sender, EventArgs e)
        {
            if (texte_genteFilter.Text == "Genre")
            {
                texte_genteFilter.Text = "";
            }
        }

        private void texte_genteFilter_Leave(object sender, EventArgs e)
        {
            if (texte_genteFilter.Text == "")
            {
                texte_genteFilter.Text = "Genre";
            }
        }

        private void btnFilter_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void texte_genteFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (text_filter_title.Text == "Game" && texte_genteFilter.Text == "Genre" || text_filter_title.Text == "" && texte_genteFilter.Text == "")
                {
                    flowLayoutPanel1.Controls.Clear();
                    getGameInfo();
                }
                else if (text_filter_title.Text != "Game" && texte_genteFilter.Text != "Genre")
                {
                    flowLayoutPanel1.Controls.Clear();
                    FilterGameList(text_filter_title.Text, texte_genteFilter.Text);
                }
                else
                {
                    flowLayoutPanel1.Controls.Clear();
                    FilterGameList(text_filter_title.Text);
                }
            }
        }

        private void text_filter_title_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.Handled = true;

                if (text_filter_title.Text == "Game" && texte_genteFilter.Text == "Genre" || text_filter_title.Text == "" && texte_genteFilter.Text == "")
                {
                    flowLayoutPanel1.Controls.Clear();
                    getGameInfo();
                }
                else if (text_filter_title.Text != "Game" && texte_genteFilter.Text != "Genre")
                {
                    flowLayoutPanel1.Controls.Clear();
                    FilterGameList(text_filter_title.Text, texte_genteFilter.Text);
                }
                else
                {
                    flowLayoutPanel1.Controls.Clear();
                    FilterGameList(text_filter_title.Text);
                }
            }
        }
    }
}
