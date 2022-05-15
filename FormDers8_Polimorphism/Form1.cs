namespace FormDers8_Polimorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sepet spt = new Sepet();
            CepTelefonu cep = new CepTelefonu("Nokia", "1133", 3000);
            Ekmek ekmek = new Ekmek("UNO",2,"Cavdarli",20);
            Bilgisayar Bilg = new Bilgisayar("Acer", 20000, "Laptop", "intel", 32);
            //spt.UrunEkle(ekmek);
            spt.UrunEkle(Bilg);


            MessageBox.Show(spt.toplamTutar().ToString());


        }
    }
}