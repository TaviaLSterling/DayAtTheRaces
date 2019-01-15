using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAtTheRaces
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;
        public int odds;


        public string GetDescription()
        {
            if (Amount == 0)
                return Bettor.Name + "has not placed a bet";
            else
                return Bettor.Name + " placed a bet of " + Amount + " dollars on " + Dog;
        }
        public int PayOut(int Winner)
        {
            if (Winner == Dog)
                return Amount * odds;
            else
                return (0 - Amount);
        }
    }
}
