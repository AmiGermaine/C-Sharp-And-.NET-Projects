using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:"); //user input
            int y = Convert.ToInt32(Console.ReadLine());

            Equation equation = new Equation();  //Instantiate
            Console.WriteLine(equation.Multiply(y));

            Console.WriteLine(equation.Multiply(7.3m)); //pasing decimal 

            Console.WriteLine(equation.Multiply("4")); //passing in a string that equates to an integer


            Console.ReadLine();
        }
    }
}
