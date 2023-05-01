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
using System.Net.Sockets;
using System.Net;

namespace client
{
    public partial class Form1 : Form
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream stream = default(NetworkStream);
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            clientSocket.Connect("127.0.0.1", 9999);
            stream = clientSocket.GetStream();

            string message = "Connect to Chat Server";
            connectButton.Visible = false;
            connectTextBox.Enabled = false;

            byte[] buffer = Encoding.Unicode.GetBytes(connectTextBox.Text.ToString() + "$");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();

            Thread t = new Thread(getMessage);
            t.IsBackground = true;
            t.Start();
        }

        private void getMessage()
        {
            while(true)
            {
                stream = clientSocket.GetStream();
                int size = clientSocket.ReceiveBufferSize;
                byte[] buffer = new byte[size];
                int bytes = stream.Read(buffer, 0, buffer.Length);
                string message = Encoding.Unicode.GetString(buffer, 0, bytes);
                richTextBox1.Invoke(new Action(() => richTextBox1.AppendText(message+"\n")));

            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.Unicode.GetBytes(sendTextBox.Text.ToString() + "$");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
