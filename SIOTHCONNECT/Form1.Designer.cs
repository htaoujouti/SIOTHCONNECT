namespace SIOTHCONNECT
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
            this.PingChB = new System.Windows.Forms.CheckBox();
            this.TCPingCheckBox = new System.Windows.Forms.CheckBox();
            this.tcpingIp = new System.Windows.Forms.TextBox();
            this.IpPing = new System.Windows.Forms.TextBox();
            this.retryPing = new System.Windows.Forms.NumericUpDown();
            this.timeOutPing = new System.Windows.Forms.NumericUpDown();
            this.port = new System.Windows.Forms.NumericUpDown();
            this.PingGB = new System.Windows.Forms.GroupBox();
            this.pingRetry = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TCPingGB = new System.Windows.Forms.GroupBox();
            this.tcpingRetry = new System.Windows.Forms.NumericUpDown();
            this.tcpingTimeOut = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.affichage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.retryPing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOutPing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.port)).BeginInit();
            this.PingGB.SuspendLayout();
            this.TCPingGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcpingRetry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcpingTimeOut)).BeginInit();
            this.SuspendLayout();
            // 
            // PingChB
            // 
            this.PingChB.AutoSize = true;
            this.PingChB.Location = new System.Drawing.Point(12, 46);
            this.PingChB.Name = "PingChB";
            this.PingChB.Size = new System.Drawing.Size(47, 17);
            this.PingChB.TabIndex = 0;
            this.PingChB.Text = "Ping";
            this.PingChB.UseVisualStyleBackColor = true;
            this.PingChB.CheckedChanged += new System.EventHandler(this.PingChB_CheckedChanged);
            // 
            // TCPingCheckBox
            // 
            this.TCPingCheckBox.AutoSize = true;
            this.TCPingCheckBox.Location = new System.Drawing.Point(12, 138);
            this.TCPingCheckBox.Name = "TCPingCheckBox";
            this.TCPingCheckBox.Size = new System.Drawing.Size(61, 17);
            this.TCPingCheckBox.TabIndex = 1;
            this.TCPingCheckBox.Text = "TCPing";
            this.TCPingCheckBox.UseVisualStyleBackColor = true;
            this.TCPingCheckBox.CheckedChanged += new System.EventHandler(this.TCPingCheckBox_CheckedChanged);
            // 
            // tcpingIp
            // 
            this.tcpingIp.Location = new System.Drawing.Point(69, 44);
            this.tcpingIp.Name = "tcpingIp";
            this.tcpingIp.Size = new System.Drawing.Size(117, 20);
            this.tcpingIp.TabIndex = 2;
            // 
            // IpPing
            // 
            this.IpPing.Location = new System.Drawing.Point(69, 24);
            this.IpPing.Name = "IpPing";
            this.IpPing.Size = new System.Drawing.Size(117, 20);
            this.IpPing.TabIndex = 3;
            this.IpPing.Tag = "";
            // 
            // retryPing
            // 
            this.retryPing.Location = new System.Drawing.Point(346, 24);
            this.retryPing.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.retryPing.Name = "retryPing";
            this.retryPing.Size = new System.Drawing.Size(43, 20);
            this.retryPing.TabIndex = 5;
            this.retryPing.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timeOutPing
            // 
            this.timeOutPing.Location = new System.Drawing.Point(243, 24);
            this.timeOutPing.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.timeOutPing.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeOutPing.Name = "timeOutPing";
            this.timeOutPing.Size = new System.Drawing.Size(44, 20);
            this.timeOutPing.TabIndex = 7;
            this.timeOutPing.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(243, 44);
            this.port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(44, 20);
            this.port.TabIndex = 8;
            this.port.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PingGB
            // 
            this.PingGB.Controls.Add(this.pingRetry);
            this.PingGB.Controls.Add(this.label5);
            this.PingGB.Controls.Add(this.timeOutPing);
            this.PingGB.Controls.Add(this.retryPing);
            this.PingGB.Controls.Add(this.label1);
            this.PingGB.Controls.Add(this.IpPing);
            this.PingGB.Enabled = false;
            this.PingGB.Location = new System.Drawing.Point(79, 46);
            this.PingGB.Name = "PingGB";
            this.PingGB.Size = new System.Drawing.Size(414, 67);
            this.PingGB.TabIndex = 9;
            this.PingGB.TabStop = false;
            this.PingGB.Text = "Ping";
            // 
            // pingRetry
            // 
            this.pingRetry.AutoSize = true;
            this.pingRetry.Location = new System.Drawing.Point(293, 27);
            this.pingRetry.Name = "pingRetry";
            this.pingRetry.Size = new System.Drawing.Size(47, 13);
            this.pingRetry.TabIndex = 5;
            this.pingRetry.Text = "Retry N°";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Timeout";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ip Address";
            // 
            // TCPingGB
            // 
            this.TCPingGB.Controls.Add(this.tcpingRetry);
            this.TCPingGB.Controls.Add(this.tcpingTimeOut);
            this.TCPingGB.Controls.Add(this.label7);
            this.TCPingGB.Controls.Add(this.label4);
            this.TCPingGB.Controls.Add(this.label3);
            this.TCPingGB.Controls.Add(this.label2);
            this.TCPingGB.Controls.Add(this.tcpingIp);
            this.TCPingGB.Controls.Add(this.port);
            this.TCPingGB.Enabled = false;
            this.TCPingGB.Location = new System.Drawing.Point(79, 138);
            this.TCPingGB.Name = "TCPingGB";
            this.TCPingGB.Size = new System.Drawing.Size(489, 98);
            this.TCPingGB.TabIndex = 10;
            this.TCPingGB.TabStop = false;
            this.TCPingGB.Text = "TCPing";
            // 
            // tcpingRetry
            // 
            this.tcpingRetry.Location = new System.Drawing.Point(440, 45);
            this.tcpingRetry.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tcpingRetry.Name = "tcpingRetry";
            this.tcpingRetry.Size = new System.Drawing.Size(43, 20);
            this.tcpingRetry.TabIndex = 8;
            this.tcpingRetry.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tcpingTimeOut
            // 
            this.tcpingTimeOut.Location = new System.Drawing.Point(343, 45);
            this.tcpingTimeOut.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tcpingTimeOut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tcpingTimeOut.Name = "tcpingTimeOut";
            this.tcpingTimeOut.Size = new System.Drawing.Size(44, 20);
            this.tcpingTimeOut.TabIndex = 8;
            this.tcpingTimeOut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Retry N°";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Timeout";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ip Address";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Enabled = false;
            this.SaveBtn.Location = new System.Drawing.Point(274, 257);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 11;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // affichage
            // 
            this.affichage.AutoSize = true;
            this.affichage.Location = new System.Drawing.Point(387, 257);
            this.affichage.Name = "affichage";
            this.affichage.Size = new System.Drawing.Size(0, 13);
            this.affichage.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 311);
            this.Controls.Add(this.affichage);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.PingGB);
            this.Controls.Add(this.TCPingCheckBox);
            this.Controls.Add(this.PingChB);
            this.Controls.Add(this.TCPingGB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.retryPing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOutPing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.port)).EndInit();
            this.PingGB.ResumeLayout(false);
            this.PingGB.PerformLayout();
            this.TCPingGB.ResumeLayout(false);
            this.TCPingGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcpingRetry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcpingTimeOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox PingChB;
        private System.Windows.Forms.CheckBox TCPingCheckBox;
        private System.Windows.Forms.TextBox tcpingIp;
        private System.Windows.Forms.TextBox IpPing;
        private System.Windows.Forms.NumericUpDown retryPing;
        private System.Windows.Forms.NumericUpDown timeOutPing;
        private System.Windows.Forms.NumericUpDown port;
        private System.Windows.Forms.GroupBox PingGB;
        private System.Windows.Forms.GroupBox TCPingGB;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label pingRetry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label affichage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tcpingRetry;
        private System.Windows.Forms.NumericUpDown tcpingTimeOut;
    }
}

