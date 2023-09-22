using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idź_na_ryby
{
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

        public static string[] names0 = new string[] { "", "asów", "dwójek", "trójek", "czwórek", "piątek", "szóstek", "siódemek", "ósemek", "dziewiątek", " dziesiątek", "waletów", "dam", "królów" };
        
        public static string Plural(Values value, int count)
        {
            return names0[(int)value];
        }

        private static string[] suits = new string[] { "pik", "trefl", "karo", "kier" };
        private static string[] names = new string[] { "", "asów", "dwójek", "trójek", "czwórek", "piątek", "szóstek", "siódemek", "ósemek", "dziewiątek", " dziesiątek", "waletów", "dam", "królów" };

    }
}