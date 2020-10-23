using System.Collections.Generic;

namespace SchoolDomain.Models
{
    public class Course
    {
        public static List<Course> Courses;

        static Course()
        {
            Courses = new List<Course>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CreditHours { get; set; }
    }
}
