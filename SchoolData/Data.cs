using SchoolDomain;

namespace SchoolData
{
    public class Data
    {
        public void AddStudent(Student student)
        {
            Student.Students.Add(student);
        }

        public void AddInstructor(Instructor instructor)
        {
            Instructor.Instructors.Add(instructor);
        }

        public void AddCourse(Course course)
        {
            Course.Courses.Add(course);
        }
    }
}
