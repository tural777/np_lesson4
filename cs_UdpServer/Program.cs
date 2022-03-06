using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace cs_UdpServer
{
    class Program
    {
        static void Main()
        {
            var client = new UdpClient(45678);

            var remoteEP = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                var bytes = client.Receive(ref remoteEP);
                var str = Encoding.Default.GetString(bytes);
                Console.WriteLine(str);
            }
        }
    }
}
