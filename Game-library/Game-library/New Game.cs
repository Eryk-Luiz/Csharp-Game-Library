using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Windows.Forms;

namespace Game_library
{
    public partial class New_Game : UserControl
    {
        public New_Game()
        {
            InitializeComponent();
            
        }


        private void btnSaveGame_Click(object sender, EventArgs e)
        {

            library library = new library();
            InsertGameInfo(text_title.Text, text_genre.Text, text_imgFile.Text, text_gameFile.Text, text_description.Text);
            MessageBox.Show("Novo Jogo Salvo");
            Clear();


        }




        #region Text Box Events


        //Click Events
        private void text_title_Click(object sender, EventArgs e)
        {
            if (text_title.Text == "Tittle")
            {
                text_title.Text = "";
            }
        }

        private void text_genre_Click(object sender, EventArgs e)
        {
            if (text_genre.Text == "Genre")
            {
                text_genre.Text = "";
            }
        }

        private void text_imgFile_Click(object sender, EventArgs e)
        {
            if (text_imgFile.Text == "Image File")
            {
                text_imgFile.Text = "";
            }
        }

        private void text_gameFile_Click(object sender, EventArgs e)
        {
            if (text_gameFile.Text == "Game Path")
            {
                text_gameFile.Text = "";
            }
        }


        private void text_description_Click(object sender, EventArgs e)
        {
            if (text_description.Text == "Description")
            {
                text_description.Text = "";
            }
        }


        // Leave Events
        private void text_title_Leave(object sender, EventArgs e)
        {
            if (text_title.Text == "")
            {
                text_title.Text = "Tittle";
            }
        }

        private void text_genre_Leave(object sender, EventArgs e)
        {
            if (text_genre.Text == "")
            {
                text_genre.Text = "Genre";
            }
        }

        private void text_imgFile_Leave(object sender, EventArgs e)
        {
            if (text_imgFile.Text == "")
            {
                text_imgFile.Text = "Image File";
            }
        }

        private void text_gameFile_Leave(object sender, EventArgs e)
        {
            if (text_gameFile.Text == "")
            {
                text_gameFile.Text = "Game Path";
            }
        }

        private void text_description_Leave(object sender, EventArgs e)
        {
            if (text_description.Text == "")
            {
                text_description.Text = "Description";
            }
        }


        #endregion




        public void CreatingGameTable()
        {

            try
            {
                //faz conexão com o Banco;
                SqlCeConnection connection = new SqlCeConnection("Data Source =" + CreateDataBase.conString);
                connection.Open();

                DataTable table = new DataTable();


                //Verifica se a Tabela Existe
                string query = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Games'";
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
                adapter.Fill(table);




                if (table.Rows.Count == 0)
                {
                    //Create Table
                    string query2 =
                                   "CREATE TABLE Games(" +
                                   "COD_GAME            INT PRIMARY KEY IDENTITY(1,1)," +
                                   "GAME_TITLE          NVARCHAR(50) NOT NULL," +
                                   "GAME_GENRE          NVARCHAR(50) NOT NULL," +
                                   "GAME_IMG_FILE       NVARCHAR(160) NOT NULL," +
                                   "GAME_PATH           NVARCHAR(160)," +
                                   "GAME_DESCRIPTION    NVARCHAR(160)," +
                                   "DAT_GAME_INC        DATETIME" +
                                   ")";


                    SqlCeCommand command = new SqlCeCommand(query2, connection);
                    command.ExecuteNonQuery();


                    command.Dispose();
                    connection.Close();
                }
                else
                {
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Erro ao Criar Tabela de Games");
            }

        }


        public static void InsertGameInfo(string title, string genre, string imgFile, string gamePath, string gameDesc)
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source =" + CreateDataBase.conString);
            connection.Open();


            string query = "INSERT INTO Games(GAME_TITLE, GAME_GENRE, GAME_IMG_FILE, GAME_PATH, GAME_DESCRIPTION, DAT_GAME_INC)" +
                           "VALUES(@title, @genre, @imgFile, @gamePath, @gameDescription, @dateInc)";

            SqlCeCommand command = new SqlCeCommand(query, connection);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@genre", genre);
            command.Parameters.AddWithValue("@imgFile", imgFile);
            command.Parameters.AddWithValue("@gamePath", gamePath);
            command.Parameters.AddWithValue("@gameDescription", gameDesc);
            command.Parameters.AddWithValue("@dateInc", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));


            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        private void btnSearchImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog imgfile = new OpenFileDialog();
            imgfile.Filter = "*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            imgfile.ShowDialog();
            text_imgFile.Text = imgfile.FileName;
            previewBoxImg.BackgroundImage = Image.FromFile(text_imgFile.Text);
        }

        private void btnSearchGamePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog imgfile1 = new OpenFileDialog();
            imgfile1.Filter = "All files (*.*)|*.*";
            imgfile1.ShowDialog();
            text_gameFile.Text = imgfile1.FileName;
        }



        private void text_imgFile_TextChanged(object sender, EventArgs e)
        {

            if (text_imgFile.Text != "Image File")
            {

            }
            else
            {
                return;
            }



        }

        public void Clear()
        {
            text_title.Text = "Tittle";
            text_genre.Text = "Genre";
            text_imgFile.Text = "Image File";
            text_gameFile.Text = "Game Path";
            text_description.Text = "Description";

            previewBoxImg.BackgroundImage = Properties.Resources.Logo_ico;


        }


    }
}
