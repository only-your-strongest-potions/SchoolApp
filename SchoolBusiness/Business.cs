using SchoolData;
using SchoolDomain;

namespace SchoolBusiness
{
    public class Business
    {
        public void CreateStudent(int id, string name, double gpa)
        {
            var data = new Data();
            data.AddStudent(new Student { Id = id, Name = name, Gpa = gpa });
        }

        public void CreateInstructor(int id, string name)
        {
            var data = new Data();
            data.AddInstructor(new Instructor { Id = id, Name = name });
        }

        public void CreateCourse(int id, string name, int creditHours)
        {
            var data = new Data();
            data.AddCourse(new Course { Id = id, Name = name, CreditHours = creditHours });
        }
    }
}
