using IntegrationObjects.Common.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ping = IntegrationObjects.Common.Library.Ping;

namespace IntegrationObjects.Core.Library
{
    public class RedJob
    {
        public RedJob(ConfigurationFile configurationFile )
        {

            if (configurationFile.IsPingEnabled && !configurationFile.IsTCPingEnabled)
            {
                // based con config -->Start threads 
                Thread thread = new Thread(() => PingMethodOnly(configurationFile));
                thread.Start();
                thread.Name = "";
                thread.IsBackground = true;
            }
            else if(!configurationFile.IsPingEnabled && configurationFile.IsTCPingEnabled)
            {

            }
            else if(configurationFile.IsPingEnabled && configurationFile.IsTCPingEnabled){

            }
            else
            {

            }

        }
        public void PingMethodOnly(ConfigurationFile config)
        {
            while (true)
            {
                try
                {
                    // your code here
                    Ping pingSender = new Ping();
                    pingSender = config.ping;
                    long totalTime = 0;
                    
                        for (int i = 0; i < pingSender.retry; i++)
                        {
                            PingReply reply = pingSender.Send(pingSender.IPAddress, pingSender.timeOut);
                            if (reply.Status == IPStatus.Success)
                            {
                                totalTime += reply.RoundtripTime;

                                Console.WriteLine(reply.Status);
                           
                            }
                        }
                        
                    
                    
                        
                    

                    // log stats
                }
                catch (Exception Ex)
                {
                    //log
                    Console.WriteLine("Invalid Ip Address");
                }
                Thread.Sleep(1000);
            }
        }

    }
}
