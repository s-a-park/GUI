using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace Server
{
    /*서버가 해야 할 역할 
     * 클라이언트의 연결 요청이 들어올 때마다 연결 요청을 수락
     * 수신한 데이터가 있으면 데이터 송신자를 제외한 클라이언트들에게 다시 전달
     * 클라이언트의 연결 요청을 관리함
     */
    class HandleClient
    {

        TcpClient clientSocket = null;
        public Dictionary<TcpClient, string> clientList = null; //각 클라이언트 마다 리스트에 추가(접속자 추가)

        public delegate void MessageDisplayHandler(string message, string userName);
        public event MessageDisplayHandler OnReceived;

        public delegate void DisconnectedHandler(TcpClient clientSocket);
        public event DisconnectedHandler OnDisconnected;

        public void startClient(TcpClient clientSocket, Dictionary<TcpClient, string> clientList)
        {
            this.clientSocket = clientSocket;
            this.clientList = clientList;
            //쓰레드 생성
            Thread t = new Thread(doChat);
            t.IsBackground = true;
            t.Start();
        }

        private void doChat()
        {
            NetworkStream stream = null;
            //예상치 못한 오류로 인해 소켓 생성이 실패할 수 있으므로 try ~ catch를 이용하여 예외 처리를 해줌
            try
            {
                byte[] buffer = new byte[1024];
                string msg = "";
                int bytes = 0;

                while (true)
                {
                    stream = clientSocket.GetStream();
                    bytes = stream.Read(buffer, 0, buffer.Length);
                    msg = Encoding.Unicode.GetString(buffer, 0, bytes);
                    msg = msg.Substring(0, msg.IndexOf("$"));

                    if (OnReceived != null)
                        OnReceived(msg, clientList[clientSocket].ToString());
                }
            }
            catch(SocketException se)
            {
                if (clientSocket != null)
                    OnDisconnected(clientSocket);

                clientSocket.Close();
                stream.Close();
            } catch(Exception ex)  // 발생한 예외 정보 ex에 대한 예외 처리
            {
                if (clientSocket != null)
                    OnDisconnected(clientSocket);

                clientSocket.Close();
                stream.Close();
            }
        }   //TCP 프로토콜을 사용하는 소켓을 사용할 준비 완료
    }
}
