using AttributesLib;
namespace EntityLib
{
    [DataTable("Employee")]
    public class Employee
    {
        [KeyColumn]
        [DataColumn("EmpNo")]
        public int EmpNo { get; set; }

        [DataColumn("Name")]
        public string Name { get; set; }

        [DataColumn("Address")]
        public string Address { get; set; }

        [DataColumn("Salary")]
        public decimal Salary { get; set; }

        [UnMapped]
        public decimal AnnualSalary { get; set; }

        [DataColumn("Designation")]
        public string Designation { get; set; }
    }

    [DataTable("Student")]
    public class Student
    {
        [KeyColumn]
        [DataColumn("RollNo")]
        public int RollNo { get; set; }

        [DataColumn("Name")]
        public string Name { get; set; }

        [DataColumn("Address")]
        public string Address { get; set; }

        [DataColumn("Course")]
        public string Course { get; set; }
    }
}
