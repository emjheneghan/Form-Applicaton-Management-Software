// Student: Emma Jane Heneghan
// Student Number: 10204278

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    class Employee : Person
    {
        // properties
        public string Salary { get; set; }

        // constructor
        public Employee(string name, string phone, string email, string salary)
            : base(name, phone, email)
        {
            Salary = salary;
        }
    }
}
