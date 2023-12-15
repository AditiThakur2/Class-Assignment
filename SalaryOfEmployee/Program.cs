using SalaryOfEmployee;

Employee employee = new Employee(1, "John Doe", 50000, new DateTime(1990, 1, 1));
Console.WriteLine($"Employee Salary: {employee.ComputeSalary()}");
Manager manager = new Manager(2, "Jane Smith", 80000, new DateTime(1985, 5, 10), 5000, 10000);
Console.WriteLine($"Manager Salary: {manager.ComputeSalary()}");
