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
    public partial class GameEdit : Form
    {
        public GameEdit()
        {
            GameBanner gamebanner = new GameBanner();
            editGame game = new editGame();

            InitializeComponent();
            panel1.Controls.Add(game);
            game.GetGameToEdit(gamebanner.title);
        }

    }
}
