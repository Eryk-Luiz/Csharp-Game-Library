using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace Game_library
{
    public partial class library : UserControl
    {

        editGame edit = new editGame();

        public library()
        {
            InitializeComponent();

        }




        //Método para pesquisar todos os registros do banco da tabela "games".
        public void getGameInfo()
        {
            //Faz a Conexão com o banco de Dados
            SqlCeConnection connection = new SqlCeConnection("Data Source = " + CreateDataBase.conString);
            connection.Open();

            //Cria um Table, faz a query e preenche o table com as informações.
            DataTable table = new DataTable();

            string query = "SELECT * FROM Games WHERE COD_USER_INC = " + "'"+ frmLogin.cod_user + "'" + "ORDER BY DAT_GAME_INC DESC";

            SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
            adapter.Fill(table);

            //fecha a conexão e termina o comando do Adapter.
            adapter.Dispose();
            connection.Close();

            //Para cada linha adicionada da table, ele cria um Novo UserControl(GameBanner). e Joga isso dentro do flowlayoutPanel.
            foreach (DataRow line in table.Rows)
            {
                editGame edit = new editGame();
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


        //Botão para filtrar o registros por Nome do Jogo ou Genêro
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
            else if (texte_genteFilter.Text != "Genre")
            {
                flowLayoutPanel1.Controls.Clear();
                FilterGameListGenre(texte_genteFilter.Text);
            }
            else
            {
                flowLayoutPanel1.Controls.Clear();
                FilterGameList(text_filter_title.Text);
            }

        }



        #region Métodos para filtrar o FlowLayoutPanel
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

        public void FilterGameListGenre(string genre)
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source =" + CreateDataBase.conString);
            connection.Open();


            DataTable table = new DataTable();

            string query = "SELECT * FROM Games WHERE GAME_GENRE ='" + genre + "'" + "AND COD_USER_INC = '" + frmLogin.cod_user + "'";
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
        #endregion



        #region Funcionalidades Visuais e Funcionalidade de Filtrar ao apertar a tecla ENTER.
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
        #endregion
    }
}
