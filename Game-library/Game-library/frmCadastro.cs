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
    public partial class frmCadastro : Form
    {

       

        public frmCadastro()
        {
            InitializeComponent();
        }


        #region Events

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            if (textNewPasswd.Text != textConfirmPasswd.Text)
            {
                
                MessageBox.Show("As Senhas devem ser iguais!");
            }
            else
            {
                InsertUser();
                MessageBox.Show("Usuário Cadastrado com Sucesso");
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textNewUser_Click(object sender, EventArgs e)
        {
            if (textNewUser.Text == "Username")
            {
                textNewUser.Clear();
            }


            panel1.BackColor = Color.FromArgb(0, 210, 65);
        }

        private void textNewPasswd_Click(object sender, EventArgs e)
        {
            if (textNewPasswd.Text == "Password")
            {
                textNewPasswd.Clear();
            }


            panel2.BackColor = Color.FromArgb(0, 210, 65);
            textNewPasswd.UseSystemPasswordChar = true;
        }

        private void textConfirmPasswd_Click(object sender, EventArgs e)
        {
            if (textConfirmPasswd.Text == "Confirm Password")
            {
                textConfirmPasswd.Clear();
            }


            panel3.BackColor = Color.FromArgb(0, 210, 65);
            textConfirmPasswd.UseSystemPasswordChar = true;
        }

        private void textNewUser_Leave(object sender, EventArgs e)
        {
            if (textNewUser.Text == "")
            {
                textNewUser.Text = "Username";
                panel1.BackColor = Color.White;
            }

            
        }

        private void textNewPasswd_Leave(object sender, EventArgs e)
        {
            if (textNewPasswd.Text == "")
            {
                textNewPasswd.Text = "Password";
                panel2.BackColor = Color.White;
                textNewPasswd.UseSystemPasswordChar = false;
            }
        }

        private void textConfirmPasswd_Leave(object sender, EventArgs e)
        {
            if (textConfirmPasswd.Text == "")
            {
                textConfirmPasswd.Text = "Confirm Password";
                panel3.BackColor = Color.White;
                textConfirmPasswd.UseSystemPasswordChar = false;
            }
        }

        #endregion


        // Método para inserir registro no banco de Dados
        public void InsertUser()
        {

            try
            {
                //connection
                SqlCeConnection connection = new SqlCeConnection("Data Source = " + CreateDataBase.conString);
                connection.Open();

                //command
                string query = "INSERT INTO Users(USER_NAME, PASSWORD, DAT_INC_USER) " +
                               "VALUES(" +
                               "'" + textNewUser.Text + "'" + "," +
                               "'" + textNewPasswd.Text + "'" + "," +
                               "'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'" +
                               ")";


                SqlCeCommand sqlCmd = new SqlCeCommand(query, connection);
                sqlCmd.ExecuteNonQuery();
                //close connection/command

                sqlCmd.Dispose();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Não foi Possível inserir o Usuário");
            }








        }

    
    }
}
