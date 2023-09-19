
namespace aplikacja_interfejsy_str_335
{
    public class TallGuy : IClown
    {
        public string Name;
        public int Height;
        public void TalkAboutYourself()
        {
            Console.WriteLine("Nazywam się " + Name + " i mam " + Height + " centymetrów wzrostu");
        }
        public string FunnyThingIHave { get { return "duże buty"; } }
        public void Honk()
        {
            Console.WriteLine("Tut tuut!!");

        }




        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { Height = 74, Name = "Adam" };
            tallGuy.TalkAboutYourself();
            tallGuy.Honk();
            ScaryScary fingersTheClown = new ScaryScary("Duże buty", 35);
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someOtherScaryClown.Honk();
            Console.ReadLine();
        }
    }
}