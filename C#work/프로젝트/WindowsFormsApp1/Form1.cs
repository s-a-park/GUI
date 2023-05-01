using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static Random random = new Random();
       

        Player player;
        Game game;
       
        public Form1()
        {
            player = new Player();
            game = new Game();
           
            InitializeComponent();
            pictureBox1.Image = imageList1.Images[game.imagenum];

            if (pictureBox1.Image == imageList1.Images[0])
            {
                game.GameAnswer = "사자";

            }
            else if (pictureBox1.Image == imageList1.Images[1])
            {
                game.GameAnswer = "사과";
            }
            else if (pictureBox1.Image == imageList1.Images[2])
            {
                game.GameAnswer = "고양이";
            }




        }



        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = player.PlayerAnswer;
            player.MatchingAnswer();
            MessageBox.Show(player.Result);
            label2.Text = "점수 :" + player.PlayerScore;
            game.ImageChange();
            pictureBox1.Image = imageList1.Images[game.imagenum];

            if (player.PlayerScore == game.PlayerGoal)
            {
                player.EndScore();
                label2.Text = "점수 :" + player.Allscore;
                MessageBox.Show("목표달성, 게임을 종료합니다");
            }
        }
    }
}
