namespace FormDers6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void buttonKadGor_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();

            ogr.Ad = textBoxad.Text;
            ogr.Soyad = textBoxsoyad.Text;
            ogr.Sinif= textBoxsinif.Text;
            ogr.Yas= textBoxyas.Text;
            ogr.OgrNo = int.Parse(textBoxogrno.Text);

            labelGoruntule.Text = ogr.OgrenciBilgi();
        }
    }
}