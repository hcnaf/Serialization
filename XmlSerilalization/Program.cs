using XmlSerialization.Models;
using XmlSerilalization;

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

XmlSerializeHelper.Serialize(typeof(Department), department, FilePath(department.DepartmentName));

var department1 = (Department)XmlSerializeHelper.Deserialize(typeof(Department), FilePath("Managers"));

Console.WriteLine(department1);

string FilePath(string fileName) => @$"..\..\..\Serialized\{fileName}.xml";