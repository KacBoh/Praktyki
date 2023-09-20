namespace Losowe_karty_str_409
{

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Pieć losowych kart: ");
            List<Card> cards = new List<Card>();
            for (int i = 0; i < 5; i++)
            {
                cards.Add(new Card((Suits) random.Next(4), (Values) random.Next(1,14)));
                Console.WriteLine(cards[i].Name);
            }

            Console.WriteLine();
            Console.WriteLine("te same karty potasowane:");
            cards.Sort(new CardComparer_byValue());
            foreach(Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
            Console.ReadKey();
        }
             
    }
    
}
    
