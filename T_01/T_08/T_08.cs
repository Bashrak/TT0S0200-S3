using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Lassi's T2 version 1.0
// 12.1.2017
// © Lassi Oja K8321
namespace T_08
{
    class T_08
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];

            Console.WriteLine("Give out three numbers: ");

            for (int i = 0; i < 3; i++)
            {
                string userValue = Console.ReadLine();
                int num2;

                if (int.TryParse(userValue, out num2))
                {
                    num[i] = num2;
                }
            }
            int max = num.Max();

            Console.WriteLine("The highest number you inputted is " + max);
        }
    }
}

