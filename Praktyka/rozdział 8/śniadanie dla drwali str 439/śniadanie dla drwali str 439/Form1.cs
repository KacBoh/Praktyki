namespace śniadanie_dla_drwali_str_439
{
    public partial class Form1 : Form
    {
        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(LumberJack_name.Text)) return;
            breakfastLine.Enqueue(new Lumberjack(LumberJack_name.Text));
            LumberJack_name.Text = "";
            Redrawlist();
        }

        private void Redrawlist()
        {
            int number = 1;
            line.Items.Clear();
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                line.Items.Add(number + ". " + lumberjack.Name);
                number++;
            }
            if (breakfastLine.Count == 0)
            {
                groupBox1.Enabled = false;
                nextInLine.Text = "";
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = breakfastLine.Peek();
                nextInLine.Text = currentLumberjack.Name + " ma " + currentLumberjack.FlapjackCount + " naleśników";

            }
        }


        private void Next_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0) return;
            Lumberjack nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapjacks();
            nextInLine.Text = "";
            Redrawlist();
        }

        private void AddFJ_Click(object sender, EventArgs e)
        {
            Flapjack food;
            if (Crispy.Checked)
            {
                food = Flapjack.Chrupkiego;
            }
            else if (Soggy.Checked)
            {
                food = Flapjack.Wilgotnego;
            }
            else if (Rum.Checked)
            {
                food = Flapjack.Rumianego;
            }
            else 
                food = Flapjack.Bananowego;
            
            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int) howMany.Value);
            Redrawlist();
        }
    }
}