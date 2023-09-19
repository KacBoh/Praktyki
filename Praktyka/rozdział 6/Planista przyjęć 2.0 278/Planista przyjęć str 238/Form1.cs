namespace Planista_przyjęć_str_238
{
    public partial class Form1 : Form
    {
        DinnerParty impreza = new DinnerParty();
        BirthdayParty birthday = new BirthdayParty();
        public Form1()
        {
            InitializeComponent();
            Koszt.Text = Convert.ToString(impreza.CalculateCost(false, false));
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            impreza.NumberOfPeople = (int)People.Value;
            bool health = false;
            bool decoration = false;
            if (zdrowie.Checked)
            {
                health = true;
            }

            if (dekoracja.Checked)
            {
                decoration = true;
            }

            Koszt.Text = Convert.ToString(impreza.CalculateCost(health, decoration));
        }

        private void dekoracja_CheckedChanged(object sender, EventArgs e)
        {
            bool health = false;
            bool decoration = false;
            if (zdrowie.Checked)
            {
                health = true;
            }

            if (dekoracja.Checked)
            {
                decoration = true;
            }

            Koszt.Text = Convert.ToString(impreza.CalculateCost(health, decoration));
        }

        private void zdrowie_CheckedChanged(object sender, EventArgs e)
        {
            bool health = false;
            bool decoration = false;
            if (zdrowie.Checked)
            {
                health = true;
            }

            if (dekoracja.Checked)
            {
                decoration = true;
            }

            Koszt.Text = Convert.ToString(impreza.CalculateCost(health, decoration));
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void People2_ValueChanged(object sender, EventArgs e)
        {
            birthday.NumberOfpeople = (int)People2.Value;
            Koszt2.Text = Convert.ToString(birthday.CalculateCost((int)liczba_literek.Value, Decoration2.Checked));
            if (People2.Value > 4)
            {
                liczba_literek.Maximum = 40;
            }
            else liczba_literek.Maximum = 16;
        }

        private void liczba_literek_ValueChanged(object sender, EventArgs e)
        {
            Koszt2.Text = Convert.ToString(birthday.CalculateCost((int)liczba_literek.Value, Decoration2.Checked));
        }

        private void Decoration2_CheckedChanged(object sender, EventArgs e)
        {
            Koszt2.Text = Convert.ToString(birthday.CalculateCost((int)liczba_literek.Value, Decoration2.Checked));
        }
    }
}