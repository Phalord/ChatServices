using ChatServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChatServiceHost
{
    class ChatServiceHost
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ChatService)))
            {
                host.Open();
                Console.WriteLine("Server Started...");
                Console.ReadLine();
            }
        }
    }
}
