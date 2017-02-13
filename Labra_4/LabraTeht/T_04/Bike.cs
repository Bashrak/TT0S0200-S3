using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_04
{
    class Bike
    {
        string Name { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        string Gears { get; set; }
        string GearsManu { get; set; }

        public override string ToString()
        {
            return base.ToString() + ", "

    }
}
