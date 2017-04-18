using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_01
{
    class Program
    {
        static void Ohjelma()
        {
            Elevator ele = new Elevator();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("What floor would you like to go to? ");
                ele.Floor = int.Parse(Console.ReadLine());
            }
            
        }

        static void Main(string[] args)
        {
            Ohjelma();
        }
    }
}
