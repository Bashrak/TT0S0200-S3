using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_04
{
    class Bike : Vehicle
    {
        private bool GearWheels { get; set; }
        private string GearType { get; set; }

        public Bike(string name, string model, int year, string color, bool gearwheels, string type)
            : base(name, model, year, color)
        {
            GearWheels = gearwheels;
            GearType = "";
        }
        public Bike(string nimi, string mdl, int year, string clr, bool gearwheels)
             : base(nimi, mdl, year, clr)
        {
            GearWheels = gearwheels;
            GearType = "";
        }

        public override string ToString()
        {
            return "Bike: \n" + base.ToString() + ". Gear Wheels: " + GearWheels + ". Gear Name: " + GearType;
        }
    }
}