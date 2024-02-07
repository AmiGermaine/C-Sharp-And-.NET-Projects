using CallingMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:"); //user input
            int x = Convert.ToInt32(Console.ReadLine());

            int result = Operator.Add(x); 
            Console.WriteLine(result);

            int resulttwo = Operator.Subtract(x);
            Console.WriteLine(resulttwo); //ths will print the result of the subtraction operator

            int result3 = Operator.Divide(x);
            Console.WriteLine(result3);

            Console.ReadLine();        
        }
    }
}
