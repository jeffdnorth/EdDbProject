using EdDbProject.Models;
using System;
using System.Linq;


namespace EdDbProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EdDbContext();
            /* var studentsInKY = context.Students
              /                .Where(s => s.StateCode == "KY")
                                 OrderBy(s => s.Lastname)
                                 .ToList();
             foreach(var s in studentsInKY)
             {
                 Console.WriteLine($"{s.Firstname} {s.Lastname}");  */
            //Ky students by lastname query syntax ..join has to be in order in sql
            //below brings back ky students and joined with major
            var studentsWithMajors = from s in context.Students
                                     join m in context.Majors
                                     on s.MajorId equals m.Id
                                     where s.StateCode == "KY"
                                     orderby s.Lastname
                                     select new {
                                         s.Firstname,s.Lastname, Major = m.Description};
            foreach(var s in studentsWithMajors)
            {
                Console.WriteLine($"{s.Firstname} { s.Lastname} || { s.Major}");
            }

        }

            

        
    }
}
