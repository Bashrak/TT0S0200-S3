using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Toteuta Televisio-luokan ohjelmointi sekä pääohjelma, jolla luot olion Televisio-luokasta. 
 * Säädä luomaasi Televsio-oliota erilaisilla arvoilla, jätä Console.WriteLine()-tulostuslauseet ohjelmaasi, 
 * jotta televisio-olion käyttäminen jää näkyville.
 */
namespace T_03
{
    class Program
    {
        static void TV()
        {
            TV tv = new TV(0,"",0);
            Console.WriteLine("What's the model of your TV? ");
            tv.Model = (Console.ReadLine());

            Console.WriteLine("Whats the size of your TV? ");
            tv.Size = float.Parse(Console.ReadLine());

            Console.WriteLine("What year you bought it? ");
            tv.Year = int.Parse(Console.ReadLine());

            Console.WriteLine("Your TV model is " + tv.Model + " and the size is " + tv.Size + " and you bougth it in year " + tv.Year);
        }
        static void Main(string[] args)
        {
            TV();
        }
    }
}
