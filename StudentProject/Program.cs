using System;

namespace StudentProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("tjc", "Sydenham", "12\\34\\89");
            s.addGrade("Computing", "A*");
            s.addGrade("Art", "A*");
            s.printStudentDetails();

        }
    }
}
