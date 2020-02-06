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


            
            
                for (int i = 0; i < 1; i++)
                {
                    game.genre = "Action";
                    game.title = "Resident Evil";
                    game.description = "Horror Game";
                    list.Add(game);

                    flowLayoutPanel1.Controls.Add(list[i]);

                }
            
            

                
        }

       
    }
}
