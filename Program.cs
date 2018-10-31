using System;

namespace oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Uprogram1 = new UProgram("Information Technology");
            var bachelor = new Degree("bachelor");
            var master = new Degree("master");

            Uprogram1.AddDegree(bachelor);
            Uprogram1.AddDegree(master);
            
            var csprogram = new Course("Programming with C#");
            var rubyprogram = new Course("ruby on rails");

            bachelor.AddCourse(csprogram);
            var student1 = new Student("Harry", "Potter");
            var student2 = new Student("Hermiona", "Grenger");
            var student3 = new Student("Ginny", "Weasley");
            csprogram.AddStudent(student1);
            csprogram.AddStudent(student2);
            csprogram.AddStudent(student3);
            bachelor.AddCourse(csprogram);
           
            var teacher1 = new Teacher("Obiwan", "Kenobi");
            var teacher2 = new Teacher("Severus", "Snape");
            var teacher3 = new Teacher("Albus", "Dumblegore");
            csprogram.AddTeacher(teacher1);
            csprogram.AddTeacher(teacher3);
            rubyprogram.AddTeacher(teacher2);
            
            // tests
            Console.WriteLine("{0} teachers in total", Teacher.TNr());
            Console.WriteLine("{0} teachers in C# course", csprogram.TeacherNumber());
            Console.WriteLine("{0} teachers in ruby course", rubyprogram.TeacherNumber());

        }
    }
}
