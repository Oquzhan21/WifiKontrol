using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace İnternetKontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ping ping = new Ping();
            PingReply pingstatü = ping.Send(IPAddress.Parse("208.69.34.231"));

            if (pingstatü.Status == IPStatus.Success)
            {
                PicDurum.BackgroundImage = Image.FromFile(Application.StartupPath + "\\wifi.jpg");
                LblSonuc.Text = "Bağlantı Var";
            }

            else
            {
                PicDurum.BackgroundImage = Image.FromFile("NoWifi.jpg");
                LblSonuc.Text = "Bağlantı Yok";
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
