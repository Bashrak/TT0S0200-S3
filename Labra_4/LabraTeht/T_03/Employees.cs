using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_03
{
    class Employees
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Profession { get; set; }

        public Employees()
        {

        }

        public override string ToString()
        {
            return "Name: " + Name + " Profession: " + Profession + " Salary: " + Salary;
        }
    }
}


