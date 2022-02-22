using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace StpisKursachZhyhadlo
{
    class TCPConnector
    {
        public static TcpClient tcp_client = new TcpClient("localhost", 5555);
    }
}
