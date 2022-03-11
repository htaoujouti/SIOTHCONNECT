using IntegrationObjects.Common.Library;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIOTHCONNECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PingChB_CheckedChanged(object sender, EventArgs e)
        {
            PingGB.Enabled = PingChB.Checked;
            #region HamzaCode
            //if (PingChB.Checked)
            //{
            //    PingGB.Enabled = true;
            //}
            //else { PingGB.Enabled = false; }
            #endregion
            SaveBtn.Enabled = (PingChB.Checked || TCPingCheckBox.Checked);
            #region HamzaCode
            //if ((!TCPingCheckBox.Checked) && (!PingChB.Checked))
            //{
            //    SaveBtn.Enabled = false;
            //}
            //else { SaveBtn.Enabled = true; }
            #endregion
        }

        private void TCPingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TCPingGB.Enabled = TCPingCheckBox.Checked;
            #region HamzaCode
            //if (TCPingCheckBox.Checked)
            //{
            //    TCPingGB.Enabled = true;
            //}
            //else { TCPingGB.Enabled = false; }
            #endregion
            SaveBtn.Enabled = (PingChB.Checked || TCPingCheckBox.Checked);
            #region HamzaCode
            //if ((!TCPingCheckBox.Checked) && (!PingChB.Checked))
            //{
            //    SaveBtn.Enabled = false;
            //}
            //else { SaveBtn.Enabled = true; }
            #endregion
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Ping ping = new Ping()
                {
                    IPAddress = IpPing.Text,
                    retry = (int)retryPing.Value,
                    timeOut = (int)timeOutPing.Value
                };
                TCPing tCPing = new TCPing()
                {   
                    IPAddress = tcpingIp.Text,                    
                    port = (int)port.Value,
                    retry = (int)tcpingRetry.Value,
                    timeOut = (int)tcpingTimeOut.Value
                };
                ConfigurationFile contrat = new ConfigurationFile()
                {
                    IsPingEnabled = PingChB.Checked,
                    IsTCPingEnabled = TCPingCheckBox.Checked,
                    ping = ping,
                    tCPing = tCPing
                };
                File.WriteAllText(@"C:\Users\htaoujouti\Desktop\contrat.json", JsonConvert.SerializeObject(contrat));
                #region HamzaCode
                //if ((PingChB.Checked) && (TCPingCheckBox.Checked))
                //{
                //    TCPing tCPing = new TCPing(tcpingIp.Text, (int)tcpingTimeOut.Value, (int)tcpingRetry.Value, (int)port.Value);
                //    Ping ping = new Ping(IpPing.Text, (int)timeOutPing.Value, (int)retryPing.Value);
                //    Contrat contrat = new Contrat(ping, tCPing);
                //    File.WriteAllText(@"C:\Users\htaoujouti\Desktop\contrat.json", JsonConvert.SerializeObject(contrat));
                //    return;
                //}
                //if (TCPingCheckBox.Checked)
                //{
                //    TCPing tCPing = new TCPing(tcpingIp.Text, (int)tcpingTimeOut.Value, (int)tcpingRetry.Value, (int)port.Value);
                //    Contrat contrat = new Contrat(tCPing);
                //    File.WriteAllText(@"C:\Users\htaoujouti\Desktop\contrat.json", JsonConvert.SerializeObject(contrat));
                //    return;
                //}
                //if (PingChB.Checked)
                //{
                //    Ping ping = new Ping(IpPing.Text, (int)timeOutPing.Value, (int)retryPing.Value);
                //    Contrat contrat = new Contrat(ping);
                //    File.WriteAllText(@"C:\Users\htaoujouti\Desktop\contrat.json", JsonConvert.SerializeObject(contrat));
                //}

                #endregion

            }
            catch (Exception Ex)
            {
                MessageBox.Show(this, $"Error occurred while saving config {Ex.Message}" , "Save Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
