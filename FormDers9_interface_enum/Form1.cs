namespace FormDers9_interface_enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHsGoster_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();

            musteri.MusteriAd=tbmusterAD.Text;
            musteri.MusteriSoyad = tbmusterSoyAD.Text;
            musteri.Urunadet=int.Parse(tbAdet.Text);
            musteri.UrunFiyat = int.Parse(tbFiyat.Text);


            MessageBox.Show(musteri.bilgileriYaz());
        }
    }
}