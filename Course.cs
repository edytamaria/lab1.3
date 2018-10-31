using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    public class Course
    {
        public string CourseName {get; set;}
        private List<Student> students {get;set;}
        private List<Teacher> teachers {get; set;}

        public Course(string courseName){
            students = new List<Student>();
            teachers = new List<Teacher>();
            this.CourseName = courseName;

       }

       public void AddStudent(Student student){
             students.Add(student);
             //Console.WriteLine(student.Name +" "+ student.Surname);
       }
        private static int teacherCounter = 0;
        public void AddTeacher(Teacher teacher){
           teachers.Add(teacher);
           teacherCounter ++ ;
        }

        // additional method to count number of students/ teachers assignet to that course
        public int TeacherNumber(){
            return teachers.Count();
        }
        
       
    }
}