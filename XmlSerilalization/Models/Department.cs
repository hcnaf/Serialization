#pragma warning disable

using System.Xml.Serialization;

namespace XmlSerialization.Models
{
    [Serializable]
    public class Department
    {
        [XmlElement(ElementName = "Department")]
        public string DepartmentName { get; set; }

        [XmlArray("ListOfEmployeesInDepartment")]
        [XmlArrayItem("EmployeeName")]
        public List<Employee> Employees { get; set; }

        public override string ToString() => "Employees in " + DepartmentName + ": " + string.Join(", " ,Employees.Select(x => x.EmployeeName));
    }
}
