using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_05
{
    class Program 
    {
        static void Students()
        {
            List<Student> list = new List<Student>();
            list.Add(new Student("Osku Opiskelija", "I123", 22));
            list.Add(new Student("Milla Maiskuttelija", "I124", 27));
            list.Add(new Student("Marko Mopittaja", "I125", 30));
            list.Add(new Student("Elmeri Elokas", "I126", 20));
            list.Add(new Student("Gerberd Garushas", "I127", 35));

            foreach (Student ope in list)
            {
                Console.WriteLine(ope.ToString());
            }
        }


        static void Main(string[] args)
        {
            Students();
        }
    }
}
