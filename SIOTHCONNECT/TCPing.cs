using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIOTHCONNECT
{
    public class TCPing : Ping
    {
        public int port { get; set; }
        public TCPing() { }
        public TCPing(string IPAddress, int timeOut, int retry,int port):base( IPAddress, timeOut, retry)
        {
            this.port = port;
        }

    }
}
