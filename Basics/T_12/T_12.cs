using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_12
{
    class T_12
    {
        static void Main(string[] args)
        {

            int[] num = new int[5];

            Console.WriteLine("Insert 5 numbers");

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Give a number: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Numbers are ");

            for (int i = num.Length -1; i > 0 ; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine(num[i]);
                }

                else
                {
                    Console.WriteLine("");
                    Console.WriteLine(num[i] + "");
                }
            }
            
            Console.WriteLine();
            
        }
    }
}
