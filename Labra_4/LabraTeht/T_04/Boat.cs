﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_04
{
    class Boat : Vehicle
    {
        private int SeatCount { get; set; }
        private string BoatType { get; set; }

        public Boat(string nimi, string mdl, int year, string clr, int count, string type)
            : base(nimi, mdl, year, clr)
        {
            SeatCount = count;
            BoatType = type;
        }

        public override string ToString()
        {
            return "Boat: \n" + base.ToString() + ". Seat count: " + SeatCount + ". Boat Type: " + BoatType;
        }
    }
}
