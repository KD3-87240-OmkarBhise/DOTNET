namespace _01DemoBasics
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            #region Call getter and setter in C# Way
            Person person = new Person();
            person.Name = "omkar";
            Console.WriteLine(person.Name);
            #endregion

            #region Person, Employee class / Inheritance;
            Person person1 = new Person();
            person1.Id = 11;
            person1.Name = "omkar";
            person1.Address = "karad";

            string details = person1.GetDetails();
            Console.WriteLine(details);

            Employee employee = new Employee();
            employee.Name = "Omkar";
            employee.Address = "Karad";
            employee.Id = 12;
            employee.DName = "IT";
            string details1 = employee.GetDetails();
            Console.WriteLine(details1);
            #endregion


            #region value type, preference type and primitives
            int i = 100;
            Student s;
            s.Id = 10;
            s.Name = "omkar";
            string s0 = "abcd";
           // String s1 = new String(new char['a', 'b']);
            String s1 = new String(new char[] {'a', 'b', 'c', 'd'});
            #endregion

            #region
            Employee employee1 = new Employee(14, "Rohit", "Mumbai", "HR");
            Console.WriteLine(employee1.GetDetails());

            Console.ReadLine(); 
            #endregion

        }
    }

    public struct Student
    {
        public int Id;
        public string Name;
    }
    public class Person
    {
        private int _Id;
        private string _Name;
        private string _Address;

        public String Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public Person()
        {
            Id = 0;           
            Name = "";
            Address = "";
        }

        public virtual string GetDetails()
        {
            return Id + Name + Address;

        }
    }

    public class Employee : Person
    {
        public Employee()
        {
            Id = 10;
            Name = "Sachin";
            Address = "Mumbai";
            DName = "IT";
        }

        public Employee(int id, string name, string address, string dname)
        {
            Id = id;
            Name = name;
            Address = address;
            DName = dname;
        }

        private string _DName;

        public string DName
        {
            get { return _DName; }
            set { _DName = value; }
        }

        public override string GetDetails()
        {
            return base.GetDetails() + DName;
        }

    }
}
