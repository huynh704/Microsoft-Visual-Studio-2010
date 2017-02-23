namespace Termite
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDataRevice = new System.Windows.Forms.TextBox();
            this.txtDataTranmit = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtConnect = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(562, 12);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(59, 23);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(627, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(55, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(688, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(53, 23);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(747, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtDataRevice
            // 
            this.txtDataRevice.Location = new System.Drawing.Point(12, 41);
            this.txtDataRevice.Multiline = true;
            this.txtDataRevice.Name = "txtDataRevice";
            this.txtDataRevice.Size = new System.Drawing.Size(790, 313);
            this.txtDataRevice.TabIndex = 5;
            this.txtDataRevice.TextChanged += new System.EventHandler(this.txtDataRevice_TextChanged);
            // 
            // txtDataTranmit
            // 
            this.txtDataTranmit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataTranmit.Location = new System.Drawing.Point(12, 360);
            this.txtDataTranmit.Name = "txtDataTranmit";
            this.txtDataTranmit.Size = new System.Drawing.Size(729, 22);
            this.txtDataTranmit.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(747, 360);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(55, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // txtConnect
            // 
            this.txtConnect.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtConnect.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtConnect.Location = new System.Drawing.Point(12, 14);
            this.txtConnect.Name = "txtConnect";
            this.txtConnect.Size = new System.Drawing.Size(544, 21);
            this.txtConnect.TabIndex = 8;
            this.txtConnect.Text = "Connect";
            this.txtConnect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 392);
            this.Controls.Add(this.txtConnect);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtDataTranmit);
            this.Controls.Add(this.txtDataRevice);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSetting);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Termite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtDataRevice;
        private System.Windows.Forms.TextBox txtDataTranmit;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtConnect;
    }
}

