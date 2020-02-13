using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;
using System.Windows.Forms;

namespace Game_library
{
    public class CreatingGameTable
    {

      
        public CreatingGameTable()
        {

        }

        public void CreatingTable()
        {

            try
            {
                //faz conexão com o Banco;
                SqlCeConnection connection = new SqlCeConnection("Data Source =" + CreateDataBase.conString);
                connection.Open();

                DataTable table = new DataTable();


                //Verifica se a Tabela Existe
                string query = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Games'";
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
                adapter.Fill(table);




                if (table.Rows.Count == 0)
                {
                    //Create Table
                    string query2 =
                                   "CREATE TABLE Games(" +
                                   "COD_GAME            INT PRIMARY KEY IDENTITY(1,1)," +
                                   "GAME_TITLE          NVARCHAR(50) NOT NULL," +
                                   "GAME_GENRE          NVARCHAR(50) NOT NULL," +
                                   "GAME_IMG_FILE       NVARCHAR(160) NOT NULL," +
                                   "GAME_PATH           NVARCHAR(160)," +
                                   "GAME_DESCRIPTION    NVARCHAR(160)," +
                                   "DAT_GAME_INC        DATETIME," +
                                   "COD_USER_INC        INT NOT NULL REFERENCES Users(COD_USER)" +
                                   ")";

                    SqlCeCommand command = new SqlCeCommand(query2, connection);
                    command.ExecuteNonQuery();


                    command.Dispose();
                    connection.Close();
                }
                else
                {
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Erro ao Criar Tabela de Games");
            }

        }


        public void InsertGameInfo(string title, string genre, string imgFile, string gamePath, string gameDesc)
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source =" + CreateDataBase.conString);
            connection.Open();


            string query = "INSERT INTO Games(GAME_TITLE, GAME_GENRE, GAME_IMG_FILE, GAME_PATH, GAME_DESCRIPTION, DAT_GAME_INC, COD_USER_INC)" +
                           "VALUES(@title, @genre, @imgFile, @gamePath, @gameDescription, @dateInc, @user_id)";

            SqlCeCommand command = new SqlCeCommand(query, connection);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@genre", genre);
            command.Parameters.AddWithValue("@imgFile", imgFile);
            command.Parameters.AddWithValue("@gamePath", gamePath);
            command.Parameters.AddWithValue("@gameDescription", gameDesc);
            command.Parameters.AddWithValue("@dateInc", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            command.Parameters.AddWithValue("@user_id", frmLogin.cod_user);


            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }


    }
}
