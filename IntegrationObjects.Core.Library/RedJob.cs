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
        public RedJob(ConfigurationFile configurationFile)
        {

            if (configurationFile.IsPingEnabled && !configurationFile.IsTCPingEnabled)
            {   // based con config -->Start threads 
               
                    Thread thread = new Thread(() => PingMethodOnly(configurationFile));
                    thread.Start();
                    thread.Name = "PINGThread";
                    thread.IsBackground = true;
                
            }
            else if (!configurationFile.IsPingEnabled && configurationFile.IsTCPingEnabled)
            {   // based con config -->Start threads 
                
                    Thread thread = new Thread(() => TCPingMethodOnly(configurationFile));
                    thread.Start();
                    thread.Name = "TCPINGthread";
                    thread.IsBackground = true;
                
            }
            else if (configurationFile.IsPingEnabled && configurationFile.IsTCPingEnabled)
            {
               
                    Thread Thread = new Thread(() => {
                        PingAndTCPing(configurationFile);
                    });
                    Thread.Start();
                    Thread.Name = "Ping&TCPingThread";
                    Thread.IsBackground = true;
                   
            }
            else
            {

            }

        }

        private void PingAndTCPing(ConfigurationFile configurationFile)
        {
            while (true)
            {
                
            }
        }

        public void PingMethodOnly(ConfigurationFile config)
        {
            try

            {
                while (true)
                {
                    // your code here
                    Ping PingSender = new Ping();
                    long TotalTime = 0;

                    for (int i = 0; i < config.ping.retry; i++)
                    {
                        PingReply reply = PingSender.Send(config.ping.IPAddress, config.ping.timeOut);
                        if (reply.Status == IPStatus.Success)
                        {
                            TotalTime += reply.RoundtripTime;
                        }
                        Console.WriteLine(reply.Status.ToString());
                    }
                    TotalTime = (TotalTime / config.ping.retry);
                    // log stats
                }
            }
            catch (Exception Ex)
            {   //log
                Console.WriteLine("Invalid Ip Address");
            }
            Thread.Sleep(1000);
        }
        
        public void TCPingMethodOnly(ConfigurationFile config)
        {
            try
    {
        while (true)
        {
            var sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var stopwatch = new Stopwatch();
            double t = stopwatch.Elapsed.TotalMilliseconds;

            for (int i = 0; i < config.tCPing.retry; i++)
            {   // Measure the Connect call only
                stopwatch.Start();
                sock.Connect(config.tCPing.IPAddress, config.tCPing.port);
                stopwatch.Stop();
                if (sock.Connected) Console.WriteLine("Success");
                else Console.WriteLine("failed");
                Console.WriteLine("{0:0.00}ms", t);
                sock.Close();
            }
        } }
    catch (Exception Ex)
    {
        Console.WriteLine("Invalid Ip Address or ports");
    }
            Thread.Sleep(1000);

        }

    }
}