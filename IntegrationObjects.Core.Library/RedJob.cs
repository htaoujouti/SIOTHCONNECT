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
using Serilog;
using Ping = System.Net.NetworkInformation.Ping;

namespace IntegrationObjects.Core.Library
{
    public class RedJob
    {
        public RedJob(ConfigurationFile configurationFile)
        {

            if (configurationFile.IsPingEnabled && !configurationFile.IsTCPingEnabled)
            {   // based con config -->Start threads 

                Thread thread = new Thread(() => Ping(configurationFile));
                thread.Start();
                thread.Name = "PINGThread";
                thread.IsBackground = true;

            }
            else if (!configurationFile.IsPingEnabled && configurationFile.IsTCPingEnabled)
            {   // based con config -->Start threads 
                Thread thread = new Thread(() => TCPing(configurationFile));
                thread.Start();
                thread.Name = "TCPINGthread";
                thread.IsBackground = true;

            }
            else if (configurationFile.IsPingEnabled && configurationFile.IsTCPingEnabled)
            {
                Thread Thread = new Thread(() => PingAndTCPing(configurationFile));
                Thread.Start();
                Thread.Name = "PingAndTCPingThread";
                Thread.IsBackground = true;

            }

        }
        public void PingAndTCPing(ConfigurationFile configurationFile)
        {
            while (true)
            {
                PingMethodOnly(configurationFile);
                TCPingMethodOnly(configurationFile);
                Thread.Sleep(1000);
            }
        }
        public void Ping(ConfigurationFile configurationFile)
        {
            while (true)
            {
                PingMethodOnly(configurationFile);
                Thread.Sleep(1000);
            }
        }
        public void TCPing(ConfigurationFile configurationFile)
        {
            while (true)
            {
                TCPingMethodOnly(configurationFile);
                Thread.Sleep(1000);
            }
        }
        public void PingMethodOnly(ConfigurationFile config)
        {
            try

            {
                // your code here
                Ping PingSender = new Ping();
                long TotalTime = 0;
                Log.Logger = new LoggerConfiguration().WriteTo.File("logs/myapp.txt").CreateLogger();
                for (int i = 0; i < config.ping.retry; i++)
                {
                    PingReply reply = PingSender.Send(config.ping.IPAddress, config.ping.timeOut);
                    if (reply.Status == IPStatus.Success)
                        TotalTime += reply.RoundtripTime;
                    Log.Information(reply.Status.ToString());
                }
                TotalTime = (TotalTime / config.ping.retry);
                // log stats

            }
            catch (Exception Ex)
            {   //log
                
                Console.WriteLine(Ex.Message);
                Log.Error(Ex.Message);
            }
        }
        public void TCPingMethodOnly(ConfigurationFile config)
        {
            try
            {
                Log.Logger = new LoggerConfiguration().WriteTo.File("logs/myapp.txt").CreateLogger();
                for (int i = 0; i < config.tCPing.retry; i++)
                {
                    var sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    sock.Blocking = true;
                    sock.Connect(config.tCPing.IPAddress, config.tCPing.port);
                    if (sock.Connected) Log.Information($"TCPing {config.tCPing.IPAddress}:{config.tCPing.port} is successful");
                    sock.Close();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }
    }
}