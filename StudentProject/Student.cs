using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject
{
    class Student
    {
        private string name;
        private string address;
        private string dob;
        private string[] subject;
        private string[] grade;
        private int countGrades = 0;
        private List<Grade> l;
        public Student(string n, string a, string d)
        {
            name = n;
            address = a;
            dob = d;
            subject = new string[5];
            l = new List<Grade>();
        }



        public bool addGrade(string sub, string grade)
        {
            bool added = false;
            // check for duplicatted subject - update duplicatted.

            Grade t= new Grade(sub, grade);
            l.Add(t);
            added = true;
           
            l.Sort(delegate (Grade x, Grade y)
            {
                if (x.getSubject() == null && y.getSubject() == null) return 0;
                else if (x.getSubject() == null) return -1;
                else if (y.getSubject() == null) return 1;
                else return x.getSubject().CompareTo(y.getSubject());
            });
            return added;
        }

        public void printStudentDetails()
        {
            foreach (Grade e in l)
            {
                Console.WriteLine(e.getSubject() + " " + e.getGrade());
            }

        }
        private void sort()
        {

        }
    }
}
