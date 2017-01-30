using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_02
{
    public class Washer
    {
        public bool Work { get; set; }
        public int SpinTime { get; set; }
        public string Model { get; set; }

        public Washer(bool work, int time, string model)
        {
            Work = work;
            if (work)
            {
                SpinTime = time;
                Model = model;
            }
        }
    }
}
