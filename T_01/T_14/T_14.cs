using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_14
{
    class T_14
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>();
            Console.WriteLine("Give us grades from the programming course, from 0-5, 10 ends the program");
            int num;
            while (true)
            {
                Console.Write("Give a grade > ");
                num = int.Parse(Console.ReadLine());

                if (num == 10)
                {
                    break;
                }
                else if (num > 5 || num < 0)
                {
                    Console.WriteLine("Invalid number, please inster number from 0-5");
                }
                else
                {
                    grades.Add(num);
                }

            }
            int[] arraygrades = grades.ToArray();
            Array.Sort(arraygrades);
            Console.WriteLine("Grades:");
            for (int j = 0; j <= 5; j++)
            {
                Console.Write("\n{0}:", j);
                for (int i = 0; i < arraygrades.Length; i++)
                {
                    if (arraygrades[i] == j)
                    {
                        Console.Write("*");
                        
                    }
                }
            }
        }
    }
}
