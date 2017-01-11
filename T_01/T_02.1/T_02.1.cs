using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Lassi's T2 version 1.1
// 11.1.2017
// © Lassi Oja K8321
namespace T_02._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grade = new int[] 
            { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 5 };

            int points = 0;

            Console.WriteLine("Give your point totals: ");
            points = int.Parse(Console.ReadLine());

            Console.WriteLine("Your grade is " + grade[points]);
            
        }
    }
}
