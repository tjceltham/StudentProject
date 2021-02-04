using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject
{
    class Grdae
    {
        private string subject;
        private string grade;

        public Grdae(string s, string g)
        {
            subject = s;
            grade = g;
        }

        public string getSubject(){

            return subject;
        }
        public string getGracde()
        {

            return grade;
        }
    }
}
