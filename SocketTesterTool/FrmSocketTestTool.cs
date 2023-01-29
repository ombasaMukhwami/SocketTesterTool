using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace SocketTesterTool
{
    public partial class FrmSocketTestTool : Form
    {
        private bool isInprogress = false;
        private Socket _clientSocketTcp;// = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
        private Socket _ListenerSocket;
        private Socket _clientSocketUdp;// = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private delegate void Connected();
        public FrmSocketTestTool()
        {
            InitializeComponent();
        }

        private void btnUdp_Click(object sender, EventArgs e)
        {
            //if (this.isInprogress)
            //    return;
            //this.SendViaUdp(this.txtsenddata.Text);
            if (this.isInprogress)
                return;
            btnUdp.Enabled = !isInprogress;
            string stringToPushToNavigate = this.txtsenddata.Text;
            if (this.chkAscii.Checked)
                stringToPushToNavigate = this.txtsenddata.Text.ToHex();
            this.PushDataToNavigate(stringToPushToNavigate, false);
            btnUdp.Enabled = !isInprogress;
        }
        private void SendingData()
        {
            btnTcp.Enabled = !isInprogress;
        }
        private void btnTcp_Click(object sender, EventArgs e)
        {
            if (this.isInprogress)
                return;
            btnTcp.Enabled = !isInprogress;
            string stringToPushToNavigate = this.txtsenddata.Text;
            if (this.chkAscii.Checked)
                stringToPushToNavigate = this.txtsenddata.Text.ToHex();
            this.PushDataToNavigate(stringToPushToNavigate, true);
            btnTcp.Enabled = !isInprogress;
        }

        public void PushDataToNavigate(string stringToPushToNavigate, bool isTcp)
        {
            this.isInprogress = true;
            this.txtStatus.Text = "Sending data to navigate";
            try
            {
                this.writeEventMsg("preparing to send data to navigate" + stringToPushToNavigate);

                string str = stringToPushToNavigate;

                byte[] byteArray = this.hexStringToByteArray(stringToPushToNavigate);
                this.writeEventMsg(string.Format("Send : {0} >", DateTime.Now) + str);
                if (isTcp)
                    _clientSocketTcp.Send(byteArray);
                else
                {
                    if (_clientSocketUdp == null)
                        _clientSocketUdp = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    _clientSocketUdp.Connect(IPAddress.Parse(txtServerIp.Text), int.Parse(txtPort.Text));
                    _clientSocketUdp.Send(byteArray);
                }

                byte[] receivedBuf = new byte[1024];
                int receivedData = 0;
                if (isTcp)
                {
                    _clientSocketTcp.ReceiveTimeout = 1250000;
                    receivedData = _clientSocketTcp.Receive(receivedBuf);
                }
                else
                {
                    receivedData = _clientSocketUdp.ReceiveTimeout = 3000;
                    receivedData = _clientSocketUdp.Receive(receivedBuf);
                }
                if (receivedData > 0)
                {
                    byte[] data = new byte[receivedData];
                    Array.Copy(receivedBuf, data, receivedData);
                    str = BitConverter.ToString(data).Replace("-", "").ToLower();
                    this.writeEventMsg(string.Format("Recived : {0} <", DateTime.Now) + str);
                }

                this.isInprogress = false;

            }
            catch (Exception ex)
            {
                this.writeEventMsg("ERROR Sending data " + ex.Message);
                this.isInprogress = false;
                if (_clientSocketTcp == null || (isTcp && !_clientSocketTcp.Connected))
                {
                    DisconnectSocket();
                }
            }

            if (!isTcp)
                _clientSocketUdp = null;
        }


        public void PushDataToNavigate(string stringToPushToNavigate)
        {
            this.isInprogress = true;
            this.txtStatus.Text = "Sending data to navigate";
            try
            {
                this.writeEventMsg("preparing to send data to navigate" + stringToPushToNavigate);
                int port = Convert.ToInt32(this.txtPort.Text);
                string server = this.txtServerIp.Text;
                string str = stringToPushToNavigate;
                TcpClient tcpClient = new TcpClient(server, port);
                NetworkStream stream = tcpClient.GetStream();
                stream.ReadTimeout = 30000;
                stream.WriteTimeout = 30000;
                tcpClient.Client.ReceiveTimeout = 30000;
                tcpClient.Client.SendTimeout = 30000;
                byte[] byteArray = this.hexStringToByteArray(stringToPushToNavigate);
                this.writeEventMsg(string.Format("Send : {0} >", DateTime.Now) + str);
                stream.Write(byteArray, 0, byteArray.Length);
                this.writeEventMsg(string.Format("Recived : {0} <", DateTime.Now) + str);

                this.isInprogress = false;
                stream.Close();
                tcpClient.Close();
            }
            catch (Exception ex)
            {
                this.writeEventMsg("ERROR Sending data " + ex.Message);
                this.isInprogress = false;
            }
        }

        public void writeEventMsg(string data)
        {
            string str = ">" + data;
            TextBox txtstatus = this.txtStatus;
            txtstatus.Text = txtstatus.Text + str + Environment.NewLine;
            this.txtStatus.Refresh();
            this.txtStatus.SelectionStart = this.txtStatus.Text.Length;
            this.txtStatus.ScrollToCaret();
        }

        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder stringBuilder = new StringBuilder(ba.Length * 2);
            foreach (byte num in ba)
                stringBuilder.AppendFormat("{0:x2}", (object)num);
            return stringBuilder.ToString();
        }

        private byte[] hexStringToByteArray(string hexinput)
        {
            if (hexinput == string.Empty)
                return (byte[])null;
            if (hexinput.Length % 2 == 1)
                hexinput = "0" + hexinput;
            int length = hexinput.Length / 2;
            byte[] numArray = new byte[length];
            for (int index = 0; index < length; ++index)
                numArray[index] = Convert.ToByte(hexinput.Substring(index * 2, 2), 16);
            return numArray;
        }

        private void SendViaUdp(string stringToPushToNavigate)
        {
            try
            {
                if (this.chkAscii.Checked)
                    stringToPushToNavigate = this.txtsenddata.Text.ToHex();
                byte[] byteArray = this.hexStringToByteArray(stringToPushToNavigate);
                int int32 = Convert.ToInt32(this.txtPort.Text);
                string text = this.txtServerIp.Text;
                UdpClient udpClient = new UdpClient();
                udpClient.Connect(text, int32);
                Encoding.ASCII.GetBytes(stringToPushToNavigate);
                udpClient.Send(byteArray, byteArray.Length);
                this.writeEventMsg("Sending : " + (object)byteArray);
            }
            catch (Exception ex)
            {
                this.txtStatus.AppendText(ex.StackTrace);
            }
            this.isInprogress = false;
        }

        private void btnConverToHex_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPort.Text))
                errorProvider1.SetError(txtPort, "*");
            if (string.IsNullOrWhiteSpace(txtServerIp.Text))
                errorProvider1.SetError(txtServerIp, "*");
        }

        private void DisconnectSocket()
        {
            btnConnectSocket.Text = "Connect";
            btnConnectSocket.ForeColor = Color.Black;
            _clientSocketTcp = null;
            btnTcp.Enabled = false;
        }
        private void ConnectSocket()
        {
            btnConnectSocket.Enabled = false;
            btnTcp.Enabled = true;
            btnConnectSocket.Text = "Disconnect";
            btnConnectSocket.ForeColor = Color.Green;
            btnConnectSocket.Enabled = true;
        }
        private void btnConnectSocket_Click(object sender, EventArgs e)
        {
            if (_clientSocketTcp == null)
                _clientSocketTcp = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            if (_clientSocketTcp.Connected)
            {
                if (MessageBox.Show("Do you want to Disconnect", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Connected connected = new Connected(DisconnectSocket);
                    this.Invoke(connected);
                }
            }
            else
            {
                try
                {
                    _clientSocketTcp.Connect(new IPEndPoint(IPAddress.Parse(txtServerIp.Text.Trim()), int.Parse(txtPort.Text.Trim())));
                    Connected connected = new Connected(ConnectSocket);
                    this.Invoke(connected);
                }
                catch (SocketException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }//endof 

        private void ConnectCallBack(IAsyncResult ar)
        {
            try
            {
                _clientSocketTcp.EndConnect(ar);
                Connected connected = new Connected(ConnectSocket);
                this.Invoke(connected);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connected connected = new Connected(DisconnectSocket);
                this.Invoke(connected);
            }
        }

        private void FrmSocketTestTool_Load(object sender, EventArgs e)
        {
            Text = "Socket Test Tool";
        }
    }
}
