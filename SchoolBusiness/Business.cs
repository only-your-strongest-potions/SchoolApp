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
            var model = new StudentModel { Id = id, Name = name, Gpa = gpa };
            data.CreateStudent(model);
        }

        public void AddInstructor(int id, string name)
        {
            var data = new Data();
            var model = new InstructorModel { Id = id, Name = name };
            data.CreateInstructor(model);
        }

        public void AddCourse(int id, string name, int creditHours)
        {
            var data = new Data();
            var model = new CourseModel { Id = id, Name = name, CreditHours = creditHours };
            data.CreateCourse(model);
        }
    }
}
