using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_06
// Lassi's T2 version 1.0
// 11.1.2017
// © Lassi Oja K8321
{
    class T_06
    {
        static void Main(string[] args)
        {
            double consume = 7.02;
            double gasPrice = 1.595;
            int distance = 0;
     
            Console.WriteLine("Give the distance you will travel: ");
            distance = int.Parse(Console.ReadLine());

            double consumeFinal = consume / 100 * distance;
            double gasPriceFinal = gasPrice * consume / 100 * distance;

            Console.WriteLine("Your fuel consumption will be " + Math.Round(consumeFinal, 2) + ", and the cost will be " + Math.Round(gasPriceFinal, 2));
        }
    }
}
