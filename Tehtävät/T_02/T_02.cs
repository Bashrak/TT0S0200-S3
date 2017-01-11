using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Lassi's T2 version 1.0
// 11.1.2017
// © Lassi Oja K8321

namespace T_02
{
    class T_02
    {
        static void Main(string[] args)
        {
            int points = 0;
            int grade = 0;

            Console.WriteLine("Give the course points: ");
            points = int.Parse(Console.ReadLine());

            if (points == 0 || points == 1)
            {
                grade = 0;
            }

            else if (points == 2 || points == 3)
            {
                grade = 1;
            }

            else if (points == 4 || points == 5)
            {
                grade = 2;
            }

            else if (points == 6 || points == 7)
            {
                grade = 3;
            }

            else if (points == 8 || points == 9)
            {
                grade = 4;
                
            }

            else if (points == 10 || points == 11 || points == 12)
            {
                grade = 5;
                
            }

            Console.WriteLine("Your grade is " + grade);           
                   
        }
    }
}
