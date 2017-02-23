using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Termite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String TxDataInput;
        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Termite\n\nTermite is simple RS232 communication tool\nwith a message or chat program use-interface\nDesigned by Huynh704\nwww.facebook.com/huynh704", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtDataRevice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
