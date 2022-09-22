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
using ByteSizeLib;

namespace PS4_Firmware_Checker
{
    public partial class Form1 : Form
    {
        static string url;
        private string sizeSYS;
        private string sizeREC;
        private string LinkRec;
        private string LinkSys;
        private string version;
        private string mandatory;

        public Form1()
        {
            InitializeComponent();
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

                    try
                    {
                        var nasdaq = string.Format(@"https://fus01.ps4.update.playstation.net/update/ps4/beta/list/us/ps4-eap-updatelist_PR2daYNOWIyy6WYwNw5JVwsRAWMl85Av.xml");
                        using (WebClient wc = new WebClient())
                        {
                            ServicePointManager
                   .ServerCertificateValidationCallback +=
                   (send, cert, chain, sslPolicyErrors) => true;
                            wc.Headers.Add("cookie", "");

                            wc.DownloadFile(nasdaq, path + "\\Temp\\ps4-eap-updatelist.xml");
                        }

                        XDocument beta_read = XDocument.Load(path + @"\\Temp\ps4-eap-updatelist.xml");
                        beta_read.Descendants("region").Select(sys => new
                        {
                            sdkVersion_BETA = sys.Element("system_pup").Attribute("sdk_version"),
                            fwVersion_BETA = sys.Element("system_pup").Attribute("version"),

                        }).ToList().ForEach(sys =>
                        {
                            string sdkbeta = sys.sdkVersion_BETA.ToString().Replace("sdk_version=", "").Replace("\"", "").Replace(".", "");
                            string first_4 = sdkbeta.Substring(0, 4);
                            string first_4_final = first_4.Substring(1, 3);
                            string last_4 = sdkbeta.Substring(4, 4);
                            string last_4_final = last_4.Substring(0, 1);
                            tbSDKBETA.Text = first_4_final.Insert(1, ".") + " B" + last_4_final;

                            string rollback = sys.fwVersion_BETA.ToString().Replace("version=", "").Replace("\"", "").Replace(".", "");
                            string first_4_rollback = rollback.Substring(0, 4);
                            string first_4_rollback_final = first_4_rollback.Substring(1, 3);

                            tbFWVersionBETA.Text = first_4_rollback_final.Insert(1, ".");
                        });
                    }
                    catch
                    {
                        MessageBox.Show("Could not retrieved beta firmware info", "PS4 Firmware Checker");
                    }
                   


                    using (WebClient retailDownloadXML = new WebClient())
                        

                        retailDownloadXML.DownloadFile("http://fus01.ps4.update.playstation.net/update/ps4/list/sa/ps4-updatelist.xml", path + "\\Temp\\ps4-updatelist.xml");
                        XDocument xdoc = XDocument.Load(path + @"\\Temp\ps4-updatelist.xml");
                        xdoc.Descendants("region").Select(sys => new
                        {
                            label = sys.Element("system_pup").Attribute("label"),
                            sdkVersion = sys.Element("system_pup").Attribute("sdk_version"),
                            fwVersion = sys.Element("system_pup").Attribute("version"),

                        }).ToList().ForEach(sys =>
                        {
                            tbFWLabelSYS.Text = sys.label.ToString().Replace("label=", "").Replace("\"", "");
                            tbSDKVersionSYS.Text = sys.sdkVersion.ToString().Replace("sdk_version=", "").Replace("\"", "");
                            version = sys.fwVersion.ToString().Replace("version=", "").Replace("\"", "");
                            tbVersionSYS.Text = version;
                        });

                    xdoc.Descendants("force_update").Select(misc => new
                    {
                        mandatory = misc.Element("system").Attribute("level0_system_version"),


                    }).ToList().ForEach(misc =>
                    {
                        mandatory = misc.mandatory.ToString();
                        mandatory = mandatory.Replace("level0_system_version", "").Replace("\"", "").Replace("=", "");
                        if(version != mandatory)
                        {
                            tbmandatory.Text = "No";
                        }
                        else
                        {
                            tbmandatory.Text = "Yes";

                        }
                    });

                    xdoc.Descendants("update_data").Select(misc => new
                        {
                            Size = misc.Element("image").Attribute("size"),

                        }).ToList().ForEach(misc =>
                        {
                            sizeSYS = misc.Size.ToString().Replace("size=", "").Replace("\"", "");
                            var size_int = Convert.ToInt32(sizeSYS);
                            var size_final = ByteSize.FromBytes(size_int).ToString();

                            tbSizeSYS.Text = size_final;
                        });

                        xdoc.Descendants("recovery_pup").Select(misc => new
                        {
                            size = misc.Element("image").Attribute("size"),

                        }).ToList().ForEach(misc =>
                        {
                            sizeREC = misc.size.ToString().Replace("size=", "").Replace("\"", "");
                            var size_int = Convert.ToInt32(sizeREC);
                            var size_final = ByteSize.FromBytes(size_int).ToString();


                            tbSizeREC.Text = size_final;
                        });

                        xdoc.Descendants("recovery_pup").Select(misc => new
                        {
                            Link = misc.Element("image")

                        }).ToList().ForEach(misc =>
                        {
                            LinkRec = misc.Link.ToString().Replace("<image size=\"", "").Replace("\"", "").Replace("\">", "").Replace("?dest=sa</image>", "").Replace(">", "").Replace(sizeREC, "");
                        });

                        xdoc.Descendants("update_data").Select(misc => new
                        {
                            Link = misc.Element("image")

                        }).ToList().ForEach(misc =>
                        {
                            LinkSys = misc.Link.ToString().Replace("<image size=\"", "").Replace("\"", "").Replace("\">", "").Replace("?dest=sa</image>", "").Replace(">", "").Replace(tbSizeSYS.Text, "").Replace(sizeSYS, ""); ;
                        });

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

                        string SYSMD5 = LinkSys.Substring(LinkSys.IndexOf('_') + 10);
                        string SYSMD5_substring = SYSMD5.Split('/')[0];
                        tbMD5SYS.Text = SYSMD5_substring.ToUpper();

                        string RECMD5 = LinkRec.Substring(LinkRec.IndexOf('_') + 10);
                        string RECMD5_substring = RECMD5.Split('/')[0];
                        tbMD5REC.Text = RECMD5_substring.ToUpper();
                   
                }
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

       

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string path = Environment.CurrentDirectory;
            if (Directory.Exists(path + "\\Temp"))
            {
                Directory.Delete(path + "\\Temp", true);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedItem)
            {
               case "Southeast Asia":
                   url = LinkSys + "?dest=sa";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "United Kindom":
                   LinkSys = LinkSys.Replace("dsa01", "duk01");
                   url = LinkSys + "?dest=uk";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "Australia":
                   LinkSys = LinkSys.Replace("dsa01", "dau01");
                   url = LinkSys + "?dest=au";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "Brazil":
                   LinkSys = LinkSys.Replace("dsa01", "dbr01");
                   url = LinkSys + "?dest=br";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "China":
                   LinkSys = LinkSys.Replace("dsa01", "dcn01");
                   url = LinkSys + "?dest=cn";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "European Union":
                   LinkSys = LinkSys.Replace("dsa01", "deu01");
                   url = LinkSys + "?dest=eu";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "Latin/Central Americca":
                   LinkSys = LinkSys.Replace("dsa01", "dmx01");
                   url = LinkSys + "?dest=mx";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "Russia":
                   LinkSys = LinkSys.Replace("dsa01", "dru01");
                   url = LinkSys + "?dest=ru";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "Taiwan":
                   LinkSys = LinkSys.Replace("dsa01", "dtw01");
                   url = LinkSys + "?dest=tw";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "Japan":
                   LinkSys = LinkSys.Replace("dsa01", "djp01");
                   url = LinkSys + "?dest=jp";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "Korea":
                   LinkSys = LinkSys.Replace("dsa01", "dkr01");
                   url = LinkSys + "?dest=kr";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "United States":
                   LinkSys = LinkSys.Replace("dsa01", "dus01");
                   url = LinkSys + "?dest=us";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            switch(comboBox2.SelectedItem)
            {
               case "Southeast Asia":
                   url = LinkRec + "?dest=sa";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "United Kindom":
                   LinkSys = LinkRec.Replace("dsa01", "duk01");
                   url = LinkRec + "?dest=uk";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "Australia":
                   LinkSys = LinkRec.Replace("dsa01", "dau01");
                   url = LinkRec + "?dest=au";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "Brazil":
                   LinkSys = LinkRec.Replace("dsa01", "dbr01");
                   url = LinkRec + "?dest=br";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "China":
                   LinkSys = LinkRec.Replace("dsa01", "dcn01");
                   url = LinkRec + "?dest=cn";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "European Union":
                   LinkSys = LinkRec.Replace("dsa01", "deu01");
                   url = LinkRec + "?dest=eu";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "Latin/Central Americca":
                   LinkSys = LinkRec.Replace("dsa01", "dmx01");
                   url = LinkRec + "?dest=mx";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "Russia":
                   LinkSys = LinkRec.Replace("dsa01", "dru01");
                   url = LinkRec + "?dest=ru";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "Taiwan":
                   LinkSys = LinkRec.Replace("dsa01", "dtw01");
                   url = LinkRec + "?dest=tw";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "Japan":
                   LinkSys = LinkRec.Replace("dsa01", "djp01");
                   url = LinkRec + "?dest=jp";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "Korea":
                   LinkSys = LinkRec.Replace("dsa01", "dkr01");
                   url = LinkRec + "?dest=kr";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
               case "United States":
                   LinkSys = LinkRec.Replace("dsa01", "dus01");
                   url = LinkRec + "?dest=us";
                   System.Diagnostics.Process.Start(url.ToString());
               break;
            }
        }
    }
}
