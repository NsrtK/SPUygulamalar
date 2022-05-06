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
    public partial class NotHesaplama : Form
    {
        public NotHesaplama()
        {
            InitializeComponent();
        }

        private void buttonNotHesapla_Click(object sender, EventArgs e)
        {
            double vize = 0, final = 0;
            string AdSoyad= textBoxAdSoyad.Text;

            try
            {
                vize = int.Parse(textBoxVize.Text);

               final = int.Parse(textBoxFinal.Text);

                if (vize < 0 || vize > 100 || final < 0 || final > 100)
                {
                    MessageBox.Show("Girdiğiniz Not Hatalı");

                }
                else
                //ort 60'tan büyük ve final 50'den büyükse öğr geçsin

                {
                    double ortalama = (vize * 0.4) + (final * 0.6);
                    if (ortalama >= 60 && final >= 50)
                    {
                        listBoxGecen.Items.Add(AdSoyad + " - " + ortalama.ToString());
                    }
                    else
                    {
                        listBoxKalan.Items.Add(AdSoyad + " - " + ortalama);

                    }
                }
                
                
                
            }
          catch (Exception)
            {


            }

        }
    }
}
