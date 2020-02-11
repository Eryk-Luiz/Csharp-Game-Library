using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Collections;
using System.IO;

namespace Game_library
{
    public partial class editGame : UserControl
    {

        public string imgPath;
        public string gamePath;
        public string Finalpath;
        public string pathTodelete;
        public object ListItems { get; private set; }

        public editGame()
        {
            InitializeComponent();
            
        }


        #region Text Box Events


        //Click Events
        private void text_title_edit_Click(object sender, EventArgs e)
        {
            if (text_title_edit.Text == "Title")
            {
                text_title_edit.Text = "";
            }
        }

        private void text_genre_Click(object sender, EventArgs e)
        {
            if (text_genre_edit.Text == "Genre")
            {
                text_genre_edit.Text = "";
            }
        }

        private void text_imgFile_Click(object sender, EventArgs e)
        {
            if (text_imgFile_edit.Text == "Image File")
            {
                text_imgFile_edit.Text = "";
            }
        }

        private void text_gameFile_Click(object sender, EventArgs e)
        {
            if (text_gameFile_edit.Text == "Game Path")
            {
                text_gameFile_edit.Text = "";
            }
        }


        private void text_description_Click(object sender, EventArgs e)
        {
            if (text_description_edit.Text == "Description")
            {
                text_description_edit.Text = "";
            }
        }


        // Leave Events
        private void text_title_Leave(object sender, EventArgs e)
        {
            if (text_title_edit.Text == "")
            {
                text_title_edit.Text = "Title";
            }
        }

        private void text_genre_Leave(object sender, EventArgs e)
        {
            if (text_genre_edit.Text == "")
            {
                text_genre_edit.Text = "Genre";
            }
        }

        private void text_imgFile_Leave(object sender, EventArgs e)
        {
            if (text_imgFile_edit.Text == "")
            {
                text_imgFile_edit.Text = "Image File";
            }
        }

        private void text_gameFile_Leave(object sender, EventArgs e)
        {
            if (text_gameFile_edit.Text == "")
            {
                text_gameFile_edit.Text = "Game Path";
            }
        }

        private void text_description_Leave(object sender, EventArgs e)
        {
            if (text_description_edit.Text == "")
            {
                text_description_edit.Text = "Description";
            }
        }


        #endregion

        private void editGame_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetGameToEdit(comboBox1.Text);
        }



       

        public void GetGameToEdit(string GameToEdit)
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source =" + CreateDataBase.conString);
            connection.Open();

            DataTable table = new DataTable();
            string query = "SELECT * FROM Games WHERE GAME_TITLE = '" + GameToEdit + "'";

            SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
            adapter.Fill(table);


            connection.Close();


            foreach (DataRow item in table.Rows)
            {
                string pathimg = item["GAME_IMG_FILE"].ToString();
                string pathgame = item["GAME_PATH"].ToString();
                FileInfo info = new FileInfo(pathimg);
                FileInfo info1 = new FileInfo(pathgame);


                text_title_edit.Text = item["GAME_TITLE"].ToString();
                text_genre_edit.Text = item["GAME_GENRE"].ToString();
                text_imgFile_edit.Text = info.Name;
                text_gameFile_edit.Text = info1.Name;
                text_description_edit.Text = item["GAME_DESCRIPTION"].ToString();
                previewBoxImg.BackgroundImage = Image.FromFile(pathimg);
            }



        }

        public void LoadCombo()
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source =" + CreateDataBase.conString);
            connection.Open();

            DataTable table = new DataTable();
            string query = "SELECT COD_GAME, GAME_TITLE FROM Games";

            SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
            adapter.Fill(table);


            connection.Close();

            comboBox1.ValueMember = "COD_GAME";
            comboBox1.DisplayMember = "GAME_TITLE";
            comboBox1.DataSource = table;
        }

      
        private void btnSearchImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog imgfile = new OpenFileDialog();
            imgfile.Filter = "*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (imgfile.ShowDialog() == DialogResult.OK)
            {
                FileInfo info = new FileInfo(imgfile.FileName);
                text_imgFile_edit.Text = info.Name;
                imgPath = imgfile.FileName;
                previewBoxImg.BackgroundImage = Image.FromFile(imgfile.FileName);

            }
            else
            {
                text_imgFile_edit.Text = "Image File";
                previewBoxImg.BackgroundImage = Properties.Resources.Logo_ico;
            }
        }

        private void btnSearchGamePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog imgfile1 = new OpenFileDialog();
            imgfile1.Filter = "Executável(*.exe)|*.exe|All files (*.*)|*.*";

            if (imgfile1.ShowDialog() == DialogResult.OK)
            {
                FileInfo info = new FileInfo(imgfile1.FileName);
                gamePath = imgfile1.FileName;
                
                text_gameFile_edit.Text = info.Name;
            }
            else
            {
                gamePath = "";
                text_gameFile_edit.Text = this.gamePath;
            }
        }

       

        private void btnSaveEditGame_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you Sure ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (File.Exists(imgPath))
                {
                    FileInfo info = new FileInfo(imgPath);

                    Finalpath = CreateDataBase.imgSource + info.Name;
                    if (!File.Exists(Finalpath))
                    {
                        File.Copy(imgPath, Finalpath);
                    }
                    else
                    {
                        File.Delete(Finalpath);
                        File.Copy(imgPath, Finalpath);
                    }
                }


                pathTodelete = Finalpath;
                UpdateGame(text_title_edit.Text, text_genre_edit.Text, Finalpath, gamePath, text_description_edit.Text, comboBox1.Text);
                MessageBox.Show("Game has been Updated");
                LoadCombo();
                Directory.CreateDirectory(CreateDataBase.imgSource);
            }
            else
            {
                return;
            }
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                Deletegame(comboBox1.Text);

             
               
                MessageBox.Show("Game has been deleted");
                LoadCombo();
            }
                
        }

        public void UpdateGame(string gameTitle, string gameGenre, string imgFile, string gamePath, string desc, string id)
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source =" + CreateDataBase.conString);
            connection.Open();


            string query = "UPDATE Games SET GAME_TITLE = @NewGameTitle, GAME_GENRE = @NewGameGenre, GAME_IMG_FILE = @NewImgFile, GAME_PATH = @NewGamePath, GAME_DESCRIPTION = @NewDescription WHERE GAME_TITLE = @Id";
            SqlCeCommand update = new SqlCeCommand(query, connection);
            update.Parameters.AddWithValue("@NewGameTitle", gameTitle);
            update.Parameters.AddWithValue("@NewGameGenre", gameGenre);
            update.Parameters.AddWithValue("@NewImgFile", imgFile);
            update.Parameters.AddWithValue("@NewGamePath", gamePath);
            update.Parameters.AddWithValue("@NewDescription", desc);
            update.Parameters.AddWithValue("@Id", id);


            update.ExecuteNonQuery();
            update.Dispose();
            connection.Close();
        }

        public void Deletegame(string game)
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source =" + CreateDataBase.conString);
            connection.Open();


            string query = "DELETE FROM Games WHERE GAME_TITLE = @game";

            SqlCeCommand Delete = new SqlCeCommand(query, connection);
            Delete.Parameters.AddWithValue("@game", game);

            Delete.ExecuteNonQuery();
            Delete.Dispose();
            connection.Close();
        }
    }
}
