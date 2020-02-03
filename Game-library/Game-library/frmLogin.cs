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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        #region Events

        private void textLogin_Click(object sender, EventArgs e)
        {
            if (textLogin.Text == "Username")
            {
                textLogin.Clear();
            }
            

            panel1.BackColor = Color.FromArgb(0, 210, 65);
        }

        private void textLogin_Leave(object sender, EventArgs e)
        {
            if (textLogin.Text == "")
            {
                textLogin.Text = "Username";
                panel1.BackColor = Color.White;
            }
        }

        private void textPasswd_Click(object sender, EventArgs e)
        {
            if (textPasswd.Text == "Password")
            {
                textPasswd.Clear();
            }
            

            panel2.BackColor = Color.FromArgb(0, 210, 65);

            textPasswd.UseSystemPasswordChar = true;
        }

        private void textPasswd_Leave(object sender, EventArgs e)
        {
            if (textPasswd.Text == "")
            {
                textPasswd.Text = "Password";
                textPasswd.UseSystemPasswordChar = false;
                panel2.BackColor = Color.White;

            }

            
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
                MessageBox.Show("Preencha os Campos");
            }
            else if (textPasswd.Text == "Password") 
            {
                MessageBox.Show("Campo de senha Vazio");
            }
            else
            {
                VerifyUser();
            }
            
            

        }

        #endregion

        private void frmLogin_Load(object sender, EventArgs e)
        {
            CreateDataBase.CreateDataDirectory();
            label1.Text = CreateDataBase.version;
            label1.ForeColor = Color.FromArgb(0, 210, 65);
        }


        public void VerifyUser()
        {

            try
            {
                SqlCeConnection connection = new SqlCeConnection("Data Source = " + CreateDataBase.conString);
                connection.Open();

                DataTable table = new DataTable();

                string query = "SELECT USER_NAME, PASSWORD FROM Users WHERE USER_NAME =" + "'" + textLogin.Text + "'" + "OR PASSWORD = '" + textPasswd.Text + "'";

                SqlCeDataAdapter command = new SqlCeDataAdapter(query, connection);
                command.Fill(table);

                command.Dispose();
                connection.Close();

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Usuário não encontrado");
                }
                else
                {
                    string user = table.Rows[0]["USER_NAME"].ToString();
                    string pass = table.Rows[0]["PASSWORD"].ToString();

                    if (textLogin.Text == user && textPasswd.Text == pass)
                    {
                        MessageBox.Show("Logou");
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos");
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERRO DO SISTEMA");
            }

        }

        
    }
}
