using SchoolData;
using SchoolDomain;

namespace SchoolBusiness
{
    public class Business
    {
        public void CreateStudent(int id, string name, double gpa)
        {
            var data = new Data();
            var student = new Student { Id = id, Name = name, Gpa = gpa };
            data.AddStudent(student);
        }

        public void CreateInstructor(int id, string name)
        {
            var data = new Data();
            var instructor = new Instructor { Id = id, Name = name };
            data.AddInstructor(instructor);
        }

        public void CreateCourse(int id, string name, int creditHours)
        {
            var data = new Data();
            var course = new Course { Id = id, Name = name, CreditHours = creditHours };
            data.AddCourse(course);
        }
    }
}
