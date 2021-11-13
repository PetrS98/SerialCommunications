using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialCommunications
{
    public partial class MainForm : Form
    {
        public SerialPort serialPort = new SerialPort();

        public MainForm()
        {
            InitializeComponent();

            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            btnCloseComm.Enabled = false;
            btnSendMessage.Enabled = false;

            serialPort.DataReceived += ReceiveMessage;
        }

        private void btnOpenComm_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen) return;
            
            try
            {
                serialPort.PortName = tbPortName.Text;
                serialPort.Open();

                btnOpenComm.Enabled = false;
                btnCloseComm.Enabled = true;
                tbPortName.Enabled = false;
                btnSendMessage.Enabled = true;
            }
            catch(Exception ex)
            {
                tbDiagnostic.ForeColor = Color.Red;
                tbDiagnostic.Text = ex.ToString();
            }  
        }

        private void btnCloseComm_Click(object sender, EventArgs e)
        {
            serialPort.Close();

            btnOpenComm.Enabled = true;
            btnCloseComm.Enabled = false;
            tbPortName.Enabled = true;
            btnSendMessage.Enabled = false;
        }

        private void btnRecMessClear_Click(object sender, EventArgs e)
        {
            tbReceiveMessage.Text = "";
        }

        private void btDiagnosticClear_Click(object sender, EventArgs e)
        {
            tbDiagnostic.Text = "";
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.WriteLine(tbSendMessage.Text);
            }
            catch(Exception ex)
            {
                tbDiagnostic.Text = ex.ToString();
            }
            
        }

        private void ReceiveMessage(object sender, EventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            tbReceiveMessage.Invoke(new Action(() =>
            {
                tbReceiveMessage.Text += sp.ReadExisting() + Environment.NewLine;
            }));
        }
    }
}
