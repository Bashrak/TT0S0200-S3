using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_13
{
    class T_13
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int sum = 0;
            Console.WriteLine("Give us the score from 5 judges. ");

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Give a score :");
                num[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(num);
            for (int i = 1; i < num.Length -1; i++)
            {
                sum += num[i];
            }

            Console.WriteLine("The final score is: " + sum);
            Console.ReadLine();

        }
    }
}
