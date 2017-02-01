using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_02
{
    class Washer
    {
        public bool WasherOnOff { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public int Temperature { get; set; }
        public int SpinSpeed { get; set; }

        public Washer()
        {
            Console.WriteLine("Please input the following info about your washer:");
           
        }

    }
}
