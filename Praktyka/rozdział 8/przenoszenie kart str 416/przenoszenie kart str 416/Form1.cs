namespace przenoszenie_kart_str_416
{
    public partial class Form1 : Form
    {
        Deck deck1;
        Deck deck2;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            ResetDeck(1);
            ResetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void ResetDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                int numberOfCards = random.Next(1, 11);
                deck1 = new Deck(new Card[] { });
                for (int i = 0; i < numberOfCards; i++)
                {
                    deck1.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
                }
                deck1.Sort();
            }
            else deck2 = new Deck();
        }

        public void RedrawDeck(int DeckNumber)
        {
            if (DeckNumber == 1)
            {
                ListDeck1.Items.Clear();
                foreach (string cardname in deck1.GetCardNames())
                    ListDeck1.Items.Add(cardname);

            }
            else
            {
                ListDeck2.Items.Clear();
                foreach (string cardname in deck2.GetCardNames())
                    ListDeck2.Items.Add(cardname);


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Reset1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void Reset2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void Mix1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void Mix2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }

        private void MoveToDeck2_Click(object sender, EventArgs e)
        {
            if (ListDeck2.SelectedIndex >= 0)
            {
                if (deck1.Count > 0)
                {
                    deck2.Add(deck1.Deal(ListDeck1.SelectedIndex));
                }
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void MoveToDeck1_Click(object sender, EventArgs e)
        {
            if (ListDeck1.SelectedIndex >= 0)
            {
                if (deck2.Count > 0)
                {
                    deck1.Add(deck2.Deal(ListDeck2.SelectedIndex));
                }
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }
    }
}