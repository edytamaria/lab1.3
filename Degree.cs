using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace oop2
{
    public class Degree
    {
       public string DegreeName{get; set;}
       public List<Course> Courses {get;set;}

       public Degree(string degreeName)
        {
            this.DegreeName = degreeName;
            Courses = new List<Course>();
        }

        public Degree(string degreeName, List<Course> courses){
            this.DegreeName = degreeName;
            Courses = new List<Course>();
            this.Courses = courses;
        }
        
        public void AddCourse(Course course){
            Courses.Add(course);
        }
       
    }
}
