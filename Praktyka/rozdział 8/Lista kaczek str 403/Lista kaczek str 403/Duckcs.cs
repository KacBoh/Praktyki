using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_kaczek_str_403
{
    internal class Duckc : IComparer<Duckc>
    {
        public int Size;
        public KindOfDuck Kind;

        public int CompareTo(Duckc duckToCompare)
        {
            if (this.Size > duckToCompare.Size)
            {
                return 1;
            }
            else if (this.Size < duckToCompare.Size)
            {
                return -1;
            }
            else return 0;
        }
    }
}
