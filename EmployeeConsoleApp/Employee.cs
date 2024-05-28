using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleApp
{
    public class Employee : Person
    {
        public string EmployeeID { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        public Employee(string firstName, string lastName, string employeeID, string position, double salary)
            : base(firstName, lastName)
        {
            EmployeeID = employeeID;
            Position = position;
            Salary = salary;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Employee: {FirstName} {LastName}, ID: {EmployeeID}, Position: {Position}, Salary: {Salary:C}");
        }
    }

}
