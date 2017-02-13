using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_02
{
    class Amplifier
    {
        int vol;
        public Amplifier() { }
        public int Vol
        {
            get
            {
                return vol;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    vol = value;
                    Console.WriteLine("Amplifier volume is set to: " + value);
                }
                else
                {
                    Console.WriteLine("Too low volume - Amplifier volume is set to minimum");
                    {
                        vol = 0;
                    }
                }
            }

        }
    }
}

    
