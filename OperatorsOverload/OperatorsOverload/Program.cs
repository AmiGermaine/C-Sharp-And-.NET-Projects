using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // Instantiate two objects of the Employee class and assign values to their properties.
            employee.FirstName = "Jane";
            employee.LastName = "Doe";
            employee.Id = 4321;

            Employee employee2 = new Employee();
            employee2.FirstName = "Jon";
            employee2.LastName = "Doe2";
            employee2.Id= 5678;

            Console.WriteLine(employee == employee2); //Comparing the two Employee objects using the newly overloaded operators
            Console.ReadLine();
        }
    }
}
