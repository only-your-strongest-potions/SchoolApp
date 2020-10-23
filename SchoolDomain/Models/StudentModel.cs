using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDomain.Models
{
    public class StudentModel
    {
        public static List<StudentModel> Students;

        static StudentModel()
        {
            Students = new List<StudentModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Gpa { get; set; }
    }
}
