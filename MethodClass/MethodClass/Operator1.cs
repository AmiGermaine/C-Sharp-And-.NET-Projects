using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    public class Operator1
    {
        public void sum(int numberOne, int numberTwo) // creating a void method that takes two integers as parameters.
        {
            int result = numberOne - numberTwo; //do math on the first integer

            Console.WriteLine(numberTwo); //display the second integer to the screen 
        }
        //public void sum(int numberTwo)
        //{
        //    Console.WriteLine(numberTwo);
        //}
    }
}
