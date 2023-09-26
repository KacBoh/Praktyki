using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using U_niechlujniego_Janka_2._0;

namespace U_niechlujniego_Janka_2._0
{
    internal class MenuMaker
    {
        public Random Randomizer = new Random();

        private List<String> Meats = new List<String>() { "Wołowina", "Salami", "Indyk", "Szynka", "Karkówka" };
        private List<String> Condiments = new List<String>() { "Żółta musztarda", "Musztarda miodowa", "Przyprawa", "Sos francuski" };
        private List<String> Breads = new List<String>() { "Chleb ryżowy", "Chleb biały", "Chleb zbożowy", "Bułka" };
        public ObservableCollection<MenuItem> Menu { get; private set; }

        public DateTime GeneratedDate { get; set; } 
        public int NumberOfItems { get; set; }

        public MenuMaker() 
        {
            Menu = new ObservableCollection<MenuItem>();
            NumberOfItems = 10;
        }

        public MenuItem CreateMenuItem()
        {

            string randomMeat = Meats[Randomizer.Next(Meats.Count)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Count)];
            string randomBread = Breads[Randomizer.Next(Breads.Count)];
            return new MenuItem(randomBread, randomMeat, randomCondiment);
        }

        public void UpdateMenu()
        {
            Menu.Clear();
            for(int i =0; i < NumberOfItems; i++)
            {
                Menu.Add(CreateMenuItem());
            }
            GeneratedDate = DateTime.Now;
        }

    }
}
