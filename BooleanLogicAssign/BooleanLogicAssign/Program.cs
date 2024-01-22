using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            int yourAge = 15, speedTicket = 3;
            bool DUI = false;

            Console.WriteLine("What is your age?");
            yourAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");//True or False input
            DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            speedTicket = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            bool result = yourAge >= 15 && !DUI && speedTicket <= 3;
            bool yesno = Convert.ToBoolean(result);

            Console.ReadLine();             
        }
    }
}
