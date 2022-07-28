using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Snake2 : Form
    {

        Game game;

        public Snake2()
        {
            InitializeComponent();

            game = new Game(ref Frame, ref LbPontuacao, ref PnTela);

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void novoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.StartGame();
        }

        private void Frame_Tick(object sender, EventArgs e)
        {
            game.Tick();

        }

        private void clicado(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Down|| e.KeyCode == Keys.Up)
            {
                game.Arrow = e.KeyCode;


            }
        }
    }
}
