using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace baiTap001
{
    public partial class frmCouter : Form
    {
        int timeData;
        public frmCouter()
        {
            InitializeComponent(); 
        }

        private void rad10s_CheckedChanged(object sender, EventArgs e)
        {
            lblTime.Text = "10";
            timeData = 10;
        }

        private void rad30s_CheckedChanged(object sender, EventArgs e)
        {
            lblTime.Text = "30";
            timeData = 30;
        }

        private void rad45s_CheckedChanged(object sender, EventArgs e)
        {
            lblTime.Text = "45";
            timeData = 45;
        }

        private void rad60s_CheckedChanged(object sender, EventArgs e)
        {
            lblTime.Text = "60";
            timeData = 60;
        }   

        private void rad90s_CheckedChanged(object sender, EventArgs e)
        {
            lblTime.Text = "90";
            timeData = 90;
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            timTimeCout.Enabled = true;
        }

        private void timTimeCout_Tick(object sender, EventArgs e)
        {
            lblTime.Text = timeData.ToString();
            btnBegin.Enabled = false;
            timeData--;
            if(timeData<0)
            {
                timeData = 0;
                timTimeCout.Enabled = false;
                btnBegin.Enabled = true;
            }
        }
    }
}
