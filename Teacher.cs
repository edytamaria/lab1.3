using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    public class Teacher
    {
        public string Name {get; set; }

        public string Surname {get; set; }
        private static int tcounter = 0;
        public Teacher(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;

            tcounter ++;
        }

        public static int TNr(){
            return tcounter;
        }
    }
}
