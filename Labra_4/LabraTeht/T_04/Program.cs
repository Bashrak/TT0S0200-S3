using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_04
{
    class Program
    {
        static void Kulkimet()
    {
        Bike bike = new Bike("Jopo", "Street", 2016, "Blue", false);
        Bike bike2 = new Bike("Tunturi", "StreetPower", 2010, "Black", true, "Shimano");
        Boat boat = new Boat("Suvi", "S900", 1990, "White", 3, "Row Boat");
        Boat boat2 = new Boat("Yamaha", "1000", 2010, "Yellow", 5, "Motorboat");
        Console.WriteLine(bike.ToString());
        Console.WriteLine(bike2.ToString());
        Console.WriteLine(boat.ToString());
        Console.WriteLine(boat2.ToString());
    }
  
        static void Main(string[] args)
        {
            Kulkimet();
        }

    }
}

