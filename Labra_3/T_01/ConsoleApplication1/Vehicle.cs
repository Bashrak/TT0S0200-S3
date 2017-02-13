using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_04
{
    class Vehicle
    {
        string Name { get; set; }
        int Speed { get; set; }
        int Tyres { get; set; }

        public Vehicle (string name, int speed, int tyres)
        {
            Name = name;
            Speed = speed;
            Tyres = tyres;
        }

        public string PrintData()
        {
            string help = String.Format("Your car name is {0}\nIt's top speed is {1}\nTyres are {2}", Name,Speed,Tyres );
            return help;
        }

        public string ToString()
        {
            return String.Format("Car name: {0} Top speed: {1} Tyres: {2}", Name, Speed, Tyres);
        }
    }
}

