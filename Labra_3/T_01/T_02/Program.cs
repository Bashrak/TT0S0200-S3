using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Tehtävä 2
 * Toteuta Pesukone-luokan ohjelmointi sekä pääohjelma, jolla luot olion Pesukone-luokasta. 
 * Säädä pesukone-oliota erilaisilla arvoilla, jätä Console.WriteLine()-tulostuslauseet ohjelmaasi, 
 * jotta pesukone-olion käyttäminen jää näkyville. Toteuta Pesukone-luokkaan muutamia erilaisia 
 * konstruktoreita ja alusta niitä käyttämällä oliota pääohjelmasta käsin.
 */
namespace T_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string temporal;

            Washer washer = new Washer();

            Console.WriteLine("What is the washers maker? ");
            washer.Maker = (Console.ReadLine());

            Console.WriteLine("And it's model? ");
            washer.Model = (Console.ReadLine());       

            while (true)
            {
                Console.WriteLine("Is the washer on?");
                temporal = Console.ReadLine();
                if (temporal.Equals("yes"))
                {
                    washer.WasherOnOff = true;
                    break;
                }
                else
                {
                    washer.WasherOnOff = false;
                    Console.WriteLine("Please turn the washer on for it to operate.");
                }
            }
            Console.WriteLine("How high would you like to set the temperature of the water during washing operation? ");
            washer.Temperature =int.Parse(Console.ReadLine());

            Console.WriteLine("And the spin speed, your model supports it to max 2000 rounds per minute.");
            washer.SpinSpeed = int.Parse(Console.ReadLine());

            Console.WriteLine("\nYour have given the following info.");
            Console.WriteLine("\nMaker: " + washer.Maker);
            Console.WriteLine("\nModel: " + washer.Model);
            Console.WriteLine("\nTemperature: " + washer.Temperature);
            Console.WriteLine("\nSpin Speed: " + washer.SpinSpeed);
        }
    }
}
