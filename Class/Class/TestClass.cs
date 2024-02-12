using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class TestClass
    {
        public void Math(int number, out int result)
        {
            result = number / 2;
        }
        public void Math(int number, int dividebytwo, out int result) //Overload method.
        {
            result = number / dividebytwo;
            
        }

    }
}
