namespace Planista_przyjęć_str_238
{
    public partial class Form1 : Form
    {
        DinnerParty impreza = new DinnerParty();
        public Form1()
        {
            InitializeComponent();
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
    }
}