using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person   //an abstract class called Person with two properties
    {
        public string firstName;
        public string lastName;
        public abstract void SayName();  //person method
    }
}
