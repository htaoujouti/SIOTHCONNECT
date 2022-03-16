using IntegrationObjects.Common.Library;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ping = System.Net.NetworkInformation.Ping;

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
                // based con config -->Start threads 
                Thread thread = new Thread(() => TCPingMethodOnly(configurationFile));
                thread.Start();
                thread.Name = "";
                thread.IsBackground = true;
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
                    Ping PingSender = new Ping();                   
                    long TotalTime = 0;
                    int Success = 0;
                    
                    for (int i = 0; i < config.ping.retry; i++)
                    {
                        PingReply reply = PingSender.Send(config.ping.IPAddress, config.ping.timeOut);
                        if (reply.Status == IPStatus.Success)
                        {
                            TotalTime += reply.RoundtripTime;
                            Success++;                                                                                       
                        }
                    }
                    Success = (Success / config.ping.retry)*100;
                    TotalTime = (TotalTime / config.ping.retry);





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
        public void TCPingMethodOnly(ConfigurationFile config)
        {
            while (true)
            {
                try
                {
                    for (int i = 0; i < config.tCPing.retry; i++)
                    {
                        var sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        sock.Blocking = true;

                        var stopwatch = new Stopwatch();

                        // Measure the Connect call only
                        stopwatch.Start();
                        sock.Connect(config.tCPing.IPAddress, config.tCPing.port);
                        stopwatch.Stop();
                        double t = stopwatch.Elapsed.TotalMilliseconds;
                        Console.WriteLine("{0:0.00}ms", t);
                        sock.Close();
                    }
                }
                catch (Exception Ex)
                {
                    Console.WriteLine("Invalid Ip Address or ports");
                }
                Thread.Sleep(1000);
            }
        }

    }
}
