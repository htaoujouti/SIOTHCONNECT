using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            if (PingChB.Checked)
            {
                PingGB.Enabled = true;
            }
            else { PingGB.Enabled = false; }
            if ((!TCPingCheckBox.Checked) && (!PingChB.Checked))
            {
                SaveBtn.Enabled = false;
            }
            else { SaveBtn.Enabled = true; }
        }

        private void TCPingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TCPingCheckBox.Checked)
            {
                TCPingGB.Enabled = true;
            }
            else { TCPingGB.Enabled = false; }
            if ((!TCPingCheckBox.Checked) && (!PingChB.Checked))
            {
                SaveBtn.Enabled = false;
            }
            else { SaveBtn.Enabled = true; }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
