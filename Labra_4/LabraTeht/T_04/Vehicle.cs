using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_04
{
    class Vehicle
    {
        private string Name { get; set; }
        private string Model { get; set; }
        private int ModelYear { get; set; }
        private string Color { get; set; }

        public Vehicle(string nimi, string model, int year, string color)
        {
            Name = nimi;
            Model = model;
            ModelYear = year;
            Color = color;
        }

        public override string ToString()
        {
            return "- Name: " + Name + ". Model: " + Model + ". Model Year: " + ModelYear + ". Color: " + Color;
        }
    }
}


