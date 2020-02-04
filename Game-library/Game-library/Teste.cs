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
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();
        }

        private void Teste_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            CriarControles();
        }


        private void CriarControles()
        {
            Point location = new Point(0, 20);
            for (int i = 0; i < 5; i++)
            {
                Button b = new Button();
                b.Name = "Button" + (i + 1);
                b.Text = b.Name;
                location.Y += 30;
                b.Location = location;
                b.Click += new EventHandler(b_Click);
                this.Controls.Add(b);
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            MessageBox.Show(b.Name);
        }
    }
}
