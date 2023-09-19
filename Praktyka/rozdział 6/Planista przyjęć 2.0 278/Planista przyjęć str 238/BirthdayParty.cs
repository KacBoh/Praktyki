using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planista_przyjęć_str_238
{
    internal class BirthdayParty
    {
        public int NumberOfpeople;
        public decimal CostOfDecorations;
        public decimal Cake;
        public string CakeWriting;
        public decimal Cost;

        public decimal CakeCost(int Napisy)
        {
            if (NumberOfpeople <= 4)
            {
                Cake = 20;
                return 40 + Napisy * 0.25M;
            }
            else
            {
                Cake = 40;
                return 75 + Napisy * 0.25M;
            }
        }

        public decimal CalculateCost(int literki, bool decoration)
        {
            if (!decoration)
            {
                return (decimal)CakeCost(literki) + NumberOfpeople * 25 + NumberOfpeople * 7.50M + 30;
            }
            else return (decimal)CakeCost(literki) + NumberOfpeople * 25 + NumberOfpeople * 15 + 50;
        }
    }
}
