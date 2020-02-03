using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlServerCe;

namespace Game_library
{
    public static partial class CreateDataBase
    {
        public static string DB_folder;
        public static string conString;



        //Verifica se existe o Diretório no Computador do usuário
        public static void CreateDataDirectory()
        {
            DB_folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\.GameLibrary";


            if (!Directory.Exists(DB_folder))
            {
                DirectoryInfo info = Directory.CreateDirectory(DB_folder);
                info.Attributes = FileAttributes.Hidden;
            }


            conString = DB_folder + @"\GameLibraryDataBase.sdf";

            if (!File.Exists(conString))
            {
                CreatingDataBase();
            }

        }


        public static void CreatingDataBase()
        {
            // Cria o banco de Dados
            SqlCeEngine engine = new SqlCeEngine("Data source =" + conString);
            engine.CreateDatabase();


            //Faz conexão com o Banco e cria uma tabela
            try
            {
                //Conectar
                SqlCeConnection connection = new SqlCeConnection("Data Source =" + conString);
                connection.Open();


                //Fazer o comando


                string query = "CREATE TABLE Users(" +
                               "COD_USER        INT PRIMARY KEY IDENTITY," +
                               "USER_NAME       NVARCHAR(50) NOT NULL," +
                               "PASSWORD        NVARCHAR(50) NOT NULL," +
                               "DAT_INC_USER    DATETIME" +
                               ")";


                SqlCeCommand sqlCmd = new SqlCeCommand(query, connection);
                sqlCmd.ExecuteNonQuery();


                //Desconectar

                connection.Close();
                MessageBox.Show(connection.State.ToString());
            }
            catch
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados");

            }
        }







    }
}
