using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMORPHISM
{
    class Employee : IQuittable  //Employee class with an inherit interface that implement Quit() method 
    {
        public void Quit()
        {
            Console.WriteLine("I'm quitting");
        }
    }
}
