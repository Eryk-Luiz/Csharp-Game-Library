using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Windows.Forms;

namespace Game_library
{
    public partial class frmLogin : Form
    {
        public static string User;

        public frmLogin()
        {
            InitializeComponent();
        }

        #region Events
        private void frmLogin_Load(object sender, EventArgs e)
        {
            CreateDataBase.CreateDataDirectory();
            label1.Text = CreateDataBase.version;
        }

        private void textLogin_Click(object sender, EventArgs e)
        {
            if (textLogin.Text == "Username")
            {
                textLogin.Clear();
            }

            //Muda a cor do sublinhado de baixo do Imput
            panel1.BackColor = Color.FromArgb(0, 210, 65);
        }

        private void textLogin_Leave(object sender, EventArgs e)
        {
            if (textLogin.Text == "")
            {
                textLogin.Text = "Username";

            }
            //Muda a cor do sublinhado de baixo do Imput
            panel1.BackColor = Color.White;
        }

        private void textPasswd_Click(object sender, EventArgs e)
        {
            if (textPasswd.Text == "Password")
            {
                textPasswd.Clear();
            }

            //Muda a cor do sublinhado de baixo do Imput
            panel2.BackColor = Color.FromArgb(0, 210, 65);
            textPasswd.UseSystemPasswordChar = true;
        }

        private void textPasswd_Leave(object sender, EventArgs e)
        {
            if (textPasswd.Text == "")
            {
                textPasswd.Text = "Password";

                textPasswd.UseSystemPasswordChar = false;
            }
            //Muda a cor do sublinhado de baixo do Imput

            panel2.BackColor = Color.White;


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textLogin.Text == "Username")
            {
                label2.Text = "";
                MessageBox.Show("Preencha os Campos");

            }
            else if (textPasswd.Text == "Password")
            {
                label2.Text = "";
                MessageBox.Show("Insira uma Senha");

            }
            else
            {
                VerifyUser();

            }



        }

        #endregion

        //Verifica se usuário e senha dos TextBoxes, estão no banco de Dados
        public void VerifyUser()
        {

            try
            {

                //connect
                SqlCeConnection connection = new SqlCeConnection("Data Source = " + CreateDataBase.conString);
                connection.Open();


                //command
                DataTable table1 = new DataTable();

                string query = "SELECT USER_NAME, PASSWORD FROM Users WHERE USER_NAME =" + "'" + textLogin.Text + "'" + "AND PASSWORD = '" + textPasswd.Text + "'";

                SqlCeDataAdapter command = new SqlCeDataAdapter(query, connection);
                command.Fill(table1);

                //disconect
                command.Dispose();
                connection.Close();


                //verifica se o Registro existe
                if (table1.Rows.Count == 0)
                {
                    MessageBox.Show("Usuário não encontrado");
                    label2.Text = "";
                }
                else
                {
                    string user = table1.Rows[0]["USER_NAME"].ToString();
                    string pass = table1.Rows[0]["PASSWORD"].ToString();


                    //verifica se a senha está correta
                    if (textLogin.Text != user || textPasswd.Text != pass)
                    {


                        label2.Text = "Usuário ou senha Incorreta";

                    }
                    else
                    {
                        User = textLogin.Text;


                        //Esconde o frmLogin
                        this.Hide();

                        // Abre o frmMain    
                        frmMain MainScreen = new frmMain();
                        MainScreen.Show();
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERRO DO SISTEMA - Tente Novamente");
            }

        }


    }
}
