using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Veh()
        {
            Vehicle car = new Vehicle("Ford", 220, 4);
            Console.WriteLine(car.PrintData());

            Console.WriteLine(car.ToString());

        }

        static void Main(string[] args)
        {

            Veh();
        }
    }
}
