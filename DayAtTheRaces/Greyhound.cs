using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public bool Winner = false;
        public Random Randomizer;
        public bool Run()
        {
            int move = Randomizer.Next(1, 6);
            Location = Location + move;
            MyPictureBox.Left = StartingPosition + Location;
            if (MyPictureBox.Left >= RacetrackLength)
            {
                Winner = true;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
    }
}
