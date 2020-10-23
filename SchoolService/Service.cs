using SchoolBusiness;
using System;
using System.Globalization;

namespace SchoolService
{
    public class Service
    {
        public void Controller(string methodName, string[] variables)
        {
            var business = new Business();

            switch (methodName.ToLower())
            {
                case "createstudent":
                    var studentId = Convert.ToInt32(variables[0]);
                    var studentName = variables[1];
                    var gpa = Convert.ToDouble(variables[2]);
                    business.AddStudent(studentId, studentName, gpa);
                    break;
                case "createinstructor":
                    var instructorId = Convert.ToInt32(variables[0]);
                    var instructorName = variables[1];
                    business.AddInstructor(instructorId, instructorName);
                    break;
                case "createcourse":
                    var courseId = Convert.ToInt32(variables[0]);
                    var courseName = variables[1];
                    var creditHours = Convert.ToInt32(variables[2]);
                    business.AddCourse(courseId, courseName, creditHours);
                    break;
            }
        }
    }
}
