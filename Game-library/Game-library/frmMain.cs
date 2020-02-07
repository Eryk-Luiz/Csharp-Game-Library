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
        
        New_Game New = new New_Game();
        library library = new library();

        public frmMain()
        {
            InitializeComponent();
            
            
            labelLoggedUser.Text = frmLogin.User;
            

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChangePanelContent(library);
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


        #region On Click, aletera conteúdo do Panel
        public void ChangePanelContent(Control buttons)
        {
            panelLibrary.Controls.Clear();

            panelLibrary.Dock = DockStyle.Fill;

            panelLibrary.Controls.Add(buttons);
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            ChangePanelContent(New);
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            ChangePanelContent(library);
        }

        #endregion
    }

}

