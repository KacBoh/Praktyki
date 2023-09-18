using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyścigi_str_225
{
    internal class Guy
    {
        public string Imie;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public TextBox Mylabel;

        

        public void UpdateLabels()
        {
            Mylabel.Text = Imie + " postawił " + MyBet;
            MyRadioButton.Text = Imie + " ma " + Cash;
        }

        public void ClearBet()
        {
            MyBet = null;
        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            MyBet = new Bet() { Amount = BetAmount, Dog= DogToWin, Bettor = this };
            if(BetAmount > this.MyBet.Bettor.Cash)
            {
                MessageBox.Show(Imie + " nie ma wystarczającej ilości pieniędzy");
                return false;
            }
            else
            return true;

        }
         public void Collect(int Winner)
        {
            this.Cash += MyBet.PayOut(Winner);
        }

    }
}
