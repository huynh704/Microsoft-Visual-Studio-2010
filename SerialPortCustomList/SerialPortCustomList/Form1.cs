using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerialPortCustomList
{
    public partial class frnSerial : Form
    {
        delegate void dataSetTextCallBack(string text);
        public frnSerial()
        {
            InitializeComponent();
            btnSend.Enabled = false;
            txtSend.Enabled = false;
            cboBaurate.Enabled = true;
            cboComport.Enabled = true;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright by BM", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConect_Click(object sender, EventArgs e)
        {
            if (btnConect.Text == "Connect")
            {
                btnConect.Text = "Disconnect";
                serialPort1.Open();
                txtSend.Enabled = true;
                btnSend.Enabled = true;
                cboBaurate.Enabled = false;
                cboComport.Enabled = false;

            }
            else if (btnConect.Text == "Disconnect")
            {
                btnConect.Text = "Connect";
                serialPort1.Close();
                txtSend.Enabled = false;
                btnSend.Enabled = false;
                cboBaurate.Enabled = true;
                cboComport.Enabled = true;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(txtSend.Text);
        }

        private void cboComport_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = cboComport.Text;
        }

        private void cboBaurate_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.BaudRate = int.Parse(cboBaurate.Text);
        }

        private void dataRecive(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string dataRead;
            dataRead = serialPort1.ReadExisting();
            dataSetText(dataRead);
        }
        private void dataSetText(string text)
        {
            if (this.txtRecive.InvokeRequired)
            {
                dataSetTextCallBack data = new dataSetTextCallBack(dataSetText);
                this.Invoke(data, new object[] { text });
            }
            else this.txtRecive.Text += text;
        }
    }
}
