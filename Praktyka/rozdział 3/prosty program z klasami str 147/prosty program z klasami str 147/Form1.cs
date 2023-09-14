namespace prosty_program_z_klasami_str_147
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dlugosc = talker.gadanie(textBox1.Text, (int)numericUpDown1.Value);
            MessageBox.Show("Długość wiadomości: " + dlugosc);
        }
    }

    class talker
    {
        public static int gadanie(string thingToSay, int numberOfTimes)
        {
            string finalstring = "";
            for (int count = 0; count < numberOfTimes; count++)
            {
                finalstring += thingToSay + "\n";
            }
            MessageBox.Show(finalstring);
            return finalstring.Length;
        }
    }
}