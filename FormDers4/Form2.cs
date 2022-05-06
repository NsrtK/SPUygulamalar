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

namespace FormDers4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string BilgisayarAdi = Dns.GetHostName();
            label1.Text = "Bilgisayar Adı: " + BilgisayarAdi;

            string IpAdresi = Dns.GetHostByName(BilgisayarAdi).AddressList[0].ToString();
            label2.Text = "Bilgisayar IP: " + IpAdresi;
            

        }
    }
}
