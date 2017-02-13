using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_03
{
    class Program
    {
        static void Employees()
        {
            Console.WriteLine("Employee:");
            Employees employee1 = new T_03.Employees();
            employee1.Name = "Barry Bonds";
            employee1.Profession = "IT Nerd";
            employee1.Salary = 2000;
            Console.WriteLine(employee1.ToString());

            Console.WriteLine("\nBoss:");
            Boss boss1 = new T_03.Boss();
            boss1.Name = "Gary Golden";
            boss1.Profession = "First Man";
            boss1.Salary = 4000;
            boss1.Car = "Audi A6";
            boss1.Bonus = 2000;
            Console.WriteLine(boss1.ToString());
        }
        static void Main(string[] args)
        {
            Employees();
        }
    }
}
