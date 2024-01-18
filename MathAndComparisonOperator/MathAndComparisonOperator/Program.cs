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
            Console.WriteLine("Hourly Rate");
            int pay = 21;
            Console.WriteLine(pay);
            Console.WriteLine("Hours worked per week?");
            int hoursWorked = 40;
            Console.WriteLine(hoursWorked);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            int pays = 25;
            Console.WriteLine(pays);
            Console.WriteLine("Hours worked per week?");
            int hourWorked = 40;
            Console.WriteLine(hourWorked);

            Console.WriteLine("Annual salary of Person 1:");
            decimal annualSalary = 45450m;
            Console.WriteLine(annualSalary);
            Console.WriteLine("Annual salary of Person 2:");
            decimal AnnualSalary = 50500m;
            Console.WriteLine(AnnualSalary);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            int person1Salary = 45450;
            int person2Salary = 50500;

            //comparison operator using boolean for true or false
            bool salary = person1Salary > person2Salary;
            Console.WriteLine(salary);


            Console.ReadLine();
        }
    }
}
