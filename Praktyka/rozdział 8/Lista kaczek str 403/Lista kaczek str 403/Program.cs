namespace Lista_kaczek_str_403
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck(){ Kind = KindOfDuck.Mallard, Size = 17},
                new Duck(){ Kind = KindOfDuck.Muscovy, Size = 18},
                new Duck(){ Kind = KindOfDuck.Decoy, Size = 15},
            };

            Console.WriteLine(ducks[1].CompareTo(ducks[2]));
            Console.ReadLine();
        }
    }
}