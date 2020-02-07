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

                
                game.title = line["GAME_TITLE"].ToString();
                game.genre = line["GAME_GENRE"].ToString();
                game.img = line["GAME_IMG_FILE"].ToString();
                game.gamepath = line["GAME_PATH"].ToString();
                game.description = line["GAME_DESCRIPTION"].ToString();
                
                gamelist.Add(game);


                flowLayoutPanel1.Controls.Add(game);
            }


        }

       
    }
}
