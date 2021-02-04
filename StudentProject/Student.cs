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
        public Student(string n, string a, string d)
        {
            name = n;
            address = a;
            dob = d;
            subject = new string[5];
            grade = new string[5];
        }


        public bool addGrade(string sub, string grade)
        {
            bool added = false;
            // check for duplicatted subject - update duplicatted.



            countGrades++;
            sort();
            return added;
        }

        public void printStudentDetails()
        {

        }
        private void sort()
        {

        }
    }
}
