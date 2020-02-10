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
    public partial class editGame : UserControl
    {


        public editGame()
        {
            InitializeComponent();
            
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
                text_title_edit.Text = item["GAME_TITLE"].ToString();
                text_genre_edit.Text = item["GAME_GENRE"].ToString();
                text_imgFile_edit.Text = item["GAME_IMG_FILE"].ToString();
                text_gameFile_edit.Text = item["GAME_PATH"].ToString();
                text_description_edit.Text = item["GAME_DESCRIPTION"].ToString();
            }
             

            string v = "teste";
        }
    }
}
