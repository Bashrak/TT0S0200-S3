using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Lassi's T2 version 1.0
// 12.1.2017
// © Lassi Oja K8321
namespace T_10
{
    class T_10
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]{1,2,33,44,55,68,77,96,100};

            for (int i = 0; i < 9; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine("{0} ", numbers[i] + " HEP!");
                }
                else
                    Console.WriteLine("{0} ", numbers[i]);
            }
        }
    }
}
