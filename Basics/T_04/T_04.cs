using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_04
{
    class T_04
    // Lassi's T2 version 1.0
    // 11.1.2017
    // © Lassi Oja K8321
    {
        static void Main(string[] args)
        {
            int age = 0;

            Console.WriteLine("Give us your age: ");
            age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("You are underage. Time to grow up a bit.");

            }
            else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("You are and adult, you've all grown up, time to be responsible");
            }
            else
            {
                Console.WriteLine("You are a senior, time to enjoy the rest of your days in retirement");
            }
            
        }
    }
}
