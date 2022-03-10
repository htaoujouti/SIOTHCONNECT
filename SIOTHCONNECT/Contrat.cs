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
        public bool IsPingEnabled { get; set; }
        public bool IsTCPingEnabled { get; set; }
        
        // public Contrat() { }
        // public Contrat(TCPing tCPing)
        // {
        //     this.tCPing = tCPing;
        // }
        // public Contrat(Ping ping)
        // {
        //     this.ping = ping;
        //}
        // public Contrat(Ping ping,TCPing tCPing) { 
        //     this.ping = ping;
        //     this.tCPing = tCPing;
        // }
    }
}
