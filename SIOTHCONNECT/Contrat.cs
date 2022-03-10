using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIOTHCONNECT
{
    public class Contrat
    {
        public Ping ping;
        public TCPing tCPing;
        public Contrat() { }
        public Contrat(Ping ping,TCPing tCPing) { 
            this.ping = ping;
            this.tCPing = tCPing;
        }
    }
}
