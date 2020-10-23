using System.Collections.Generic;

namespace SchoolDomain.Models
{
    public class CourseModel
    {
        public static List<CourseModel> Courses;

        static CourseModel()
        {
            Courses = new List<CourseModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CreditHours { get; set; }
    }
}
