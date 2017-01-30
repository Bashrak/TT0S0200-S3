using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_01
{
    public class Kiuas
    {
        public bool kiuasOn { get; set; }
        public float temp { get; set; }
        public float humidity { get; set; }
                
        public float Humidity
        {
            get
            {
                return Humidity;
            }
                set
                {
                    humidity = value;

                    if (humidity <0 || humidity > 100)
                    {
                    humidity = 0;
                    }
                }

            }

        }
        
    }
}
