using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
     public class Equation //
    {
        public int Multiply(int y)  //first method that take in an integer
        {
            return y * 5;
        }

        public decimal Multiply(decimal z) // second method that take in  a decimal
        {
            return z * 6;
        }

        public int Multiply(string id) //third method using  string that get to convert to an integer
        {
            int num = Convert.ToInt32(id);
            return num * 7;
        }
    }
}
