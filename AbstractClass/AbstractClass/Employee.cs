using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person // Child class inherited from the Person class
    {
        public override void SayName() // executing the SayName() method inside of the Employee class.
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
