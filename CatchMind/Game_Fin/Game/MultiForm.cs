using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace Game
{
    public partial class MultiForm : Form
    {
        Player player;
        Game game;
        Multi multi;

        TcpClient clientSocket = new TcpClient();
        NetworkStream stream = default(NetworkStream);

        List<Socket> sockets = new List<Socket>();

        public MultiForm()
        {
            InitializeComponent();

            player = new Player();
            game = new Game();
            multi = new Multi();

            clientSocket.Connect("192.168.1.121", 9999);
            stream = clientSocket.GetStream();
            string message = "서버에 연결합니다";

            Thread t = new Thread(getMessage);
            t.IsBackground = true;
            t.Start();




            pictureBox1.Image = imageList1.Images[game.imagenum];

            

        }
        private void getMessage()
        {
            while (true)
            {
                stream = clientSocket.GetStream();
                int size = clientSocket.ReceiveBufferSize;
                byte[] buffer = new byte[size];
                int bytes = stream.Read(buffer, 0, buffer.Length);
                string message = Encoding.Unicode.GetString(buffer, 0, bytes);
                richTextBoxChat.Invoke(new Action(() => richTextBoxChat.AppendText(message + "\n")));
            }
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
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.Unicode.GetBytes(textBoxChat.Text.ToString() + "$");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
            textBoxChat.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            multi.Timer();

            if (multi.minute == 0 && multi.second == 0)
            {
                timer1.Stop();
                player.EndScore();
                MessageBox.Show("Time Over!!");
                this.Hide();
                MultiLank multiLankForm = new MultiLank();
                multiLankForm.Show();
            }
            labelMin.Text = Convert.ToString(multi.minute);
            labelSec.Text = Convert.ToString(multi.second);
        }

        private void MultiForm_Load(object sender, EventArgs e)
        {

        }
    }
}
