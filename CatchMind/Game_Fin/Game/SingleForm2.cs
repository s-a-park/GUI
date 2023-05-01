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
    public partial class SingleForm2 : Form
    {
        Player player;
        Game game;
        Single single;

        public SingleForm2()
        {
            InitializeComponent();

            player = new Player();
            game = new Game();
            single = new Single();

            pictureBox1.Image = imageList1.Images[game.imagenum];
            Goallabel.Text = Convert.ToString(single.GoalSet()) + "점 이상!";

        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
          
            game.ImageAnswer();
            player.PlayerAnswer = textBoxAnswer.Text;

            if (player.PlayerAnswer == game.GameAnswer)
            {
                player.MatchingAnswer();
                game.Result = "정답입니다";


            }
            else if (player.PlayerAnswer != game.GameAnswer)
            {
                player.MatchingAnswer2();
                game.Result = "오답입니다";
            }
            MessageBox.Show(player.Result);
            game.ImageChange();
            pictureBox1.Image = imageList1.Images[game.imagenum];
            labelScore.Text = player.PlayerScore + "점";
            textBoxAnswer.Clear();

            if (player.PlayerScore >= single.GoalSet() )
            {
                player.EndScore();
                labelScore.Text = player.PlayerScore + "점";
                single.FinishGame();
                MessageBox.Show("목표달성, 게임을 종료합니다.");
                this.Hide();
            }



           
        }

        private void Passbutton_Click(object sender, EventArgs e)
        {
            game.ImageChange();
            pictureBox1.Image = imageList1.Images[game.imagenum];
        }

        private void SingleForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
