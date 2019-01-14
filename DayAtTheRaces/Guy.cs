using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;
        
        public Label MyLabel2;

        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " has $" + Cash;     
        }
        public void ClearBet()
        {
            MyBet = null;
            MyLabel2.Text = Name + " hasn't placed a bet";
        }
        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            this.MyBet = new Bet() { Amount = BetAmount, Dog = DogToWin, Bettor = this};
            if (BetAmount <= Cash)
            {
                MyLabel2.Text = this.Name + " bets " + BetAmount + " dollars on " + DogToWin;
                this.UpdateLabels();
                return true;
            }
            else
            {
                MessageBox.Show(Name + " does not have enough to cover that bet ");
                this.MyBet = null;
                return false;
            }
        }
        public void Collect(int Winner)
        {
            if (MyBet != null)
                Cash = Cash + MyBet.PayOut(Winner);
            ClearBet();
            UpdateLabels();
        }
    }
}
