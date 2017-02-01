using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Toteuta Kiuas-luokan ohjelmointi sekä pääohjelma, jolla luot olion Kiuas-luokasta. 
 * Säädä kiuas-oliota erilaisilla arvoilla, jätä Console.WriteLine()-tulostuslauseet ohjelmaasi, 
 * jotta kiuas-olion käyttäminen jää näkyville.
 */

namespace T_01
{
    class Program
    {
        static void TestSaunaOven()
        {
            string temporal;

            Kiuas kiuas = new Kiuas();

            while (true)
            {
                Console.WriteLine("Is the sauna oven on?");
                temporal = Console.ReadLine();
                if (temporal.Equals("yes"))
                {
                    kiuas.KiuasOn = true;
                    break;
                }
                else
                {
                    kiuas.KiuasOn = false;
                    Console.WriteLine("Please turn the sauna oven on.");
                }

            }

            if (kiuas.KiuasOn)
            {
                Console.WriteLine("How high would you like to set the sauna temperature? ");
                kiuas.Temp = int.Parse(Console.ReadLine());

                Console.WriteLine("How about the humidity? ");
                kiuas.Humidity = int.Parse(Console.ReadLine());

                Console.WriteLine("You have set the temperature to " + kiuas.Temp + "C and the humidity to " + kiuas.Humidity + "%");

                Console.WriteLine();

            }

        }



        static void Main(string[] args)
        {
            try
            {
                TestSaunaOven();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}


