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
        
        private RequestSocket client;
        public Serverconnect()
        {
            client = new RequestSocket();
            client.Connect("tcp://localhost:5555");
        }

        public void Connectortest()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Sending Hello");
                client.SendFrame("Hello");
                var message = client.ReceiveFrameString();
                Console.WriteLine("Received {0}", message);
            }
        }

        public void Get_mission()
        { 
            // TODO:fetch mission from the server , make the mission list like below.
            // List<List<string>> = [panelid, origin image path, result path]
        }

        public bool push_panel_result()
        {
            // TODO:
            return true;
        }

        public bool check_user_password()
        {
            // TODO:
            return true;
        }
    }
}
