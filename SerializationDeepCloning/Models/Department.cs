#pragma warning disable

namespace SerializationDeepCloning.Models
{
    [Serializable]
    public class Department
    {
        public string DepartmentName { get; set; }
        public IList<Employee> Employees { get; set; }

        public override string ToString() => "Employees in " + DepartmentName + ": " + string.Join(", " ,Employees.Select(x => x.EmployeeName));
    }
}
