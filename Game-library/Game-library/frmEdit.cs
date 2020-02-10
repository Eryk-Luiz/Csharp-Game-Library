using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Game_library
{
    public partial class frmEdit : Form
    {

        library library = new library();


        public frmEdit()
        {
            InitializeComponent();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            GetGameToEdit(library.game_title);
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

        private void btnApplly_Click(object sender, EventArgs e)
        {
            GetGameToEdit(textBox1.Text);
        }
    }
}
