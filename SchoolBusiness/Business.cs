using SchoolData;
using SchoolDomain.Models;
using System;

namespace SchoolBusiness
{
    public class Business
    {
        public void AddStudent(int id, string name, double gpa)
        {
            var data = new Data();
            var student = new Student { Id = id, Name = name, Gpa = gpa };
            data.CreateStudent(student);
        }

        public void AddInstructor(int id, string name)
        {
            var data = new Data();
            var instructor = new Instructor { Id = id, Name = name };
            data.CreateInstructor(instructor);
        }

        public void AddCourse(int id, string name, int creditHours)
        {
            var data = new Data();
            var course = new Course { Id = id, Name = name, CreditHours = creditHours };
            data.CreateCourse(course);
        }
    }
}
