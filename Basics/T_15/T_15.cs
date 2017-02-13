using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_15
{
    class T_15
    {
        static void Main(string[] args)
        {
            int height;
            int help;
            int helpTwo;
            int tree = 1;

            Console.Write("Give tree height : ");
            height = int.Parse(Console.ReadLine());

            help = height - 3;

            helpTwo = height - 3;

            for (int i = 0; i <= height - 3; i++)
            {
                for (int j = 0; j <= help; j++)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < tree; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                tree += 2;
                help -= 1;
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j <= helpTwo; j++)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < 1; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}