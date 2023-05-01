using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    /*클라이언트에서 서버와 연결하고 통신하기 위해 해야 할 역할
      서버의 주소와 포트를 이용하여 연결을 시도해야 함
      비동기적으로 들어오는 데이터(텍스트)를 텍스트박스에 표시해야함
      서버가 데이터를 보내지 않았어도 클라이언트가 원할 때 데이터를 보낼 수 있어야함 */
    public partial class Form1 : Form
    {

        TcpClient clientSocket = new TcpClient(); //소켓 (=채팅 기능)
        NetworkStream stream = default(NetworkStream);

        public Form1()
        {
            InitializeComponent();
        }
      

        private void getMessage()  //메세지 받기
        {
            while (true)
            {
                stream = clientSocket.GetStream();
                int size = clientSocket.ReceiveBufferSize;
                byte[] buffer = new byte[size];
                int bytes = stream.Read(buffer, 0, buffer.Length);

                string message = Encoding.Unicode.GetString(buffer, 0, bytes);
                richTextBox1.Invoke(new Action(() => richTextBox1.AppendText(message + "\n")));
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)  //"입력"버튼이 눌렀을 때 서버에 접속시도
        {
            //서버 또는 특정 소켓에 연결하기 위해서는 Socket.Connect 메서드를 호출하면 됨
            clientSocket.Connect("192.168.219.103", 9999);  //접속 IP 및 포트(port)
            stream = clientSocket.GetStream();

            string message = "채팅 서버에 연결 되었습니다.";
            button1.Visible = false;
            nameTextBox.Enabled = false;

            richTextBox1.AppendText(message + "\n");

            byte[] buffer = Encoding.Unicode.GetBytes(nameTextBox.Text + "$");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();

            //쓰레드 생성
            Thread t = new Thread(getMessage);
            t.IsBackground = true;
            t.Start();
        }
         //"채팅 전송"버튼이 눌렸을 때 매세지 보내기
        private void button2_Click_1(object sender, EventArgs e) 
        {
            byte[] buffer = Encoding.Unicode.GetBytes(connectTextBox.Text.ToString() + "$");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
            connectTextBox.Clear();  //메세지 보냈을때 입력창 지우기
        }

        private void connectTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
