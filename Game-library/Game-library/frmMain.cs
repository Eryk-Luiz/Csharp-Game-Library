using System;
using System.Windows.Forms;

namespace Game_library
{
    public partial class frmMain : Form
    {


        #region Instancias de outros Formulários e userControls.
        CreatingGameTable creatingGameTable = new CreatingGameTable();
        New_Game New = new New_Game();
        library library = new library();
        GameBanner game = new GameBanner();
        editGame editGame = new editGame();
        #endregion

        public frmMain()
        {
            InitializeComponent();

            

            labelLoggedUser.Text = frmLogin.User;


        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            creatingGameTable.CreatingTable();
           
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

        #endregion

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

        #region Aletera o Conteúdo de cada panel(UserControl)
        public void ChangePanelContent(Control Button)
        {
            panelLibrary.Controls.Clear();
            panelLibrary.Controls.Add(Button);
        }
        
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            ChangePanelContent(New);
           
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            ChangePanelContent(library);
            library.flowLayoutPanel1.Controls.Clear();
            library.getGameInfo();

        }

        private void btnEditGame_Click(object sender, EventArgs e)
        {
            ChangePanelContent(editGame);
            editGame.LoadCombo();
        }
        #endregion


    }

}

