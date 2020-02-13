using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Game_library
{
    public partial class New_Game : UserControl
    {
        #region Propriedades privadas
        private string gamePath;
        private string Finalpath;
        private string imgPath;
        #endregion


        #region Instancias
        CreatingGameTable creatingGameTable = new CreatingGameTable();
        #endregion

        public New_Game()
        {
            InitializeComponent();

        }


        #region Text Box Events


        //Click Events
        private void text_title_Click(object sender, EventArgs e)
        {
            if (text_title.Text == "Title")
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
                text_title.Text = "Title";
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


        #region Button Events

        private void btnSearchImg_Click(object sender, EventArgs e)
        {

            

            OpenFileDialog imgfile = new OpenFileDialog();
            imgfile.Filter = "*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (imgfile.ShowDialog() == DialogResult.OK)
            {
                FileInfo info = new FileInfo(imgfile.FileName);
                text_imgFile.Text = info.Name;
                imgPath = imgfile.FileName;
                previewBoxImg.BackgroundImage = Image.FromFile(imgfile.FileName);

            }
            else
            {
                text_imgFile.Text = "Image File";
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
                text_gameFile.Text = info.Name;
            }
            else
            {
                text_gameFile.Text = "Game Path";
            }
        }

        private void btnSaveGame_Click(object sender, EventArgs e)
        {

            if (File.Exists(imgPath))
            {
                FileInfo info = new FileInfo(imgPath);
                Finalpath = CreateDataBase.imgSource + info.Name;

                if (!File.Exists(Finalpath))
                {
                    File.Copy(imgPath, CreateDataBase.imgSource + info.Name);
                }
                else
                {
                    File.Delete(Finalpath);
                    File.Copy(imgPath, CreateDataBase.imgSource + info.Name);
                }
            }



            if (text_title.Text == "Title")
            {
                MessageBox.Show("Insert a Title");
            }

            else if (text_genre.Text == "Genre")
            {
                MessageBox.Show("Insert a Genre");
            }

            else if (text_imgFile.Text == "Image File")
            {
                MessageBox.Show("Insert an Image");
            }
            else if (text_gameFile.Text == "Game Path")
            {
                MessageBox.Show("Insert a Game file");
            }
            else
            {
                creatingGameTable.InsertGameInfo(text_title.Text, text_genre.Text, Finalpath, gamePath, text_description.Text);
                MessageBox.Show("Novo Jogo Salvo");
                Directory.CreateDirectory(CreateDataBase.imgSource);


                Clear();
            }

           
            


           
            

            
        }

        private void previewBoxImg_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {
            if (previewBoxImg.BackgroundImage != Properties.Resources.Logo)
            {
                previewBoxImg.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                previewBoxImg.BackgroundImageLayout = ImageLayout.Zoom;
            }

        }

        #endregion


        //método que limpa os TextBoxes
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
