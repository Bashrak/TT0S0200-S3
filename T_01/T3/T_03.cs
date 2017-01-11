using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class T_03
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Give us the first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give us the second number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give us the third number: ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("The average of all three numbers is " + (num1 + num2 + num3)/3);
        }
    }
}
