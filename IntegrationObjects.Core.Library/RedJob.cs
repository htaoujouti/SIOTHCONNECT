using IntegrationObjects.Common.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IntegrationObjects.Core.Library
{
    public class RedJob
    {
        public RedJob(ConfigurationFile configurationFile )
        {
            // based con config -->Start threads 
            Thread thread = new Thread(() => PingMethodOnly());
            thread.Start();
            thread.Name = "";
            thread.IsBackground = true;

        }
        private void PingMethodOnly()
        {
            while (true)
            {
                try
                {
                    // your code here

                    // log stats
                }
                catch (Exception Ex)
                {
                    //log
                }
                Thread.Sleep(1000);
            }
        }

    }
}
