using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_library
{
    public partial class library : UserControl
    {
        public int count;

        

        public library()
        {
            InitializeComponent();

            

            

        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            listContainer(count);
        }


  

        private void listContainer(int count)
        {
            GameBanner game = new GameBanner();
            List<GameBanner> list = new List<GameBanner>();

                
                game.title = line["GAME_TITLE"].ToString();
                game.genre = line["GAME_GENRE"].ToString();
                game.img = line["GAME_IMG_FILE"].ToString();
                game.gamepath = line["GAME_PATH"].ToString();
                game.description = line["GAME_DESCRIPTION"].ToString();
                
                gamelist.Add(game);

                    flowLayoutPanel1.Controls.Add(list[i]);

                flowLayoutPanel1.Controls.Add(game);
            }


        }

       
    }
}
