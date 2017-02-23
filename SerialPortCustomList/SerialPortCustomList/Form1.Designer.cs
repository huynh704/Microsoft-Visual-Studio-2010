namespace SerialPortCustomList
{
    partial class frnSerial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnSerial));
            this.cboComport = new System.Windows.Forms.ComboBox();
            this.cboBaurate = new System.Windows.Forms.ComboBox();
            this.btnConect = new System.Windows.Forms.Button();
            this.txtRecive = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // cboComport
            // 
            this.cboComport.AutoCompleteCustomSource.AddRange(new string[] {
            "Com1",
            "Com2",
            "Com3",
            "Com4",
            "Com5",
            "Com6",
            "Com7"});
            this.cboComport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComport.FormattingEnabled = true;
            this.cboComport.Items.AddRange(new object[] {
            "Com1",
            "Com2",
            "Com3",
            "Com4"});
            this.cboComport.Location = new System.Drawing.Point(12, 10);
            this.cboComport.Name = "cboComport";
            this.cboComport.Size = new System.Drawing.Size(93, 27);
            this.cboComport.TabIndex = 1;
            this.cboComport.SelectedIndexChanged += new System.EventHandler(this.cboComport_SelectedIndexChanged);
            // 
            // cboBaurate
            // 
            this.cboBaurate.AutoCompleteCustomSource.AddRange(new string[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "115200"});
            this.cboBaurate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBaurate.FormattingEnabled = true;
            this.cboBaurate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cboBaurate.Location = new System.Drawing.Point(125, 10);
            this.cboBaurate.Name = "cboBaurate";
            this.cboBaurate.Size = new System.Drawing.Size(73, 27);
            this.cboBaurate.TabIndex = 3;
            this.cboBaurate.SelectedIndexChanged += new System.EventHandler(this.cboBaurate_SelectedIndexChanged);
            // 
            // btnConect
            // 
            this.btnConect.Location = new System.Drawing.Point(204, 9);
            this.btnConect.Name = "btnConect";
            this.btnConect.Size = new System.Drawing.Size(104, 27);
            this.btnConect.TabIndex = 4;
            this.btnConect.Text = "Connect";
            this.btnConect.UseVisualStyleBackColor = true;
            this.btnConect.Click += new System.EventHandler(this.btnConect_Click);
            // 
            // txtRecive
            // 
            this.txtRecive.Location = new System.Drawing.Point(12, 43);
            this.txtRecive.Multiline = true;
            this.txtRecive.Name = "txtRecive";
            this.txtRecive.Size = new System.Drawing.Size(402, 285);
            this.txtRecive.TabIndex = 5;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(12, 335);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(311, 26);
            this.txtSend.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(339, 334);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 27);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(314, 9);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(69, 27);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.dataRecive);
            // 
            // frnSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 381);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtRecive);
            this.Controls.Add(this.btnConect);
            this.Controls.Add(this.cboBaurate);
            this.Controls.Add(this.cboComport);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frnSerial";
            this.Text = "Serial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBaurate;
        private System.Windows.Forms.Button btnConect;
        private System.Windows.Forms.TextBox txtRecive;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cboComport;
        private System.Windows.Forms.Button btnAbout;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

