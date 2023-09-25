using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wymówki_str_463
{
    internal class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath {  get; set; }
        public Excuse()
        {
            ExcusePath = "";
        }
        public Excuse(Random random, string folder)
        {
            string[] fileNames = Directory.GetFiles(folder, "*.txt");
            OpenFile(fileNames[random.Next(fileNames.Lenght)]);
        }

        private void OpenFile(string excusePath) 
        {
            this.ExcusePath = excusePath;
            using (StreamReder reader = new StreamReader(excusePath))
            {
                Description = reader.Readline();
                Results = reader.Readline();
                LastUsed = Convert.ToDateTime(reader.ReadLine());
            }
        }

        public void Save(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(ExcusePath))
            {
                writer.WriteLine(Description);
                writer.WriteLine(Results);
                writer.WriteLine(LastUsed);
            }
        }

    }
}
