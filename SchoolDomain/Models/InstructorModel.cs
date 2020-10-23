using System.Collections.Generic;

namespace SchoolDomain.Models
{
    public class InstructorModel
    {
        public static List<InstructorModel> Instructors;

        static InstructorModel()
        {
            Instructors = new List<InstructorModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
