using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_05
{
    class Program
    {
        static void Radio()
        {
            string apu;
            Radio radio = new Radio(true);

            while (true)
            {
                while (true)
                {
                    Console.Write("\nGive a frequency that you would like to listen: (2000-26000): ");
                    radio.Frequency = float.Parse(Console.ReadLine());
                    if (radio.Frequency > 26000 || radio.Frequency < 2000)
                    {
                        Console.WriteLine("Frequency is out of range, please try again");
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    Console.Write("Set the volume(0-9): ");
                    radio.Volume = int.Parse(Console.ReadLine());
                    if (radio.Volume < 0)
                    {
                        Console.WriteLine("Volume is too low, please try again.");
                    }
                    else if (radio.Volume > 9)
                    {
                        Console.WriteLine("Volume is too high, please try again.");
                    }
                    else
                        break;
                }

                Console.WriteLine(radio.ToString());
                Console.WriteLine("\nListening to music.....");
                System.Threading.Thread.Sleep(10000);
                Console.Write("\nTo exit type quit: ");
                apu = Console.ReadLine();
                if (apu == "quit")
                {
                    radio.OnOff = false;
                    Console.WriteLine(radio.ToString());
                    break;
                }
                else
                {
                    Console.WriteLine("Enjoy listening longer.");
                }
            }
        }
        static void Main(string[] args)
        {
            Radio();
        }
    }
}
