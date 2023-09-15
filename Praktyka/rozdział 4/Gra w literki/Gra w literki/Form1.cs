namespace Gra_w_literki
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Koniec Gry");
                timer1.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { 
            if (listBox1.Items.Contains(e.KeyCode)) 
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                    timer1.Interval -= 10;
                if (timer1.Interval > 250)
                    timer1.Interval -= 7;
                if (timer1.Interval > 100)
                    timer1.Interval -= 2;
                difficultyProgresBar.Value = 800 - timer1.Interval;

            }
            else
            {
                stats.Update(false);
            }

            corretLabel.Text = "Prawidłowe: " + stats.Correct;
            missedLabel.Text = "Błędy: " + stats.Missed;
            totalLabel.Text = "Łącznie: " + stats.Total;
            accuracyLabel.Text = "Dokładność: " + stats.Accuracy;
        }
    }
}