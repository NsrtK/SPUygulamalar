using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDers2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String AdSoyad = textBox1.Text;
            string sonuc;

            if (checkBoxYazilim.Checked && checkBoxOffice.Checked || checkBoxYazilim.Checked && checkBoxDil.Checked || checkBoxOffice.Checked && checkBoxDil.Checked || checkBoxYazilim.Checked && checkBoxOffice.Checked && checkBoxDil.Checked)
            {
                sonuc = "İş mülakatına çağırılabilir";
                lbkisiler.Items.Add(AdSoyad + " - " + sonuc);

            }
            else
            {
                sonuc = "İş mülakatına çağırılamaz";
                MessageBox.Show(sonuc);
                lbkisiler.Items.Add(AdSoyad + " - " + sonuc);

            }
            textBox1.Clear();
            checkBoxYazilim.Checked = false;
            checkBoxOffice.Checked = false;
            checkBoxDil.Checked = false;
        }
    }
}
