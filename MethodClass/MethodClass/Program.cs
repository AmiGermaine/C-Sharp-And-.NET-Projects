using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling function
            Operator1 op1 = new Operator1();  //Instantiate
            op1.sum(50, 20); //math operation
            op1.sum1(numberTwo:10);

            Console.ReadLine();
        }
    }
}
