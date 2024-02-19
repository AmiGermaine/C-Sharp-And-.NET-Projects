using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now; //current date and time
            Console.WriteLine(now);
            Console.WriteLine("Please, enter a number?"); //user input
            int numEnter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2} ", now, numEnter, now.AddHours(numEnter));  //Prints to the console the exact time it will be in X hours, X being the number the user entered

            Console.ReadLine();
        }
    }
}
