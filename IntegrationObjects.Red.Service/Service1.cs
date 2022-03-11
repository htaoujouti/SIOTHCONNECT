using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
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

            }catch (Exception Ex)
            {
                return ;
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
