using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_05
{
    class Student
    {
        string Name { get; set; }
        string ID { get; set; }
        int Age { get; set; }

        public Student(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
       
        public string ToString()
        {
            return String.Format("Students name: {0} ID: {1} Age: {2}", Name, ID, Age);
        }
    }
}
