using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_At_The_Races
{
    class Greyhound
    {

        public int StartingPosition; //Where my PictureBox Starts (or the picture file that I create)
        public int RacetrackLength; //How long the racetrack is
        public PictureBox MyPictureBox = null; //MyPictureBox object
        public int Location = 0; // My Location on the racetrack
        public Random Randomizer; // An instance of Random (You only need one instance of Random - each Greyhoun's Ranomzier reference should point to the same Random object
        public bool GoingForward = true;
        public string Name;
        public bool Winner;


        public bool Run()
        {
            Random Randomizer = new Random();
            int move = Randomizer.Next(1,6);
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
        public void TakeStartingPostion()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }


    }
}