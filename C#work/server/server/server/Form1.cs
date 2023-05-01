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

namespace server
{
    public partial class Form1 : Form
    {
        TcpListener server = null;
        TcpClient clientSocket = null;

        public Dictionary<TcpClient, string> clientList = new Dictionary<TcpClient, string>();

        public Form1()
        {
            InitializeComponent();
            Thread t = new Thread(initSocket);
            t.IsBackground = true;
            t.Start();
        }

        private void initSocket()
        {
            server = new TcpListener(IPAddress.Any, 9999);
            clientSocket = default(TcpClient);
            server.Start();

            while(true)
            {
                try
                {
                    clientSocket = server.AcceptTcpClient();
                    richTextBox1.Invoke(new Action(() => richTextBox1.AppendText("Server Start!")));

                    NetworkStream stream = clientSocket.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    string userName = Encoding.Unicode.GetString(buffer, 0, bytes);
                    userName = userName.Substring(0, userName.IndexOf("$"));

                    clientList.Add(clientSocket, userName);

                    richTextBox1.Invoke(new Action(() => richTextBox1.AppendText(userName+"님이 참가하셨습니다.\n")));

                    sendMessageAll(userName + " 님이 참가하셨습니다.", "", false);

                    HandleClient handleClient = new HandleClient();
                    handleClient.OnReceived += new HandleClient.MessageDisplayHandler(onReceived); // 실행될 메소드 
                    handleClient.OnDisconnected += new HandleClient.DisconnectedHandler(onDisconnedted); //연결이 끊켰을때 실행될 메소드
                    handleClient.startClient(clientSocket, clientList);
                    
                } catch(SocketException se)
                {
                    break;
                } catch(Exception se)
                {
                    break;
                }
              

            }
          
        }

        private void onDisconnedted(TcpClient clientSocket)
        {
            if (clientList.ContainsKey(clientSocket))
                clientList.Remove(clientSocket);
        }
        private void onReceived(string message, string userName)
        {
            string displayMessage = "From Client :" + userName + " : " + message;
            richTextBox1.Invoke(new Action(() => richTextBox1.AppendText(displayMessage + "\n")));
            sendMessageAll(message, userName, true);
        }

        private void sendMessageAll(string message, string userName, bool flag)
        {
            foreach(var pair in clientList) //접속된 사용자의 수만큼 돌아간다.
            {
                TcpClient client = pair.Key as TcpClient;
                NetworkStream stream = client.GetStream();
                byte[] buffer = null;

                if(flag) // message전달 
                {
                    buffer = Encoding.Unicode.GetBytes(userName + " : " + message);
                } else // 누가 접속했을때 누군지 알려줌
                {
                    buffer = Encoding.Unicode.GetBytes(message);
                }
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
