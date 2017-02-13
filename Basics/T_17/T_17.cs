using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_17
{
    class T_17
    {
        static void Main(string[] args)
        {
            {
                List<int> FirstList = new List<int>();
                List<int> SecList = new List<int>();
                int[] ArrayList;
                int apu;
                Console.WriteLine("Give numbers for 2 different tables. 0 end the input for a table.");
                while (true)
                {
                    Console.Write("Give a number for first table: ");
                    apu = int.Parse(Console.ReadLine());
                    if (apu == 0)
                    {
                        break;
                    }
                    else
                    {
                        FirstList.Add(apu);
                    }
                }

                while (true)
                {
                    Console.Write("Give a number for second table: ");
                    apu = int.Parse(Console.ReadLine());
                    if (apu == 0)
                    {
                        break;
                    }
                    else
                    {
                        SecList.Add(apu);
                    }
                }
                Console.Write("First lists numbers: ");
                for (int i = 0; i < FirstList.Count; i++)
                {
                    if (i == FirstList.Count - 1)
                    {
                        Console.Write(FirstList[i]);
                    }
                    else
                    {
                        Console.Write(FirstList[i] + ",");
                    }

                }

                Console.Write("\nSecond lists numbers: ");
                for (int i = 0; i < SecList.Count; i++)
                {
                    if (i == SecList.Count - 1)
                    {
                        Console.Write(SecList[i]);
                    }
                    else
                    {
                        Console.Write(SecList[i] + ",");
                    }

                }

                FirstList.AddRange(SecList);
                ArrayList = FirstList.ToArray();
                Array.Sort(ArrayList);

                Console.Write("\nNumbers in united tables: ");
                for (int i = 0; i < ArrayList.Length; i++)
                {
                    if (i == ArrayList.Length - 1)
                    {
                        Console.Write(ArrayList[i]);
                    }
                    else
                    {
                        Console.Write(ArrayList[i] + ",");

                    }
                }
            }
        }
    }
}