namespace WinFormsDers1son
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double boy, kilo, vki;
            boy = Convert.ToDouble(textBox1.Text);
            kilo = Convert.ToDouble(textBox2.Text);
            vki = kilo / (boy * boy);
            label5.Text=vki.ToString();

            //18 alt� zay�f
            //18-25 aras� normal
            //25-30 aras� kilolu
            //30 �st� dana

            if (vki < 18)
            {
                label6.Text = "Zay�fs�n�z";

            }
            else if (vki >=18 && vki <25)
            {
                label6.Text = "Normalsiniz";

            }
            else if (vki >25 && vki < 30)
            {
                label6.Text = "Kilolusunuz";

            }
            else
            {
                label6.Text = "Danas�n�z";
            }



        }
    }
}