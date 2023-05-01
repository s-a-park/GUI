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
using System.IO;

namespace FinalExam
{ 
    public partial class Form1 : Form
    {
        public static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//1) 소켓을 만들어준다
        public byte[] rcvdata = new byte[2056];
        public byte[] sendata =new byte[2056];
       
        IPAddress serverIP ;
        IPEndPoint serverEndPoint ; 

        public Form1(){
            InitializeComponent();//항상 먼저 나와야한다.          
            textBox2.Text = "------------------------------------------------------"  + "\n" ;
            textBox2.Text += "연결해주세요[Connect버튼을 눌러주세요]" + "\n";
            textBox2.Text += "-----------------------------------------------------" + "\n";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string send_data = textBox1.Text;
            
            textBox2.AppendText("송신:" + send_data);
            textBox2.AppendText("\r\n");
            sendata = Encoding.UTF7.GetBytes(send_data);
            socket.Send(sendata, 0, sendata.Length, SocketFlags.None);

            Thread tt = new Thread(getMessage);
            tt.IsBackground = true;
            tt.Start();
                        
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            serverIP = IPAddress.Parse("127.0.0.1");
            serverEndPoint = new IPEndPoint(serverIP, 5021);
        }

        private void getMessage()
        {
            while (true)
            {
                socket.Receive(rcvdata, 0, rcvdata.Length, SocketFlags.None);
                int getValueLength = byteArrayDefrag(rcvdata);
                string rcv_data = Encoding.UTF7.GetString(rcvdata, 0, rcvdata.Length-1);
                textBox2.AppendText( "\r\n");
                textBox2.AppendText("수신:" + rcv_data);
              
            }
            

        }


        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                socket.Connect(serverEndPoint);
                if (socket.Connected)
                {
                    label_ConnectFlag.Text = "Connected";
                }
            }catch(Exception se)
            {
                label_ConnectFlag.Text = "Disconnected";
            }
           


        }

        public static int byteArrayDefrag(byte[] sData)
        {
            int endLength = 0;
            for (int i = 0; i < sData.Length; i++)
            {
                if ((byte)sData[i] != (byte)0)
                {
                    endLength = i;
                }
            }
            return endLength;

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fr2 = new Form3();
            fr2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fr3 = new Form4();
            fr3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter sw1 = new StreamWriter(folder + @"\스마트정보통신공학과_201821026_김나현.txt");
            sw1.WriteLine(textBox_BiBun.Text);
            sw1.Close();
            label_Hak.Text = "파일을 확인하세요";
        }
    }
    

}
