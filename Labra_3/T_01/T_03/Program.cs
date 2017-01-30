using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_03
{    
        class Program
        {
            static void Main(string[] args)
            {
                TVManagement();
            }

            static void TVManagement()
            {
                TV tv = new TV(32, "Thomson", 2014);
                Console.WriteLine("You bought a new TV, it's model is {1} and it's {0} inches wide, it's a year {2} model", tv.Inch, tv.Model, tv.Year);
            }
        }
    }