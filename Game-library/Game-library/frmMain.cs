using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using XanderUI;

namespace Game_library
{
    public partial class frmMain : Form
    {
        public int count = 2;

        public frmMain()
        {
            InitializeComponent();
            
            
            labelLoggedUser.Text = "Welcome " + frmLogin.User;
            labelLoggedUser.Text.ToUpper();

        }

        #region WindowState

        private void panel5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        #region MoveWindow
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void frmMain_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }







        #endregion

        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            listContainer(count);
        }

        private void listContainer(int count)
        {
            GameBanner game = new GameBanner();
            List<GameBanner> list = new List<GameBanner>();



            for (int i = 0; i < count; i++)
            {
                game.genre = "Action";
                game.title = "Resident Evil";
                game.description = "Horror Game";
                list.Add(game);

                flowLayoutPanel1.Controls.Add(list[i]);
               
            }
            
                               
         }

   
    }

    }

