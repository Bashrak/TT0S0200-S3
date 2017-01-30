using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_03
{
    class TV
    {
        public float Inch { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public TV(float inch, string model, int year)
        {
            Inch = inch;
            Model = model;
            Year = year;
        }

    }
}

