using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucial_CS
{
    internal class Employee
    {
        public static string NewEmployee;
        public static int EmployeeCounter;

        public string Id;
        public string Name;

        public Employee(string name, string id)
        { 
            Name = name;
            Id = id;
            ++EmployeeCounter;
        }

        public static void AssignNewEmployee(string newEmployee)
        { 
            NewEmployee = newEmployee;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine($"{Name}: {Id}");
        }
    }
}
