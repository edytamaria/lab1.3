using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    public class UProgram
    {
            public string Name{get; set; }
            //private List<Degree> degrees = new List<Degree>();
            public List<Degree> degrees {get ;set;}

            public UProgram(string name){
                this.Name = name;
                degrees = new List<Degree>();
            }

           public void AddDegree(Degree degree){
                degrees.Add(degree);
            }
            
    }
}