using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationObjects.Common.Library
{
    public class ConfigurationFile
    {
        public Ping ping;
        public TCPing tCPing;
        public bool IsPingEnabled { get; set; }
        public bool IsTCPingEnabled { get; set; }
    }
}
