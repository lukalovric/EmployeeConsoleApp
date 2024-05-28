using EmployeeConsoleApp;

EmployeeManagement employeeManagement = new EmployeeManagement();

// Creating employees
Employee emp1 = new Employee("John", "Doe", "E001", "Software Developer", 60000);
Employee emp2 = new Employee("Jane", "Smith", "E002", "QA Engineer", 55000);

// Adding employees
employeeManagement.AddEmployee(emp1);
employeeManagement.AddEmployee(emp2);

// Listing employees
employeeManagement.ListEmployees();

// Updating an employee
Console.WriteLine("\nUpdating John Doe's position and salary...");
employeeManagement.UpdateEmployee("E001", "Senior Software Developer", 70000);

// Listing employees after update
employeeManagement.ListEmployees();

// Removing an employee
Console.WriteLine("\nRemoving Jane Smith...");
employeeManagement.RemoveEmployee("E002");

// Listing employees after removal
employeeManagement.ListEmployees();