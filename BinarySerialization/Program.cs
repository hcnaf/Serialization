using BinarySerialization.Models;

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

BinarySerializeHelper.Serialize(department, FilePath(department.DepartmentName));

var department1 = (Department)BinarySerializeHelper.Desirialize(FilePath("Managers"));

Console.WriteLine(department1);

string FilePath(string fileName) => @$"..\..\..\Serialized\{fileName}.data";