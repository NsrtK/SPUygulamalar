namespace FormDers3
   
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Saniye = 60;
        int Dakika = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor= Color.Yellow;
        }

        private void buttonSayac_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Dakika = Convert.ToInt16(textBoxDkk.Text);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 10; // ms cinsinden timer hýzý, 1000 ms = 1 sn

            Saniye = Saniye - 1;


            labelDkk.Text = Convert.ToString (Dakika - 1);
            labelSn.Text = Convert.ToString(Saniye);

            if (Saniye == 0)
            {
                Dakika = Dakika - 1;
                labelDkk.Text =Convert.ToString (Dakika);
                Saniye = 60;
            }
            if (labelDkk.Text == "-1")
            {
                timer1.Stop();
                labelDkk.Text = "00";
                labelSn.Text = "00";
                BackColor = Color.Red;

            }

        }
    }
}