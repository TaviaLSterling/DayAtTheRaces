using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public partial class Form1 : Form
    {
        Greyhound[] dogsArray = new Greyhound[4];
        private Timer timer1;
        private IContainer components;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        int joeBet = 0;
        int bobBet = 0;
        int alBet = 0;
        bool Bet = false;
        public string winningDog;
        
        Guy[] guyArray = new Guy[3];
        private Label labelJoe;
        private Label labelBob;
        private Label labelAl;
        Random Randomizer = new Random();
        public Form1()
        {
            InitializeComponent();

            dogsArray[0] = new Greyhound() { MyPictureBox = pictureBox1, Name = "Humphrey", RacetrackLength = racetrackPictureBox.Width - racetrackPictureBox.Width, StartingPosition = racetrackPictureBox.Left, Randomizer = Randomizer };
            dogsArray[1] = new Greyhound() { MyPictureBox = pictureBox2, Name = "Jasper", RacetrackLength = racetrackPictureBox.Width - racetrackPictureBox.Width, StartingPosition = pictureBox1.Left, Randomizer = Randomizer };
            dogsArray[2] = new Greyhound() { MyPictureBox = pictureBox3, Name = "Slim", RacetrackLength = racetrackPictureBox.Width - racetrackPictureBox.Width, StartingPosition = pictureBox2.Left, Randomizer = Randomizer };
            dogsArray[3] = new Greyhound() { MyPictureBox = pictureBox4, Name = "Jim", RacetrackLength = racetrackPictureBox.Width - racetrackPictureBox.Width, StartingPosition = pictureBox3.Left, Randomizer = Randomizer };

            guyArray[0] = new Guy() { MyBet = null, Name = "Joe", Cash = 50, MyLabel = labelJoe, MyRadioButton = rbJoe, MyLabel2 = labelJoeBet };
            guyArray[1] = new Guy() { MyBet = null, Name = "Bob", Cash = 75, MyLabel = labelBob, MyRadioButton = rbBob, MyLabel2 = labelBobBet };
            guyArray[2] = new Guy() { MyBet = null, Name = "Al", Cash = 45, MyLabel = labelAl, MyRadioButton = rbAl, MyLabel2 = labelAlBet };

            guyArray[0].UpdateLabels();
            guyArray[1].UpdateLabels();
            guyArray[2].UpdateLabels();

              
        }
    }
}
