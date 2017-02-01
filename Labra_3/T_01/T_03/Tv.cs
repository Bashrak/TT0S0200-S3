using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_03
{
    class TV
    {
        public float Size { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public TV(float size, string model, int year)
        {
            Size = size;
            Model = model;
            Year = year;
        }

    }
}

