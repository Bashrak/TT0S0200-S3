﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Lassi's T2 version 1.0
// 12.1.2017
// © Lassi Oja K8321
namespace T_07
{
    class T_07
    {
        static void Main(string[] args)
        {
            int year = 0;
            Console.WriteLine("Give a year that you would like to know if it's a leap year: ");
            year = int.Parse(Console.ReadLine());

            if(DateTime.IsLeapYear(year))
            {
                Console.WriteLine("The year " + year + " is a leap year.");
            }

            else
            {
                Console.WriteLine("The year is not a leap year.");
            }
        }
    }
}
