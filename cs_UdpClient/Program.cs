using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace cs_UdpClient
{
    class Program
    {
        static void Main()
        {
            var client = new UdpClient();

            var connectEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 45678);

            while (true)
            {
                var str = Console.ReadLine();
                var bytes = Encoding.Default.GetBytes(str);
                client.Send(bytes, bytes.Length, connectEP);
            }
        }
    }
}
