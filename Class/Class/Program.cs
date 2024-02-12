using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            TestClass testClass = new TestClass();  //Instantiate

            Console.WriteLine("Please enter a number: "); //user input
            int number = Convert.ToInt32(Console.ReadLine());

            testClass.Math(number, out int result); //the method that get call

            Console.WriteLine(result); //output




            Console.ReadLine();
        }
    }
}
