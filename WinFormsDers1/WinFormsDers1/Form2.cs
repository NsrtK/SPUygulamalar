using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDers1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kilo;
            double boy, vki;

            kilo = int.Parse(textBox1.Text);
            boy = int.Parse(textBox2.Text);
            vki = kilo / (boy * boy);

            label3.Text = "Vücut kitle index sonucunuz =" + vki;


        }
    }
}
