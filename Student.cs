using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    public class Student
    {
        public string Name {get; set; }

        public string Surname {get; set; }
        public Student(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;

        }
    }
}
