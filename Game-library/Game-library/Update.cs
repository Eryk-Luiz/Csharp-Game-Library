using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

namespace Game_library
{
    public class Update
    {
        public Update()
        {

        }

        public void UpdateGame(string gameTitle, string gameGenre, string imgFile, string gamePath, string desc, string game_id)
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source =" + CreateDataBase.conString);
            connection.Open();


            string query = "UPDATE Games SET GAME_TITLE = @NewGameTitle, GAME_GENRE = @NewGameGenre, GAME_IMG_FILE = @NewImgFile, GAME_PATH = @NewGamePath, GAME_DESCRIPTION = @NewDescription WHERE GAME_TITLE = @Id";
            SqlCeCommand update = new SqlCeCommand(query, connection);
            update.Parameters.AddWithValue("@NewGameTitle", gameTitle);
            update.Parameters.AddWithValue("@NewGameGenre", gameGenre);
            update.Parameters.AddWithValue("@NewImgFile", imgFile);
            update.Parameters.AddWithValue("@NewGamePath", gamePath);
            update.Parameters.AddWithValue("@NewDescription", desc);
            update.Parameters.AddWithValue("@Id", game_id);


            update.ExecuteNonQuery();
            update.Dispose();
            connection.Close();
        }


        public void Deletegame(string game_id)
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source =" + CreateDataBase.conString);
            connection.Open();


            string query = "DELETE FROM Games WHERE GAME_TITLE = @id ";

            SqlCeCommand Delete = new SqlCeCommand(query, connection);
            Delete.Parameters.AddWithValue("@id", game_id);

            Delete.ExecuteNonQuery();
            Delete.Dispose();
            connection.Close();
        }

    }
}
