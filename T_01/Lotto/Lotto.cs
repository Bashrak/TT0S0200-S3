using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Lotto
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] table = new int[40];
            int[] winNumbers = new int[7];
            int lotteryNumbers = rnd.Next(1,40);
            int lines;

            for (int j = 0; j < table.Length; j++)
            {
                table j = winNumbers;
            }
            

            Console.WriteLine("How many lines would you like? :");
            lines = System.Convert.ToInt32(System.Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                
            }




        }
    }
}
