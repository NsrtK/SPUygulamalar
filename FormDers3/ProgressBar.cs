using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormDers3
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }


        int Sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            label1.Text = "%" + Sayac;

            if (Sayac==100)
            {
                timer1.Stop();
                MessageBox.Show("Yükleme Tamamlandı", "Durum");
            }

            progressBar1.Value= Sayac;
            Sayac++;



        }

        private void buttonBasla_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void buttonDur_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }
    }
}
