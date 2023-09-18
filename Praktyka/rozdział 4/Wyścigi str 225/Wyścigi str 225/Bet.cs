using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyścigi_str_225
{
    internal class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            if (Bettor.MyBet.Amount == 0)
            {
                return Bettor.Imie + " nie zawarł zakładu";
            }
            else
            {
                return Bettor.Imie + " postawił " + Bettor.MyBet.Amount + " na psa nr " + Bettor.MyBet.Dog + ".";
            }
        }

        public int PayOut(int Winner)
        {
            if(Bettor.MyBet.Dog == Winner)
            {
                return Amount * 2;
            }
            else
            {
                return -Amount;
            }
        }

        
    }
}
