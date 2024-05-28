using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleApp
{
    public class EmployeeManagement
    {
        private List<Employee> employees;

        public EmployeeManagement()
        {
            employees = new List<Employee>();
        }

        // Create
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            Console.WriteLine($"Added {employee.FirstName} {employee.LastName}");
        }

        // Read
        public Employee GetEmployee(string employeeID)
        {
            return employees.FirstOrDefault(e => e.EmployeeID == employeeID);
        }

        public void ListEmployees()
        {
            Console.WriteLine("Listing all employees:");
            foreach (var employee in employees)
            {
                employee.DisplayInfo();
            }
        }

        // Update
        public void UpdateEmployee(string employeeID, string newPosition, double newSalary)
        {
            var employee = GetEmployee(employeeID);
            if (employee != null)
            {
                employee.Position = newPosition;
                employee.Salary = newSalary;
                Console.WriteLine($"Updated {employee.FirstName} {employee.LastName}");
            }
            else
            {
                Console.WriteLine("Employee not found");
            }
        }

        // Delete
        public void RemoveEmployee(string employeeID)
        {
            var employee = GetEmployee(employeeID);
            if (employee != null)
            {
                employees.Remove(employee);
                Console.WriteLine($"Removed {employee.FirstName} {employee.LastName}");
            }
            else
            {
                Console.WriteLine("Employee not found");
            }
        }
    }

}
