using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetMQ;
using NetMQ.Sockets;


namespace WindowsFormsApp1
{
    class Serverconnect
    {
        public Serverconnect()
        {
            client = new RequestSocket();
            client.Connect("tcp://localhost:5555");
        }

        private RequestSocket client;

        public void Serverconnector()
        {
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Sending Hello");
                client.SendFrame("Hello");
                var message = client.ReceiveFrameString();
                Console.WriteLine("Received {0}", message);
            }
        }
    }
}
