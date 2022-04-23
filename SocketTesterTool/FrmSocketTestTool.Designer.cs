namespace SocketTesterTool
{
    partial class FrmSocketTestTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSocketTestTool));
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerIp = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsenddata = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAscii = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConverToHex = new System.Windows.Forms.Button();
            this.btnUdp = new System.Windows.Forms.Button();
            this.btnTcp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnConnectSocket = new System.Windows.Forms.Button();
            this.chkReply = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP:";
            // 
            // txtServerIp
            // 
            this.errorProvider1.SetError(this.txtServerIp, "*");
            this.txtServerIp.Location = new System.Drawing.Point(109, 11);
            this.txtServerIp.Name = "txtServerIp";
            this.txtServerIp.Size = new System.Drawing.Size(161, 21);
            this.txtServerIp.TabIndex = 1;
            this.txtServerIp.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            this.errorProvider1.SetError(this.txtPort, "*");
            this.txtPort.Location = new System.Drawing.Point(109, 35);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(161, 21);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "7015";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.Blue;
            this.txtStatus.Location = new System.Drawing.Point(109, 60);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(699, 98);
            this.txtStatus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status:";
            // 
            // txtsenddata
            // 
            this.errorProvider1.SetError(this.txtsenddata, "*");
            this.txtsenddata.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenddata.ForeColor = System.Drawing.Color.Red;
            this.txtsenddata.Location = new System.Drawing.Point(109, 261);
            this.txtsenddata.Multiline = true;
            this.txtsenddata.Name = "txtsenddata";
            this.txtsenddata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtsenddata.Size = new System.Drawing.Size(699, 116);
            this.txtsenddata.TabIndex = 7;
            this.txtsenddata.Text = "58588e004c08686480416907742111201318508012720303bb09c200290090f8067981b07fffa00a2" +
    "90089501618000000160001383932353430323131383432333839313735303800050002004e00440" +
    "d";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Send Data:";
            // 
            // chkAscii
            // 
            this.chkAscii.AutoSize = true;
            this.chkAscii.Location = new System.Drawing.Point(110, 385);
            this.chkAscii.Name = "chkAscii";
            this.chkAscii.Size = new System.Drawing.Size(52, 19);
            this.chkAscii.TabIndex = 8;
            this.chkAscii.Text = "ASCII";
            this.chkAscii.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data Format:";
            // 
            // btnConverToHex
            // 
            this.btnConverToHex.Location = new System.Drawing.Point(109, 446);
            this.btnConverToHex.Name = "btnConverToHex";
            this.btnConverToHex.Size = new System.Drawing.Size(182, 22);
            this.btnConverToHex.TabIndex = 10;
            this.btnConverToHex.Text = "Convert To Hex";
            this.btnConverToHex.UseVisualStyleBackColor = true;
            this.btnConverToHex.Click += new System.EventHandler(this.btnConverToHex_Click);
            // 
            // btnUdp
            // 
            this.btnUdp.Location = new System.Drawing.Point(297, 446);
            this.btnUdp.Name = "btnUdp";
            this.btnUdp.Size = new System.Drawing.Size(182, 22);
            this.btnUdp.TabIndex = 11;
            this.btnUdp.Text = "UDP";
            this.btnUdp.UseVisualStyleBackColor = true;
            this.btnUdp.Click += new System.EventHandler(this.btnUdp_Click);
            // 
            // btnTcp
            // 
            this.btnTcp.Enabled = false;
            this.btnTcp.Location = new System.Drawing.Point(485, 446);
            this.btnTcp.Name = "btnTcp";
            this.btnTcp.Size = new System.Drawing.Size(182, 22);
            this.btnTcp.TabIndex = 12;
            this.btnTcp.Text = "TCP";
            this.btnTcp.UseVisualStyleBackColor = true;
            this.btnTcp.Click += new System.EventHandler(this.btnTcp_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 163);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(699, 42);
            this.textBox1.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnConnectSocket
            // 
            this.btnConnectSocket.Location = new System.Drawing.Point(673, 446);
            this.btnConnectSocket.Name = "btnConnectSocket";
            this.btnConnectSocket.Size = new System.Drawing.Size(135, 22);
            this.btnConnectSocket.TabIndex = 14;
            this.btnConnectSocket.Text = "Connect";
            this.btnConnectSocket.UseVisualStyleBackColor = true;
            this.btnConnectSocket.Click += new System.EventHandler(this.btnConnectSocket_Click);
            // 
            // chkReply
            // 
            this.chkReply.AutoSize = true;
            this.chkReply.Checked = true;
            this.chkReply.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReply.Location = new System.Drawing.Point(110, 410);
            this.chkReply.Name = "chkReply";
            this.chkReply.Size = new System.Drawing.Size(56, 19);
            this.chkReply.TabIndex = 8;
            this.chkReply.Text = "Reply";
            this.chkReply.UseVisualStyleBackColor = true;
            // 
            // FrmSocketTestTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 480);
            this.Controls.Add(this.btnConnectSocket);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTcp);
            this.Controls.Add(this.btnUdp);
            this.Controls.Add(this.btnConverToHex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkReply);
            this.Controls.Add(this.chkAscii);
            this.Controls.Add(this.txtsenddata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerIp);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmSocketTestTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Socket Test Tool";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerIp;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsenddata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkAscii;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConverToHex;
        private System.Windows.Forms.Button btnUdp;
        private System.Windows.Forms.Button btnTcp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnConnectSocket;
        private System.Windows.Forms.CheckBox chkReply;
    }
}

