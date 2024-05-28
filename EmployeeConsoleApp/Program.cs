using EmployeeConsoleApp;

EmployeeManagement employeeManagement = new EmployeeManagement();
bool running = true;

while (running){
    Console.WriteLine("\nEmployee Management System");
    Console.WriteLine("1. Add Employee");
    Console.WriteLine("2. List Employees");
    Console.WriteLine("3. Update Employee");
    Console.WriteLine("4. Delete Employee");
    Console.WriteLine("5. Exit");
    Console.Write("Choose an option: ");
    string choice = Console.ReadLine();

    switch (choice){
        case "1":
            AddEmployee(employeeManagement);
            break;
        case "2":
            employeeManagement.ListEmployees();
            break;
        case "3":
            UpdateEmployee(employeeManagement);
            break;
        case "4":
            DeleteEmployee(employeeManagement);
            break;
        case "5":
            running = false;
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}


static void AddEmployee(EmployeeManagement employeeManagement){
    Console.Write("Enter first name: ");
    string firstName = Console.ReadLine();
    Console.Write("Enter last name: ");
    string lastName = Console.ReadLine();
    Console.Write("Enter employee ID: ");
    string employeeID = Console.ReadLine();
    Console.Write("Enter position: ");
    string position = Console.ReadLine();
    Console.Write("Enter salary: ");
    double salary = double.Parse(Console.ReadLine());

    Employee employee = new Employee(firstName, lastName, employeeID, position, salary);
    employeeManagement.AddEmployee(employee);
}

static void UpdateEmployee(EmployeeManagement employeeManagement){
    Console.Write("Enter employee ID to update: ");
    string employeeID = Console.ReadLine();
    Console.Write("Enter new position: ");
    string newPosition = Console.ReadLine();
    Console.Write("Enter new salary: ");
    double newSalary = double.Parse(Console.ReadLine());

    employeeManagement.UpdateEmployee(employeeID, newPosition, newSalary);
}

static void DeleteEmployee(EmployeeManagement employeeManagement){
    Console.Write("Enter employee ID to delete: ");
    string employeeID = Console.ReadLine();
    employeeManagement.RemoveEmployee(employeeID);
}