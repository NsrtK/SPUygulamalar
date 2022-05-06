namespace WinFormsDers_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double boy, vki,kilo;
            
            boy=double.Parse(textBox1.Text);
            kilo=double.Parse(textBox2.Text);

            vki = kilo / (boy * boy);

            labelsonuc.ForeColor = Color.Red;

            labelsonuc.Text =  vki.ToString();

            if (vki < 18)
            {
                lbldurum.Text ="Zayýf";

            }
            else if (vki >= 18 && vki <25)
            {
                lbldurum.Text = "Normal";

            }
            else if (vki >= 25 && vki < 30)
            {
                lbldurum.Text = "Öküz";

            }

            else 
            {
                lbldurum.Text = "Dana";

            }
        }
    }
}