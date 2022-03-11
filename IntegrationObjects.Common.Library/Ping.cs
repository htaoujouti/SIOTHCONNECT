using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationObjects.Common.Library
{
    public class Ping
    {
        public int timeOut { get; set; }
        public string IPAddress { get; set; }
        public int retry { get; set; }
    }
}
