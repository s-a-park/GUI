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

namespace Server
{
    public partial class Form1 : Form
    {
        TcpListener server = null; // 서버
        TcpClient clientSocket = null;  //소켓(연결해서 데이터를 주고받는거 )
        string date; //날짜

        //각 클라이언트 마다 리스트에 추가(접속자 추가)
        public Dictionary<TcpClient, string> clientList = new Dictionary<TcpClient, string>(); 
        
        public Form1()
        {
            InitializeComponent();
            //쓰레드 생성
            Thread t = new Thread(initSocket);
            t.IsBackground = true;
            t.Start();
        }

        private void initSocket()
        {
            /*서버는 클라이언트의 연결 요청이 언제 발생할 것인지 모르기 때문에 계속 연결 욫어을 대기하는 상태로 있어야함
             IPAddress.Any - 사용 중인 '모든' 네트워크 인터페이스(랜카드에 할당된 IP 주소)를 나타냄 */
            server = new TcpListener(IPAddress.Any, 9999);  //서버 접속 IP, 포트 (연결요청을 대기하는 작업)
            clientSocket = default(TcpClient);  //소켓 설정
            server.Start();     //서버 시작

            while (true)
            {
                //예상치 못한 오류로 인해 소켓 생성이 실패할 수 있으므로 try ~ catch를 이용하여 예외 처리를 해줌
                try
                {
                    /*동기식 연결 요청을 받는 방법(동기=작업이 완료될 때까지 기다리는 것)
                      Accept-> "연결 요청이 있을 때까지 무한 루프를 돌며 대기"하게 됨.
                      때라서 연결 요청이 오지 않으면 다음 코드로 넘어가지 않음 */
                    clientSocket = server.AcceptTcpClient();    //client 소켓 접속 허용
                    
                    richTextBox1.Invoke(new Action(() => richTextBox1.AppendText(">>Server Started \n")));
                    NetworkStream stream = clientSocket.GetStream();
                    byte[] buffer = new byte[1024]; //버퍼 
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    string userName = Encoding.Unicode.GetString(buffer, 0, bytes);
                    userName = userName.Substring(0, userName.IndexOf("$"));    //client 사용자 명

                    clientList.Add(clientSocket, userName); //client 리스트에 추가

                    richTextBox1.Invoke(new Action(() => richTextBox1.AppendText(userName + "님이 참가하셨습니다. \n")));  //richTextBox1에 AppendText값 넣기

                    sendMessageAll(userName + "님이 참가하셨습니다.", "", false); //모든 client에게 메세지 전송

                    HandleClient handleclient = new HandleClient(); // 클라이언트 추가
                    handleclient.OnReceived += new HandleClient.MessageDisplayHandler(onReceived);  // 실행될 메소드
                    handleclient.startClient(clientSocket, clientList);
                }catch(SocketException se)
                {
                    break;
                }
                catch(Exception ex) // 발생한 예외 정보 ex에 대한 예외 처리
                {
                    break;
                }
                
            }
        }

        private void onDisconnected(TcpClient clientSocket)     //client 접속 해제 핸들러
        {
            if (clientList.ContainsKey(clientSocket))
                clientList.Remove(clientSocket);
        }
        
        private void onReceived(string message, string userName)    //client로 부터 받은 데이터
        {
            string displayMessage = "From Client : " + userName + " : " + message;
            richTextBox1.Invoke(new Action(() => richTextBox1.AppendText(displayMessage + "\n")));
            sendMessageAll(message, userName, true);    //모든 Client에게 전송 
        }

        private void sendMessageAll(string message, string userName, bool flag)
        {
            foreach(var pair in clientList)  //접속된 사용자의 수만큼 돌아감
            {
                date = DateTime.Now.ToString("yyyy.MM.dd. HH:mm:ss"); //현재 날짜 받기
                TcpClient client = pair.Key as TcpClient;
                NetworkStream stream = client.GetStream();
                byte[] buffer = null;

                if(flag)  //message 전달
                {
                    buffer = Encoding.Unicode.GetBytes("["+ date+" ]" +userName + " : " + message);
                }
                else   //누가 접속했을때 누군지 알려줌
                {
                    buffer = Encoding.Unicode.GetBytes(message); 
                } 
                stream.Write(buffer, 0, buffer.Length);    //버퍼 쓰기
                stream.Flush();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
