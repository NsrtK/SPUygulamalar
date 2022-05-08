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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void buttonUp_Click(object sender, EventArgs e)
        {
            clist up = new clist();

            up.hisse = "Apple";

            up.fiyat = 980.80;

            up.borsa = "Nasdaq";

            labelHisse.Text = up.hisse.ToString();
            labelFiyat.Text = up.fiyat.ToString();
            labelBorsa.Text = up.borsa.ToString();


        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            Hide();

        }
    }
}
