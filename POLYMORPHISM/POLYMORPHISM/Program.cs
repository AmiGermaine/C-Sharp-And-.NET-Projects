using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMORPHISM
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee(); //instantiate and initialize an Employee object
            //employee.firstName = "Sample";
            //employee.lastName = "Student";
            //employee.SayName();

            IQuittable quit = new Employee();
            quit.Quit();

            Console.ReadLine();
        }
    }
}
