namespace baiTap001
{
    partial class frmCouter
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
            this.rad10s = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rad30s = new System.Windows.Forms.RadioButton();
            this.rad45s = new System.Windows.Forms.RadioButton();
            this.rad60s = new System.Windows.Forms.RadioButton();
            this.rad90s = new System.Windows.Forms.RadioButton();
            this.btnBegin = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.timTimeCout = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rad10s
            // 
            this.rad10s.AutoSize = true;
            this.rad10s.Location = new System.Drawing.Point(13, 50);
            this.rad10s.Name = "rad10s";
            this.rad10s.Size = new System.Drawing.Size(79, 23);
            this.rad10s.TabIndex = 0;
            this.rad10s.TabStop = true;
            this.rad10s.Text = "đếm 10s";
            this.rad10s.UseVisualStyleBackColor = true;
            this.rad10s.CheckedChanged += new System.EventHandler(this.rad10s_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn thời gian đếm ngược";
            // 
            // rad30s
            // 
            this.rad30s.AutoSize = true;
            this.rad30s.Location = new System.Drawing.Point(12, 79);
            this.rad30s.Name = "rad30s";
            this.rad30s.Size = new System.Drawing.Size(79, 23);
            this.rad30s.TabIndex = 2;
            this.rad30s.TabStop = true;
            this.rad30s.Text = "đếm 30s";
            this.rad30s.UseVisualStyleBackColor = true;
            this.rad30s.CheckedChanged += new System.EventHandler(this.rad30s_CheckedChanged);
            // 
            // rad45s
            // 
            this.rad45s.AutoSize = true;
            this.rad45s.Location = new System.Drawing.Point(13, 108);
            this.rad45s.Name = "rad45s";
            this.rad45s.Size = new System.Drawing.Size(79, 23);
            this.rad45s.TabIndex = 3;
            this.rad45s.TabStop = true;
            this.rad45s.Text = "đếm 45s";
            this.rad45s.UseVisualStyleBackColor = true;
            this.rad45s.CheckedChanged += new System.EventHandler(this.rad45s_CheckedChanged);
            // 
            // rad60s
            // 
            this.rad60s.AutoSize = true;
            this.rad60s.Location = new System.Drawing.Point(13, 137);
            this.rad60s.Name = "rad60s";
            this.rad60s.Size = new System.Drawing.Size(79, 23);
            this.rad60s.TabIndex = 4;
            this.rad60s.TabStop = true;
            this.rad60s.Text = "đếm 60s";
            this.rad60s.UseVisualStyleBackColor = true;
            this.rad60s.CheckedChanged += new System.EventHandler(this.rad60s_CheckedChanged);
            // 
            // rad90s
            // 
            this.rad90s.AutoSize = true;
            this.rad90s.Location = new System.Drawing.Point(13, 166);
            this.rad90s.Name = "rad90s";
            this.rad90s.Size = new System.Drawing.Size(79, 23);
            this.rad90s.TabIndex = 5;
            this.rad90s.TabStop = true;
            this.rad90s.Text = "đếm 90s";
            this.rad90s.UseVisualStyleBackColor = true;
            this.rad90s.CheckedChanged += new System.EventHandler(this.rad90s_CheckedChanged);
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(125, 200);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(137, 33);
            this.btnBegin.TabIndex = 6;
            this.btnBegin.Text = "Bắt đầu";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            this.btnBegin.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnBegin_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(227, 67);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(96, 73);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "00";
            // 
            // timTimeCout
            // 
            this.timTimeCout.Interval = 1000;
            this.timTimeCout.Tick += new System.EventHandler(this.timTimeCout_Tick);
            // 
            // frmCouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 381);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.rad90s);
            this.Controls.Add(this.rad60s);
            this.Controls.Add(this.rad45s);
            this.Controls.Add(this.rad30s);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rad10s);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCouter";
            this.Text = "Couter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rad10s;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rad30s;
        private System.Windows.Forms.RadioButton rad45s;
        private System.Windows.Forms.RadioButton rad60s;
        private System.Windows.Forms.RadioButton rad90s;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timTimeCout;
    }
}

