using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

namespace Game_library
{
    public partial class editGame : UserControl
    {

        #region Propriedades públicas
        private string imgPath;
        private string pathimg;
        private string pathgame;
        
        #endregion

        #region Instancias
        Update update = new Update();
        #endregion

        public editGame()
        {
            InitializeComponent();   
        }

        public void GetGameToEdit(string GameToEdit)
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source =" + CreateDataBase.conString);
            connection.Open();

            DataTable table = new DataTable();
            string query = "SELECT * FROM Games WHERE GAME_TITLE = '" + GameToEdit + "'" + "AND COD_USER_INC = '" + frmLogin.cod_user + "'";

            SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
            adapter.Fill(table);


            connection.Close();


            foreach (DataRow item in table.Rows)
            {
                pathimg = item["GAME_IMG_FILE"].ToString();
                pathgame = item["GAME_PATH"].ToString();
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
            string query = "SELECT COD_GAME, GAME_TITLE FROM Games WHERE COD_USER_INC = '" + frmLogin.cod_user + "'";

            SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
            adapter.Fill(table);


            connection.Close();


            comboBox1.ValueMember = "COD_GAME";
            comboBox1.DisplayMember = "GAME_TITLE";
            comboBox1.DataSource = table;
        }

        private void Validar()
        {
            
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


        #region Eventos

        private void editGame_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                GetGameToEdit(comboBox1.Text);
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
                pathgame = imgfile1.FileName;

                text_gameFile_edit.Text = info.Name;
            }
            else
            {
                pathgame = "";
                text_gameFile_edit.Text = pathgame;
            }
        }

        private void btnSaveEditGame_Click(object sender, EventArgs e)
        {
            if (text_imgFile_edit.Text == "" || text_imgFile_edit.Text == "Image File")
            {
                MessageBox.Show("Insert an Image");
                
            }
            else if (text_gameFile_edit.Text == "" || text_gameFile_edit.Text == "Game Path")
            {
                MessageBox.Show("Insert a Game File");
                
            }
            else if (MessageBox.Show("Are you Sure ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (File.Exists(imgPath))
                {
                    FileInfo info = new FileInfo(imgPath);

                    pathimg = CreateDataBase.imgSource + info.Name;
                    if (!File.Exists(pathimg))
                    {
                        File.Copy(imgPath, pathimg);
                    }
                    else
                    {
                        File.Delete(pathimg);
                        File.Copy(imgPath, pathimg);
                    }
                }
                update.UpdateGame(text_title_edit.Text, text_genre_edit.Text, pathimg, pathgame, text_description_edit.Text, comboBox1.Text);
                LoadCombo();
                MessageBox.Show("Game has been Updated");
                

                Directory.CreateDirectory(CreateDataBase.imgSource);
                
            }
           
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                update.Deletegame(comboBox1.Text);


                MessageBox.Show("Game has been deleted");
                LoadCombo();
            }

        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            LoadCombo();
        }

        #endregion
    }
}
