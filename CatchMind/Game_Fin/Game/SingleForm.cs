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
    public partial class SingleForm : Form
    {
        Player player;
        Game game;
        Single single;

        int second = 0;
        int minute = 2;

        

        public SingleForm()
        {
            InitializeComponent();

            timer1.Start();

            player = new Player();
            game = new Game();
            single = new Single();

            pictureBox1.Image = imageList1.Images[game.imagenum];

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
            else if(player.PlayerAnswer!=game.GameAnswer)
            {
                player.MatchingAnswer2();
                game.Result = "오답입니다";
            }
            MessageBox.Show(player.Result);
            game.ImageChange();
            
            labelScore.Text = player.PlayerScore+"점";
            textBoxAnswer.Clear();
            game.ImageChange();
            pictureBox1.Image = imageList1.Images[game.imagenum];
           

            
        }

        private void Passbutton_Click(object sender, EventArgs e)
        {
            game.ImageChange();
            pictureBox1.Image = imageList1.Images[game.imagenum];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Interval = 1000;
            single.Timer();
            
            if (single.minute == 0 && single.second == 0)
            {
                timer1.Stop();
                player.EndScore();
                
                
                MessageBox.Show("Time Over!");
                this.Hide();
                SingleLankForm singleLankForm = new SingleLankForm();
                singleLankForm.Show();
            }
            labelMin.Text = Convert.ToString(single.minute);
            labelSec.Text = Convert.ToString(single.second);
        }
    }
}
