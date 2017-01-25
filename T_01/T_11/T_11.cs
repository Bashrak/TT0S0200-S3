using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_11
{
    class T_11
    {
        static void Main(string[] args)
        {
            Input();
            Console.ReadLine();
        }

        static void Input()
        {
            int num;
            Console.WriteLine("Give us a amout of lines you'd want to print. :");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
