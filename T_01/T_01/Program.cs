using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Lassi's T1 tehty 11.1.2017
// © Lassi Oja K8321
// Testi
namespace T_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Give number between 1-3 ");
            num = int.Parse(Console.ReadLine());

            {
                switch (num)
                {
                    case 1:
                        {
                            Console.WriteLine("You entered number one.");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("You entered number two.");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("You entered number three");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You entered a wrong number, please read the instuctions carefully.");
                            break;
                        }
                }

            }




        }
    }
}

