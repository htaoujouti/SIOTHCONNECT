using IntegrationObjects.Common.Library;
using IntegrationObjects.Core.Library;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegrationObjects.Red.Service
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // Start you code
            #region load Config 
            // if config not valid exit            
            try
            {
                ConfigurationFile contrat =  JsonConvert.DeserializeObject<ConfigurationFile>(File.ReadAllText(@"C:\Users\htaoujouti\Desktop\contrat.json"));
                RedJob red = new RedJob(contrat);
               // red.PingMethodOnly();
            }
            catch (Exception Ex)
            {
                //log write error while loading
                Process.GetCurrentProcess().Kill();
            }

            #endregion

        }

        protected override void OnStop()
        {
            // Realease all ressources
            //log
        }
    }
}
