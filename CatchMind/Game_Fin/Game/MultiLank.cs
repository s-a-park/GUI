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
    public partial class MultiLank : Form
    {
        Player player;
        Game game;
        Multi multi;

        public MultiLank()
        {
            player = new Player();
            game = new Game();
            multi = new Multi();

            InitializeComponent();

            int TimScore = player.Allscore;
            int ComeScore1 = multi.ComScore();
            int ComeScore2 = multi.ComScore();
            int ComeScore3 = multi.ComScore();

            Timlabel.Text = Convert.ToString(player.Allscore) + "점";

            Onelabel.Text = Convert.ToString(multi.ComScore()) + "점";
            Twolabel.Text = Convert.ToString(multi.ComScore()) + "점";
            Threelabel.Text = Convert.ToString(multi.ComScore()) + "점";

            int[] Score = new int[4] { TimScore, ComeScore1, ComeScore2, ComeScore3 };
            int Max = 0;

            for (int i = 1; i < Score.Length; i++)

            {

                if (Max < Score[i])

                    Max = Score[i];

            }

            if (Max == TimScore)
            {
                Namelabel.Text = "우리팀";

            }
            else if (Max == ComeScore1)
            {
                Namelabel.Text = "Com1";
            }
            else if (Max == ComeScore2)
            {
                Namelabel.Text = "Com2";
            }
            else
            {
                Namelabel.Text = "Com3";
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
