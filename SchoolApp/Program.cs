using SchoolService;

namespace SchoolApp
{
    internal static class Program
    {
        private static void Main()
        {
            var service = new Service();
            service.Controller("CreateStudent", new string[] { "1", "Bob Smith", "0" });
            service.Controller("CreateInstructor", new string[] { "1", "Prof. Doe" });
            service.Controller("createcourse", new string[] { "1", "Algebra", "3" });
        }
    }
}
