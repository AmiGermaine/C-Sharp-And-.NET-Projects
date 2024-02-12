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
            op1.sum(50, 30); //math operation
            op1.sum(numberTwo:20, numberOne:10); // specifying parameters by name

            Console.ReadLine();
        }
    }
}
