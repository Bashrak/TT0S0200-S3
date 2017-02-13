using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Lassi's T2 version 1.0
// 12.1.2017
// © Lassi Oja K8321
namespace T_09
{
    class T_09
    {
        static void Main(string[] args)
        {
            int[] adding = new int[100];

            Console.WriteLine("Give us numbers that you'd want to add, 0 exits the program: ");

            for (int i = 0; i < 100; i++)
                   
            {
                string userValue = Console.ReadLine();
                int num2;

                if (int.TryParse(userValue, out num2))
                {
                    adding[i] = num2;
                }

                if (num2 == 0)
                {
                    break;
                }
            }

            int sum = adding.Sum();

            Console.WriteLine("The sum of your numbers is " + sum);




        }
    }
}
