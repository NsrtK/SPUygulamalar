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
    public partial class SayiUretme : Form
    {
        public SayiUretme()
        {
            InitializeComponent();
        }

        private void buttonsy1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int sayi1= random.Next(-1,10);
            listBoxsy1.Items.Add(sayi1);


        }

        private void buttonsy2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int sayi1 = random.Next(9, 100);
            listBoxsy2.Items.Add(sayi1);
        }

        private void buttonsy3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int sayi1 = random.Next(99, 1000);
            listBoxsy3.Items.Add(sayi1);
        }

        private void buttonsy4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int sayi1 = random.Next(999, 10000);
            listBoxsy4.Items.Add(sayi1);
        }

        private void buttonsy5_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int sayi1 = random.Next(9999, 100000);
            listBoxsy5.Items.Add(sayi1);
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            listBoxsy1.Items.Clear();
            listBoxsy2.Items.Clear();
            listBoxsy3.Items.Clear();
            listBoxsy4.Items.Clear();
            listBoxsy5.Items.Clear();
        }
    }
}
