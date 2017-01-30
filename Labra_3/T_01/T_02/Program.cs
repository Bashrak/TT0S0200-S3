using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_02
{

    class Program
    {
        static void Main(string[] args)
        {
            washerManager();
        }

        static void washerManager()
        {
            Washer washer = new Washer(true, 200, "Fujitsu");
            if (washer.Work)
            {
                Console.WriteLine("Machine works and it's model is {0} and the time it finishes is {1}" , washer.Model, washer.SpinTime);
            }
            else
            {
                Console.WriteLine("Washer is broken, fix it or get a new one.)");
            }
            Console.WriteLine();

        }
    }
}