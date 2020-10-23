using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDomain.Models
{
    public class Student
    {
        public static List<Student> Students;

        static Student()
        {
            Students = new List<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Gpa { get; set; }
    }
}
