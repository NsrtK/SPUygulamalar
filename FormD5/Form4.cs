using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormD5
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public void buttonGoruntule_Click(object sender, EventArgs e)
        {
            clist up2=new clist();

            up2.hisse = textBoxHisse.Text;
            up2.fiyat=Double.Parse(textBoxFiyat.Text);
            up2.borsa=textBoxBorsa.Text;


            MessageBox.Show("Hisse : " + up2.hisse + "\nFiyat : " + up2.fiyat + "\nBorsa : " + up2.borsa);

        }
    }
}
