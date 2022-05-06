namespace FormDers2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Toplama");
            comboBox1.Items.Add("Çýkarma");
            comboBox1.Items.Add("Çarpma");
            comboBox1.Items.Add("Bölme");
            comboBox1.Items.Add("Mod");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Sayi1, Sayi2, sonuc;
            Sayi1=double.Parse(textBox1.Text);  
            Sayi2=double.Parse(textBox2.Text);

            if (comboBox1.SelectedIndex==0)
            {
                sonuc = Sayi1 + Sayi2;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                sonuc = Sayi1 - Sayi2;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                sonuc = Sayi1 * Sayi2;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                sonuc = Sayi1 / Sayi2;
            }
            else 
            {
                sonuc = Sayi1 % Sayi2;
            }

            label5.Text = sonuc.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }
    }
}