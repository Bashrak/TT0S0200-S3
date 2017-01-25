using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_16
{
    class T_16
    {
        static void Main(string[] args)
        {
            int randNum;
            int Num;
            int Guesses = 0;
            Random rand = new Random();
            randNum = rand.Next(0, 100);

            Console.WriteLine("Guess a number between 0-100");
            while (true)
            {
                Console.Write("Give your guess: ");
                Num = int.Parse(Console.ReadLine());
                if (randNum == Num)
                {
                    Console.WriteLine("Nice one, you guessed the number on the guess {0}", Guesses);
                    break;
                }
                else if (randNum > Num)
                {
                    Console.WriteLine("Number is bigger");
                    Guesses++;
                }
                else if (randNum < Num)
                {
                    Console.WriteLine("Number is smaller");
                    Guesses++;
                }
            }
            Console.ReadLine();
        }
    }
}