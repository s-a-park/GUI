using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class SingleLankForm : Form
    {
        Player player;
        Game game;
        Single single;
        SingleForm singleForm;

        public SingleLankForm()
        {
            InitializeComponent();

            player = new Player();
            game = new Game();
            single = new Single();
            singleForm = new SingleForm();

            player.EndScore();
            
            labelScore.Text =game.Allscore + "점";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SingleLankForm_Load(object sender, EventArgs e)
        {

        }
    }
}
