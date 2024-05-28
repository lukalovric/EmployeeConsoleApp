using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleApp
{
    public class Manager : Employee
    {
        public List<Employee> Team { get; set; }

        public Manager(string firstName, string lastName, string employeeID, string position, double salary)
            : base(firstName, lastName, employeeID, position, salary)
        {
            Team = new List<Employee>();
        }

        public void AddTeamMember(Employee employee)
        {
            Team.Add(employee);
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Manages {Team.Count} employees.");
        }
    }

}
