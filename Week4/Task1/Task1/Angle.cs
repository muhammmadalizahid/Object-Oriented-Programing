﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Angle
    {
        public int Degrees;
        public float Minutes;
        public char Direction;

        public Angle(int degrees, float minutes, char direction)
        {
            Degrees = degrees;
            Minutes = minutes;
            Direction = direction;
        }
    }
}
