namespace FormDers2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSayiUret_Click(object sender, EventArgs e)
        {
            SayiUretme sayiUretme= new SayiUretme();
            sayiUretme.Show();

        }

        private void btnNotHesapla_Click(object sender, EventArgs e)
        {
            NotHesaplama notHesaplama= new NotHesaplama();
            notHesaplama.Show();

        }
    }
}