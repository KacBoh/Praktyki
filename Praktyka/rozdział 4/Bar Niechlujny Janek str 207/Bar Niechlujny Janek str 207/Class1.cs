using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Niechlujny_Janek_str_207
{
    internal class MenuMaker
    {
        public Random Randomizer;

        string[] Meats = { "Wołowina", "Salami", "Indyk", "Szynka", "Karkówka" };
        string[] Condiments = { "Żółta musztarda", "Musztarda miodowa", "Przyprawa", "Sos francuski" };
        string[] Breads = { "Chleb ryżowy", "Chleb biały", "Chleb zbożowy", "Bułka" };
        
        public string GetMenuItem()
        {
            
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat + ", " + randomCondiment + ", " + randomBread;
        }

    }
}
