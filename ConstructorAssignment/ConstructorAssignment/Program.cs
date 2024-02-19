using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string thePerson = "Jane Doe"; //declaring a const
            Console.WriteLine("Hello, {0}.", thePerson);
            var person = new Person(); //Creating a variable using the keyword “var.”            
            person.name = "Jane";
            person.id = 1212;
            Console.WriteLine(person.name);
            Console.WriteLine(person.id);
            Console.ReadLine();
        }
    }
}
