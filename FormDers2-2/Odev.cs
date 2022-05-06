using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDers2_2
{
    public partial class Odev : Form
    {
        public Odev()
        {
            InitializeComponent();
        }

        private void radioButtonOgretmen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOgretmen.Checked)
            {
                listBoxOgretmen.Items.Add(textBox1.Text);
            }
            else
            {
                textBox1.Clear();
            }
           

        }
      

        private void radioButtonOgrenci_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButtonOgrenci.Checked)
            {
                listBoxOgrenci.Items.Add(textBox1.Text);
            }
            else
            {
                textBox1.Clear();
            }

        }
    }
}
