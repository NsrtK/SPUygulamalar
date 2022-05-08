using System.IO;



namespace FormD5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDosyaOlustur_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Users\nkose\Desktop\Ýsimler.txt"))
            {
                MessageBox.Show("Dosya Mevcut");
            }
            else
            {
                StreamWriter dosya = new StreamWriter(@"C:\Users\nkose\Desktop\Ýsimler.txt");
                dosya.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            StreamWriter ekle = File.AppendText(@"C:\Users\nkose\Desktop\Ýsimler.txt");
            ekle.WriteLine((textBoxAd.Text) + " " + textBoxSoyad.Text);
            ekle.Close();
            textBoxAd.Clear();
            textBoxSoyad.Clear();
            MessageBox.Show("Kaydedildi");

        }

        private void buttonGoster_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            StreamReader oku = File.OpenText(@"C:\Users\nkose\Desktop\Ýsimler.txt");
            string satirlar = oku.ReadLine();
            while (satirlar != null)
            {
                listBox1.Items.Add(satirlar);
                satirlar = oku.ReadLine();  
            }

            oku.Close();

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {

            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);

            File.Delete(@"C:\Users\nkose\Desktop\Ýsimler.txt");

           
        }  
    }
}