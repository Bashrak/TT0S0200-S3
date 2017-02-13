using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_02
{
    class Program
    {
        static void Vahvari()
        {
            Amplifier amp = new Amplifier();
            Console.WriteLine("Give a value to set the amplifier volume: ");
            amp.Vol = int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Vahvari();

        }
    }
}
