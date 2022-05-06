using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace FormDers4
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void buttonbaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttondurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }

        string[] dosyalar = Directory.GetFiles(@"C:\Users\nkose\OneDrive\Pictures\Vs_Fotograflar");

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            pictureBox1.ImageLocation = dosyalar[rnd.Next(dosyalar.Length)];    
        }
    }
}
