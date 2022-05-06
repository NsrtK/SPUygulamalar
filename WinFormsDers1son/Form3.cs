using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDers1son
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double y1, y2, p1, p2, ort;

            y1 = Convert.ToDouble(textBox1.Text);
            y2 = Convert.ToDouble(textBox2.Text);
           p1 = Convert.ToDouble(textBox3.Text);
           p2 = Convert.ToDouble(textBox4.Text);

            ort = (y1 + y2 + p1 + p2) / 4;

            lblort.Text = ort.ToString();

            if (ort >= 50)
            {
                lbldurum.Text = "Geçtiniz";
                lbldurum.ForeColor = Color.Green;

            }
            if (ort < 50)
            {
                lbldurum.Text = "Kaldınız";
                lbldurum.ForeColor = Color.Red;

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
