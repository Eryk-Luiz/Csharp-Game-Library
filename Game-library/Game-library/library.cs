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

namespace Game_library
{
    public partial class library : UserControl
    {
        public int count;



        public library()
        {
            InitializeComponent();
            getGameInfo();
        }

        public void getGameInfo()
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source = " + CreateDataBase.conString);
            connection.Open();




            DataTable table = new DataTable();

            string query = "SELECT * FROM Games";

            SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
            adapter.Fill(table);

            adapter.Dispose();
            connection.Close();


            foreach (DataRow line in table.Rows)
            {
                GameBanner game = new GameBanner();
                List<GameBanner> gamelist = new List<GameBanner>();


<<<<<<< HEAD
                SqlCeConnection connection = new SqlCeConnection("Data Source = " + CreateDataBase.conString);
                connection.Open();


                DataTable table = new DataTable();
                string query = "SELECT USER_NAME FROM Users";
                SqlCeDataAdapter command = new SqlCeDataAdapter(query, connection);
                command.Fill(table);

                connection.Close();


                for (int i = 0; i < table.Rows.Count; i++)
                {
                    game.genre = table.Rows[0]["USER_NAME"].ToString();
                    game.title = textBox1.Text;
                    game.description = "Horror Game";
                    list.Add(game);

                    flowLayoutPanel1.Controls.Add(list[i]);
                }




=======
                
                game.title = line["GAME_TITLE"].ToString();
                game.genre = line["GAME_GENRE"].ToString();
                game.img = line["GAME_IMG_FILE"].ToString();
                game.gamepath = line["GAME_PATH"].ToString();
                game.description = line["GAME_DESCRIPTION"].ToString();
                
                gamelist.Add(game);


                flowLayoutPanel1.Controls.Add(game);
            }


>>>>>>> 836ae90d6bb3f2295da3c21a9d6677180fcc1608
            }


        }
    }
}
