using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {

            Operation operation = new Operation(); //Instantiate

            Console.WriteLine("Please enter a number:"); //user input
            int x = Convert.ToInt32(Console.ReadLine());

            try  //Try/Catch exception for when a user choose to not input a second number for the method
            {
                Console.WriteLine("Please enter another number or not(Optional):"); //user input with an option not to input any number
                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(operation.AddNum(x, y));

            }
            catch
            {
                Console.WriteLine(operation.AddNum(x));
            }


            Console.ReadLine();
        }
    }
}
