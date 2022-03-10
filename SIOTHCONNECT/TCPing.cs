using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIOTHCONNECT
{
    public class TCPing : Ping
    {
        private int port { get; set; }

        public TCPing() { }
        public TCPing(string IPAddress, int timeOut, int retry, int port)
        {
            this.IPAddress = IPAddress;
            this.timeOut = timeOut;
            this.retry = retry;
            this.port = port;               
        }
    }
}
