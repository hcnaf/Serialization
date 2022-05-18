using SerializationDeepCloning;
using SerializationDeepCloning.Models;

var department = new Department
{
    DepartmentName = "Managers",
    Employees = new List<Employee>
    {
        new() { EmployeeName = "Bill" },
        new() { EmployeeName = "Steven" },
        new() { EmployeeName = "John" },
    }
};

var copy = CloneHelper.Clone<Department>(department);

Console.WriteLine(department);
Console.WriteLine(copy);
department.DepartmentName = "NotManagers";
department.Employees[1].EmployeeName = "NotSteven";
Console.WriteLine(department);
Console.WriteLine(copy);