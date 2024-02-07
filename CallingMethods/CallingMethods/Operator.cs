using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public static class Operator //creating a class call operator with three methods that will do some math operation.
    {
        public static int Add(int x)  //First method to be call 
        {
            return x + 4;  //returns data back when the Add method is invoked
        }

        public static int Subtract(int x)  //Secong method to be call
        {
            return  x - 3;
        }

        public static int Divide(int x) //last method to be call
        {
            return x / 2;
        }
        //public int data {  get; set; }
        
    }
}
