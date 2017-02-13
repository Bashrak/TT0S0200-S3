using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_04
{
    class Boat
    {
        
        string Type { get; set; }
        int SeatCount { get; set; }

        public override string ToString()
        {
            return base.ToString() + ", Seat Count: " + SeatCount + ", Boat Type: " + Type;
        }        
    }
}
