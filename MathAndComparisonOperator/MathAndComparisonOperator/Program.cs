using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate: $");
            int payPerson1 = Convert.ToInt32(Console.ReadLine()); ;
            //Console.WriteLine();
            Console.WriteLine("Hours worked per week?");
            int hoursWorked1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(hoursWorked);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            int payPerson2 = Convert.ToInt32(Console.ReadLine()); ;
            //Console.WriteLine(pays);
            Console.WriteLine("Hours worked per week?");
            int hourWorked2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(hourWorked);

            Console.WriteLine("Annual salary of Person 1:");
            int annualSalary1 = payPerson1 * hoursWorked1 * 52;
            Console.WriteLine(annualSalary1.ToString("C"));

            Console.WriteLine("Annual salary of Person 2:");
            int annualSalary2 = payPerson2 * hourWorked2 * 52;
            Console.WriteLine(annualSalary2.ToString("C"));

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            

            //comparison operator using boolean for true or false
            bool salary = annualSalary1 > annualSalary2;
            Console.WriteLine(salary);


            Console.ReadLine();
        }
    }
}
