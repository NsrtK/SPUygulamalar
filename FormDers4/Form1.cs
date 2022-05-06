namespace FormDers4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            int artisDegeri = Convert.ToInt32(numericUpDown1.Value);
            sayac += artisDegeri;

            label2.Text = sayac.ToString();



        }
    }
}