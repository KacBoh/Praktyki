namespace Kontrolki_str_219
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LabelBouncer[] bouncers = new LabelBouncer[3];

        private void ToogleBouncing(int index, Label labelToBounce)
        {
            if (bouncers[index] == null)
            {
                bouncers[index] = new LabelBouncer();
                bouncers[index].Mylabel = labelToBounce;
            }
            else
            {
                bouncers[index] = null;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ToogleBouncing(0, label1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToogleBouncing(1, label2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToogleBouncing(2, label3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (bouncers[i] != null)
                {
                    bouncers[i].Move();
                }
            }
        }
    }
}