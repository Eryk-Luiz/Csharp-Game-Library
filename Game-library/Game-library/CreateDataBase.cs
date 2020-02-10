using System;
using System.Data.SqlServerCe;
using System.IO;
using System.Windows.Forms;

namespace Game_library
{
    public static partial class CreateDataBase
    {
        public static string version = "1.0.0";
        public static string DB_folder;
        public static string conString;
        public static string imgSource;



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

            imgSource = DB_folder + @"\imgSource\";
            if (!Directory.Exists(imgSource))
            {
                DirectoryInfo info = Directory.CreateDirectory(imgSource);
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
                               "COD_USER        INT PRIMARY KEY IDENTITY(1,1)," +
                               "USER_NAME       NVARCHAR(50) NOT NULL," +
                               "PASSWORD        NVARCHAR(50) NOT NULL," +
                               "DAT_INC_USER    DATETIME" +
                               ")";


                SqlCeCommand sqlCmd = new SqlCeCommand(query, connection);
                sqlCmd.ExecuteNonQuery();


                //Desconectar
                sqlCmd.Dispose();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados");
            }
        }




    }
}
