﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { FirstName = "Jelly", LastName = "Bean" };
                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }            
        }
    }
}
