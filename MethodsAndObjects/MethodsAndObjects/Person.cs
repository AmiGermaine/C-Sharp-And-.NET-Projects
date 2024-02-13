using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person  //parent class
    {
        public string firstName; 
        public string lastName; 
        public void SayName()  //person method
        {
            Console.WriteLine("Name:" + firstName + " " + lastName);
        }
    }
}
