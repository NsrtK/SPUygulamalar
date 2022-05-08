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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnGoruntule_Click(object sender, EventArgs e)
        {
            Otomobil oto = new Otomobil(); //programa otomobil sınıfının kullanılacağını bildirmek

            oto.marka = "Toyota";
            oto.model ="Corolla";
            oto.modelYili = 2013;
            oto.renk = "Beyaz";
            oto.VitesTipi = "Manuel";

            labelMarka.Text = oto.marka.ToString();
            labelModel.Text = oto.model.ToString();
            labelYil.Text = oto.modelYili.ToString();
            labelRenk.Text = oto.renk.ToString();
            labelVites.Text = oto.VitesTipi.ToString();

        }
    }
}
