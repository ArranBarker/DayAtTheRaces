﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    class Greyhound
    { 
        public int StartingPosition; // Where my PictureBox starts   
        public int RacetrackLength; // How long the racetrack is   
        public PictureBox MyPictureBox = null; // My PictureBox object   
        public int Location = 0; // My Location on the racetrack  
        public Random Randomizer; // An instance of Random
        
        public bool Run() 
        {     
            // Move forward either 1, 2, 3 or 4 spaces at random      
            // Update the position of my PictureBox on the form     
            // Return true if I won the race
            StartingPosition = 0;
            RacetrackLength = 24;

            foreach ()
            {
                if (Location < RacetrackLength)
                {
                    Randomizer = new Random();
                    int RandomizerInt = Randomizer.Next(0, 5);
                    return Location + ;
                }
                else
                {
                    Location = RacetrackLength;
                }
            }

        } 

        public void TakeStartingPosition()
        {     
            // Reset my location to the start line
            if (Location > 0)
            {

            }
        } 
    }
}
