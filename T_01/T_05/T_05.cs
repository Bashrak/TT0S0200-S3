using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_05
{
    class T_05
    {
        static void Main()
        {
            Console.WriteLine("Give the time in second that you'd want to convert to hours, minutes and seconds: ");
            int sec = int.Parse(Console.ReadLine()); ;
           
            TimeSpan t = TimeSpan.FromSeconds(sec);
            Console.WriteLine("Your result is " + t.ToString(@"hh\:mm\:ss"));

            Console.ReadLine();
        }
    }
}
