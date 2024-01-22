using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yourAge = 15, speedTicket = 3; //qualification rules to detemine
                                              //if the applicant qualifies for car insurance
            bool DUI = false; 

            Console.WriteLine("What is your age?");
            yourAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");//True or False input
            DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            speedTicket = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?"); //multiple Uses of Boolean logic AND(&&)
            Console.WriteLine(yourAge > 15 && speedTicket <= 3 && !DUI);

            Console.ReadLine();
        }
    }
}
