﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGame
{
    class Fish
    {
        public int count = 0, clickCounter = 2;


        //win and lose count
        public int loseCount = 0, winCount = 0;

        //This holds the random number
        public int rnd;

        public int Shark;




        //This generates the random number
        public int RandomNUmber()
        {
            int rnd = 0;
            Random myRandom = new Random();
            rnd = myRandom.Next(1, 7);
            return rnd;
        }










    }
}
