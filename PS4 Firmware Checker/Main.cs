using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace PS4_Firmware_Checker
{
    public partial class Main : Form
    {
        public static bool Isconnected = true;

        public Main()
        {
            InitializeComponent();
        }

        private void linkLabel1_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/pearlxcore");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.ShowDialog();

            if (Form1.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                Ping myPing = new Ping();
                string host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                if (reply.Status == IPStatus.Success)
                {
                    return true;
                }
                else if (reply.Status == IPStatus.TimedOut)
                {
                    return Isconnected;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
