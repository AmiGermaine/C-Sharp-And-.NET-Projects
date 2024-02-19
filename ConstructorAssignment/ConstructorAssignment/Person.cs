using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Person
    {
        //Create a class constructor with two parameters

        public string name;
        public int id;

        public Person()
        {

        }
        public Person(string employeeName, int Id)
        {
            
        }
        public Person(string name) : this(name, 1234)
        {
            this.name = name;
        }
        public Person(int id)
        {
            this.id = id;
        }        
    }
}
