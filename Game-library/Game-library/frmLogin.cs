using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textLogin.Text == "erykluizvieira@gmail.com" && textPasswd.Text == "emilly0312")
            {
                MessageBox.Show("Usuário Logado");
            }
            else
            {
                MessageBox.Show("Usuário Incorreto ou Não existe");
            }
        }

        #endregion

        private void frmLogin_Load(object sender, EventArgs e)
        {
            label1.Text = CreateDataBase.version;
            label1.ForeColor = Color.FromArgb(0, 210, 65);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.ShowDialog();
        }
    }
}
