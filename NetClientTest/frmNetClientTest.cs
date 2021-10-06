using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetClientTest
{
    public partial class frmNetClientTest : Form
    {
        public frmNetClientTest()
        {
            InitializeComponent();
        }
        Socket sock = null;
        
        private void btnConnect_Click(object sender, EventArgs e)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(tbConnectIP.Text, int.Parse(tbClientPort.Text));
            tbClient.Text += "Connection OK";
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            sock.Close();
            tbClient.Text += "Connection Closed";
        }

        private void pmnSendText_Click(object sender, EventArgs e)
        {
            if(sock != null)
            {
                string str;
                if (tbClient.SelectedText == "") str = tbClient.Text;
                else str = tbClient.SelectedText;
                sock.Send(Encoding.Default.GetBytes(str)); //byte[]로 변환 필요
            }
        }
    }
}
