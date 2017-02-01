using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_01
{
    public class Kiuas
    {
        private readonly int MaxHumidity = 100;
        private readonly int MinHumidity = 0;
        public bool KiuasOn { get; set; }
        public int Temp { get; set; }
        private int humi;

        public int Humidity
        {
            get { return humi; }
            set
            {
                if (value > MaxHumidity)
                    humi = MaxHumidity;
                else if (value < MinHumidity)
                    humi = MinHumidity;
                else
                {
                    humi = value;
                }
            }
        } 
    }
}
