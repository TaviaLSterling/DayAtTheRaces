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
       
       
       
        int joeBet = 0;
        int bobBet = 0;
        int alBet = 0;
        bool Bet = false;
        public string winningDog;
        
        Guy[] guyArray = new Guy[3];
        private Label labelJoeBet;
        private Label labelBobBet;
        private Label labelAlBet;
        Random Randomizer = new Random();


        public Form1()
        {
            InitializeComponent();

            dogsArray[0] = new Greyhound() { MyPictureBox = pictureBox1, Name = "Humphrey", RacetrackLength = racetrackPictureBox.Width - racetrackPictureBox.Width, StartingPosition = racetrackPictureBox.Left, Randomizer = Randomizer };
            dogsArray[1] = new Greyhound() { MyPictureBox = pictureBox2, Name = "Jasper", RacetrackLength = racetrackPictureBox.Width - racetrackPictureBox.Width, StartingPosition = pictureBox1.Left, Randomizer = Randomizer };
            dogsArray[2] = new Greyhound() { MyPictureBox = pictureBox3, Name = "Slim", RacetrackLength = racetrackPictureBox.Width - racetrackPictureBox.Width, StartingPosition = pictureBox2.Left, Randomizer = Randomizer };
            dogsArray[3] = new Greyhound() { MyPictureBox = pictureBox4, Name = "Jim", RacetrackLength = racetrackPictureBox.Width - racetrackPictureBox.Width, StartingPosition = pictureBox3.Left, Randomizer = Randomizer };

            guyArray[0] = new Guy() { MyBet = null, Name = "Joe", Cash = 50, MyRadioButton = rbJoe, MyLabel = labelJoeBet };
            guyArray[1] = new Guy() { MyBet = null, Name = "Bob", Cash = 75, MyRadioButton = rbBob, MyLabel = labelBobBet };
            guyArray[2] = new Guy() { MyBet = null, Name = "Al", Cash = 45, MyRadioButton = rbAl, MyLabel = labelAlBet };

            guyArray[0].UpdateLabels();
            guyArray[1].UpdateLabels();
            guyArray[2].UpdateLabels();

              
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dogsArray.Length; i++)
            {

                dogsArray[i].Run();
                if (dogsArray[i].Run() == true)
                {
                    timer2.Stop();
                    timer2.Enabled = false;
                    MessageBox.Show(dogsArray[i].Name + " has won the race");
                    winningDog = dogsArray[i].Name;
                    i = dogsArray.Length;
                    btnRace.Enabled = true;
                }

            }
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            dogsArray[0].TakeStartingPosition();
            dogsArray[1].TakeStartingPosition();
            dogsArray[2].TakeStartingPosition();
            dogsArray[3].TakeStartingPosition();
            joeBet = 0;
            bobBet = 0;
            alBet = 0;
            btnRace.Enabled = false;
            timer2.Start();
        }

        private void rbJoe_CheckedChanged(object sender, EventArgs e)
        {
            rbJoe.Text = guyArray[0].Name;
        }

        private void rbBob_CheckedChanged(object sender, EventArgs e)
        {
            rbBob.Text = guyArray[1].Name;
        }

        private void rbAl_CheckedChanged(object sender, EventArgs e)
        {
            rbAl.Text = guyArray[2].Name;
        }

    }
}
