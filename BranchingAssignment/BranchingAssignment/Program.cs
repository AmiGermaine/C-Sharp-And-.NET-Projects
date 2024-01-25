using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packageWeight = 50;
            //float height, width, length;

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int Weight = Convert.ToInt32(Console.ReadLine());

            if (Weight > packageWeight) //if/else condition to check if the weight is greater than the required package weight
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day."); //program will end if the condition is true and if it's false the program will move to the Else statement below. 
            }

            else
            {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());
                int totalDimension = width + height + length;

                if (totalDimension > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    int quote = (height * width * length) * Weight / 100; //Calculation for all the dimensions of the package
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                }
            }
            Console.WriteLine("Thank you!");

            Console.ReadLine();
        }
    }
}
