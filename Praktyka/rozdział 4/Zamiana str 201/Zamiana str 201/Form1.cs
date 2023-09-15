namespace Zamiana_str_201
{
    public partial class Form1 : Form
    {
        bool czy_zamiana = false;
        Elephant Lioyd = new Elephant("Lioyd", 35);
        Elephant Lucinda = new Elephant("Lucinda", 40);
        public Form1()
        {
            InitializeComponent();

        }

        private void przycisk1_Click(object sender, EventArgs e)
        {
            if (czy_zamiana)
            {
                Lucinda.WhoIAm();
            }
            else Lioyd.WhoIAm();

        }

        private void przycisk2_Click(object sender, EventArgs e)
        {
            if (czy_zamiana)
            {
                Lioyd.WhoIAm();
            }
            else Lucinda.WhoIAm();

        }

        private void zamiana_Click(object sender, EventArgs e)
        {
            if (!czy_zamiana)
            {
                czy_zamiana = true;
            }
            else czy_zamiana = false;
        }


    }


}