using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planista_przyjęć_str_238
{
    internal class DinnerParty
    {
        public int NumberOfPeople;
        public int DrinkCost;
        public decimal DecorationCost;


        public decimal CalculateCost(bool Zdrowie, bool Dekoracje)
        {
            decimal suma = NumberOfPeople * 25;

            if (Dekoracje)
            {
                suma += 50 + 15 * NumberOfPeople;
            }
            else suma += 30 + 7.5M * NumberOfPeople;

            if (Zdrowie)
            {
                suma += 5 * NumberOfPeople;
                suma = suma * 0.95M;
            }
            else suma += 20 * NumberOfPeople;
             
            return suma;
        }

        
    }
}
