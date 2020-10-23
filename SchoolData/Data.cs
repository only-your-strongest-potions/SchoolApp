using SchoolDomain.Models;
using System;

namespace SchoolData
{
    public class Data
    {
        public void CreateStudent(StudentModel model)
        {
            StudentModel.Students.Add(model);
        }

        public void CreateInstructor(InstructorModel model)
        {
            InstructorModel.Instructors.Add(model);
        }

        public void CreateCourse(CourseModel model)
        {
            CourseModel.Courses.Add(model);
        }
    }
}
