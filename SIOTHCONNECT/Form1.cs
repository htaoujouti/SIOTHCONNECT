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
            //if (PingChB.Checked)
            //{
            //    PingGB.Enabled = true;
            //}
            //else { PingGB.Enabled = false; }

            if ((!TCPingCheckBox.Checked) && (!PingChB.Checked))
            {
                SaveBtn.Enabled = false;
            }
            else { SaveBtn.Enabled = true; }
        }

        private void TCPingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TCPingGB.Enabled = TCPingCheckBox.Checked;
            //if (TCPingCheckBox.Checked)
            //{
            //    TCPingGB.Enabled = true;
            //}
            //else { TCPingGB.Enabled = false; }
            if ((!TCPingCheckBox.Checked) && (!PingChB.Checked))
            {
                SaveBtn.Enabled = false;
            }
            else { SaveBtn.Enabled = true; }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Ping ping1 = new Ping()
                {
                    IPAddress = IpPing.Text,
                    retry = ,
                };
                TCPing tCPing1 = new TCPing()
                {
                    port = ,
                    
                };
                Contrat contrat1 = new Contrat()
                {
                    IsPingEnabled = PingChB.Checked,
                    IsTCPingEnabled = TCPingCheckBox.Checked,
                    ping = ping1,
                    tCPing = tCPing1
                };
                File.WriteAllText("", JsonConvert.SerializeObject(contrat1));
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
