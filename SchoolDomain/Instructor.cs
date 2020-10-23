using System.Collections.Generic;

namespace SchoolDomain
{
    public class Instructor
    {
        public static List<Instructor> Instructors;

        static Instructor()
        {
            Instructors = new List<Instructor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
