using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GiaoTiepSerial
{
    public partial class frmSerial : Form
    {
        public frmSerial()
        {
            InitializeComponent();
            btnDisconnect.Enabled = false;
            btnConnect.Enabled = true;
            btnSend.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                btnSend.Enabled = true;
                txtDataRx.Text = "Connected";
            }
            catch
            {
                MessageBox.Show("Cổng Com chưa được mở hoặc đang kết nối", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            btnDisconnect.Enabled = false;
            btnConnect.Enabled = true;
            btnSend.Enabled = false;
            txtDataRx.Text = "Disconnected";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(txtDataTX.Text);
        }
    }
}
