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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

      

        private void Form2_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("İlkbahar");//index 0
            comboBox1.Items.Add("Yaz"); // index 1
            comboBox1.Items.Add("Sonbahar"); // 2
            comboBox1.Items.Add("Kış"); // 3


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.SelectedIndex==0)
            {
                listBox1.Items.Add("Mart");
                listBox1.Items.Add("Nisan");
                listBox1.Items.Add("Mayıs");
            }
           else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Add("Haziran");
                listBox1.Items.Add("Temmuz");
                listBox1.Items.Add("Ağustos");
            }
           else  if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Add("Eylül");
                listBox1.Items.Add("Ekim");
                listBox1.Items.Add("Kasım");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                listBox1.Items.Add("Aralık");
                listBox1.Items.Add("Ocak");
                listBox1.Items.Add("Şubat");
            }
        }
    }
}
