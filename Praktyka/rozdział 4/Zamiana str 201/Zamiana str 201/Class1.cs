using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamiana_str_201
{
    internal class Elephant
    {
        string Name;
        int EarSize;

        public Elephant(string name, int earSize)
        {
            Name = name;
            EarSize = earSize;
        }

        public void WhoIAm()
        {
            MessageBox.Show(Name + " " +  EarSize);
        }
    }
}
