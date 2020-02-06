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
            
            

        
        }

       
    }
}
