using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDAAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> newList = employee.Employees.Where();
            //List<string> Employees = new List<string>();
            

            List<Employee> Info = new List<Employee>()  //creating a list of 10 employees, with two employees having the same firstname.
            {
                new Employee{ ID = 1 , FirstName = "Jane", LastName = "Doe" },
                new Employee{ ID = 2 , FirstName = "Scott", LastName = "Day"},
                new Employee{ ID = 3 , FirstName = "Fate", LastName = "Holly"},
                new Employee{ ID = 4 , FirstName = "Ric", LastName = "Morty"},
                new Employee{ ID = 5 , FirstName = "Lex", LastName = "Flower"},
                new Employee{ ID = 6 , FirstName = "Ford", LastName = "Runner"},
                new Employee{ ID = 7 , FirstName = "Mercy", LastName = "Beaucoup"},
                new Employee{ ID = 8 , FirstName = "Big", LastName = "Burger"},
                new Employee{ ID = 9 , FirstName = "Joe", LastName = "Monday"},
                new Employee{ ID = 10 , FirstName = "Joe", LastName = "Jones"}
            };
            
            List<Employee> EmployeeObject = new List<Employee>();
          
            foreach (Employee emp in Info) //Using a foreach loop, to create a new list of all employees with the first name “Joe”.
            {
                if (emp.FirstName == "Joe")
                {
                    Console.WriteLine(emp.FirstName);
                    Console.WriteLine(emp.ID);
                    EmployeeObject.Add(emp);
                } 
            }
            List<Employee> info2 = Info.Where(x => x.FirstName == "Joe").ToList();
            List<Employee> info3 = Info.Where(x => x.ID > 5).ToList(); //Using a lambda expression, to make a list of all employees with an Id number greater than 5.

            Console.ReadLine();
        }
    }
}
