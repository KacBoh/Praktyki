namespace card_str_389
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Suits
        {
            Spades,
            Clubs,
            Diamonds,
            Hearts
        }

        enum Values
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eights = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13
        }

        class Card
        {
            public Suits Suit { get; set; }
            public Values Value { get; set; }
            public Card(Suits suit, Values value)
            {
                this.Suit = suit;
                this.Value = value;
            }
            public string Name
            {
                get { return Value.ToString() + " of " + Suit.ToString(); }
            }
        }

        Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            Card card = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));
            MessageBox.Show(card.Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}