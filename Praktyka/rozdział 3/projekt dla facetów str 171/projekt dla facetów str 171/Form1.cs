using System.Text.Json.Serialization;

namespace projekt_dla_facetów_str_171
{
    public partial class Form1 : Form
    {
        guy joe;

        guy bob;

        int bank = 100;
        public Form1()
        {
            InitializeComponent();
            joe = new guy();
            joe.Name = "Joe";
            joe.Cash = 50;

            bob = new guy();
            bob.Name = "Bob";
            bob.Cash = 100;
            UpdateForm();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Receive_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= 10;
                joe.ReceiveCash(10);
                UpdateForm();
            }
            else
                MessageBox.Show("Bank jest za biedny");
        }

        private void Give_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        public void UpdateForm()
        {
            JoeCash.Text = joe.Name + " ma " + joe.Cash + "zł";
            BobsCash.Text = bob.Name + " ma " + bob.Cash + "zł";
            BankCash.Text = "Bank ma " + bank + "zł";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            joe.GiveCash(10);
            bob.ReceiveCash(10);
            UpdateForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bob.GiveCash(10);
            joe.ReceiveCash(10);
            UpdateForm();
        }
    }

    class guy
    {
        public string Name;
        public int Cash;
        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("Za mało mam by dać ci " + amount, Name + " powiedział...");
                return 0;
            }
        }

        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " to nie jest ilość jaką moge wziąść " + Name + "powiedział...");
                return 0;
            }
        }
    }
}