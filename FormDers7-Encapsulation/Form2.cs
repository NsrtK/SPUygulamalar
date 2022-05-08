using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDers7_Encapsulation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            nothesap not=new nothesap();

            not.AdSoyad = textBoxAdSoyad.Text;
            not.Ders = textBoxDers.Text;
            not.Not1 = double.Parse(textBoxNot1.Text);
            not.Not2 = double.Parse(textBoxNot2.Text);
            textBoxOrt.Text=not.Ort.ToString();





            ListViewItem NotList = new ListViewItem();

            NotList.Text = not.AdSoyad;
            NotList.SubItems.Add(not.Ders);
            NotList.SubItems.Add(not.Ort.ToString());

            listViewTablo.Items.Add(NotList);

        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxAdSoyad.Clear();
            textBoxDers.Clear();
            textBoxNot1.Clear();
            textBoxNot2.Clear();
            textBoxOrt.Clear();

        }
    }
}
