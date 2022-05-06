using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDers4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            int karakterSayisi = txtSifre.Text.Length;
            if (karakterSayisi > 0 && karakterSayisi < 4)
            {
                progressBar1.Value = 1;
                progressBar1.ForeColor= Color.Red;
                label3.Text = "Zayıf";


            }
            else if (karakterSayisi >= 4 && karakterSayisi < 8)
            {
                progressBar1.Value = 2;
                progressBar1.ForeColor = Color.Yellow;
                label3.Text = "Orta";


            }
            else if (karakterSayisi >= 8)
            {
                progressBar1.Value = 3;
                progressBar1.ForeColor = Color.Green;
                label3.Text = "Güçlü";

            }

            else
            {
                progressBar1.Value = 0;

            }
        }
    }
}
