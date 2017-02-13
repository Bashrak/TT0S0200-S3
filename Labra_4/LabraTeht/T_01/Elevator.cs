using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_01
{
    class Elevator
    {
        int floor;

        public int Floor
        {
           get
           {
                return floor;
           }
           set
            {
                if(value >= 1 && value <= 5)
                {
                    floor = value;
                    Console.WriteLine("Elavator is at floor number " + value);
                }
                else
                {
                    Console.WriteLine("Unknown floor number.");
                }
            }
        }
    }
}
