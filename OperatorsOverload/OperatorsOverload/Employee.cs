using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverload
{
    public class Employee      //creating a class with three properties
    {
        public int Id;
        public string FirstName;
        public string LastName;

        public static bool operator== (Employee employee, Employee employee2) //using bool for the comparision of employee ID property
        {
            return employee.Id == employee2.Id;
        }
        public static bool operator!= (Employee employee, Employee employee2)
        {
            return employee.Id != employee2.Id;
        }
    }
}
