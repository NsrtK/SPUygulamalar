namespace FormDers7_Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            Emlak ev = new Emlak();

            ev.Semt = textBoxSemt.Text;
            ev.Odasayisi=int.Parse(textBoxOdaSayisi.Text);
            ev.KatNo = int.Parse(textBoxKatNo.Text);
            ev.Alan = int.Parse(textBoxAlan.Text);


            ListViewItem kayit = new ListViewItem();

            kayit.Text = ev.Semt;
            kayit.SubItems.Add(ev.Odasayisi.ToString());
            kayit.SubItems.Add(ev.KatNo.ToString());
            kayit.SubItems.Add(ev.Alan.ToString());

            listViewEmlak.Items.Add(kayit);

        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxSemt.Clear();
            textBoxOdaSayisi.Clear();
            textBoxKatNo.Clear();
            textBoxAlan.Clear();

        }
    }
}