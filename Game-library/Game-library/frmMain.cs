using System;
using System.Windows.Forms;

namespace Game_library
{
    public partial class frmMain : Form
    {

        New_Game New = new New_Game();
        library library = new library();
        GameBanner game = new GameBanner();

        public frmMain()
        {
            InitializeComponent();

            

            labelLoggedUser.Text = frmLogin.User;


        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            New.CreatingGameTable();
            library.getGameInfo();
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
        public void ChangePanelContent(Control Button)
        {
            panelLibrary.Controls.Clear();
            panelLibrary.Controls.Add(Button);
        }
        

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            ChangePanelContent(New);
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            ChangePanelContent(library);
            library.flowLayoutPanel1.Controls.Clear();
            library.getGameInfo();

        }

        #endregion
    }

}

