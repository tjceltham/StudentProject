using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject
{
    class Grade
    {
        private string subject;
        private string grade;

        public Grade(string s, string g)
        {
            subject = s;
            grade = g;
        }

        public string getSubject()
        {

            return subject;
        }
        public string getGrade()
        {

            return grade;
        }
    }
}
