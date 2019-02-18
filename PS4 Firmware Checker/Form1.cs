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
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Xml.Linq;
using System.Xml;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using System.Diagnostics;





namespace PS4_Firmware_Checker
{
    public partial class Form1 : Form
    {
        static string url;

        public Form1()
        {
            InitializeComponent();
        }

        static void checkFirmware()
        {
            

            
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {
            //checkFirmware();
            if (Main.Isconnected == true)
            { 

                string path = Environment.CurrentDirectory;
                if (!Directory.Exists(path + "\\Temp"))
                {
                    Directory.CreateDirectory(path + "\\Temp");
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile("http://fus01.ps4.update.playstation.net/update/ps4/list/sa/ps4-updatelist.xml", path + "\\Temp\\ps4-updatelist.xml");
                    }
                }

                XDocument xdoc = XDocument.Load(path + @"\\Temp\ps4-updatelist.xml");
                xdoc.Descendants("region").Select(sys => new
                {
                    label = sys.Element("system_pup").Attribute("label"),
                    sdkVersion = sys.Element("system_pup").Attribute("sdk_version"),
                    fwVersion = sys.Element("system_pup").Attribute("version"),

                }).ToList().ForEach(sys =>
                {
                    tbFWLabelSYS.Text = sys.label.ToString().Replace("label=", "").Replace("\"", "");
                    tbSDKVersionSYS.Text = sys.sdkVersion.ToString().Replace("sdk_version=", "").Replace ("\"","");
                    tbVersionSYS.Text = sys.fwVersion.ToString().Replace("version=", "").Replace("\"", "");
                });

                xdoc.Descendants("update_data").Select(misc => new
                {
                    Size = misc.Element("image").Attribute("size"),

                }).ToList().ForEach(misc =>
                {
                    tbSizeSYS.Text = misc.Size.ToString().Replace("size=", "").Replace("\"", "");
                });

                xdoc.Descendants("recovery_pup").Select(misc => new
                {
                    size = misc.Element("image").Attribute("size"),

                }).ToList().ForEach(misc =>
                {
                    tbSizeREC.Text = misc.size.ToString().Replace("size=", "").Replace("\"", "");
                });

                //

                xdoc.Descendants("recovery_pup").Select(misc => new
                {
                    Link = misc.Element("image")

                }).ToList().ForEach(misc =>
                {
                    tbLinkREC.Text = misc.Link.ToString().Replace("<image size=\"", "").Replace("\"", "").Replace("\">","").Replace("?dest=sa</image>", "").Replace(">", "").Replace(tbSizeREC.Text, "");
                });

                xdoc.Descendants("update_data").Select(misc => new
                {
                    Link = misc.Element("image")

                }).ToList().ForEach(misc =>
                {
                    tbLinkSYS.Text = misc.Link.ToString().Replace("<image size=\"", "").Replace("\"", "").Replace("\">", "").Replace("?dest=sa</image>", "").Replace(">", "").Replace(tbSizeSYS.Text, "");
                });

                //

                xdoc.Descendants("recovery_pup").Select(rec => new
                {
                    label = rec.Element("system_pup").Attribute("label"),
                    sdkVersion = rec.Element("system_pup").Attribute("sdk_version"),
                    fwVersion = rec.Element("system_pup").Attribute("version"),

                }).ToList().ForEach(rec =>
                {
                    tbFWLabelREC.Text = rec.label.ToString().Replace("label=", "").Replace("\"", "");
                    tbSDKVersionREC.Text = rec.sdkVersion.ToString().Replace("sdk_version=", "").Replace("\"", "");
                    tbFWVersion.Text = rec.fwVersion.ToString().Replace("version=", "").Replace("\"", "");
                });


            }
            else
            {
                MessageBox.Show("No internet network detected. Please check your internet connection.", "Error");

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "Southeast Asia")
            {
                url = tbLinkREC.Text + "?dest=sa";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox2.SelectedItem == "North America")
            {
                url = tbLinkREC.Text + "?dest=na";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox2.SelectedItem == "United Kingdom")
            {
                url = tbLinkREC.Text + "?dest=uk";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox2.SelectedItem == "Australia")
            {
                url = tbLinkREC.Text + "?dest=au";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox2.SelectedItem == "Brazil")
            {
                url = tbLinkREC.Text + "?dest=br";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox2.SelectedItem == "China")
            {
                url = tbLinkREC.Text + "?dest=cn";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox2.SelectedItem == "European Union")
            {
                url = tbLinkREC.Text + "?dest=eu";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox2.SelectedItem == "Latin/Central America")
            {
                url = tbLinkREC.Text + "?dest=mx";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox2.SelectedItem == "Rusia")
            {
                url = tbLinkREC.Text + "?dest=ru";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox2.SelectedItem == "Taiwan")
            {
                url = tbLinkREC.Text + "?dest=tw";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox2.SelectedItem == "Japan")
            {
                url = tbLinkREC.Text + "?dest=jp";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox2.SelectedItem == "Korea")
            {
                url = tbLinkREC.Text + "?dest=kr";
                System.Diagnostics.Process.Start(url.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Southeast Asia")
            {
                url = tbLinkSYS.Text + "?dest=sa";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox1.SelectedItem == "North America")
            {
                url = tbLinkSYS.Text + "?dest=na";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox1.SelectedItem == "United Kingdom")
            {
                url = tbLinkSYS.Text + "?dest=uk";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox1.SelectedItem == "Australia")
            {
                url = tbLinkSYS.Text + "?dest=au";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox1.SelectedItem == "Brazil")
            {
                url = tbLinkSYS.Text + "?dest=br";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox1.SelectedItem == "China")
            {
                url = tbLinkSYS.Text + "?dest=cn";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox1.SelectedItem == "European Union")
            {
                url = tbLinkSYS.Text + "?dest=eu";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox1.SelectedItem == "Latin/Central America")
            {
                url = tbLinkSYS.Text + "?dest=mx";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox1.SelectedItem == "Rusia")
            {
                url = tbLinkSYS.Text + "?dest=ru";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox1.SelectedItem == "Taiwan")
            {
                url = tbLinkSYS.Text + "?dest=tw";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox1.SelectedItem == "Japan")
            {
                url = tbLinkSYS.Text + "?dest=jp";
                System.Diagnostics.Process.Start(url.ToString());
            }
            else if (comboBox1.SelectedItem == "Korea")
            {
                url = tbLinkSYS.Text + "?dest=kr";
                System.Diagnostics.Process.Start(url.ToString());
            }


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string path = Environment.CurrentDirectory;
            if (Directory.Exists(path + "\\Temp"))
            {
                Directory.Delete(path + "\\Temp", true);
            }
        }
    }
}
