namespace Kalkulator_zwrotu_kosztów_str_191
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pocz = (int)poczatek.Value;
            int kon = (int)koniec.Value;
            if (kon < pocz)
            {
                MessageBox.Show("jesteś debilem");
                return;
            }
            else
                kwota.Text = (Math.Round((kon - pocz) * 0.39, 2)) + "zł";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pocz = (int)poczatek.Value;
            int kon = (int)koniec.Value;
            MessageBox.Show("Przebyta odległość: " + Convert.ToString(kon - pocz));
        }
    }
}