using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentContext context = new StudentContext();
            
            var student = new Student() { FirstName = "Jelly", LastName = "Bean" };

            context.Students.Add(student);
                
            context.SaveChanges();
            
        }
    }
}
