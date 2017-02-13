using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_05
{
    class Radio
    {
        public bool OnOff { get; set; }
        public int Volume { get; set; }
        public float Frequency { get; set; }

        public Radio(bool onoff)
        {
            OnOff = onoff;
        }

        public override string ToString()
        {
            if (!OnOff)
            {
                return "Radio is off so you can't change the volume nor the frequency";
            }
            else
            {
                return "Radio is on, set the Frequency " + Frequency + " and set the the Volume" + Volume;
            }
        }
    }
}

