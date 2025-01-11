using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public Date() { }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public void AcceptDate()
        {
            Console.Write("Enter Day: ");
            Day = int.Parse(Console.ReadLine());
            Console.Write("Enter Month: ");
            Month = int.Parse(Console.ReadLine());
            Console.Write("Enter Year: ");
            Year = int.Parse(Console.ReadLine());
        }

        public void PrintDate() => Console.WriteLine(ToString());

        public bool IsValid()
        {
            if (Month < 1 || Month > 12 || Day < 1 || Day > 31)
                return false;

            if (Month == 2 && (Day > 29 || (Day == 29 && !IsLeapYear(Year))))
                return false;

            if ((Month == 4 || Month == 6 || Month == 9 || Month == 11) && Day > 30)
                return false;

            return true;
        }

        private bool IsLeapYear(int year) => (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

        public override string ToString() => $"{Day:D2}/{Month:D2}/{Year}";

        public static int DifferenceInYears(Date d1, Date d2)
        {
            return Math.Abs(d1.Year - d2.Year);
        }

        public static int operator -(Date d1, Date d2)
        {
            return DifferenceInYears(d1, d2);
        }
    }

    public class EmployeeLib
    {
        public string Name { get; set; }
        public bool Gender { get; set; }
        public Date Birth { get; set; } = new Date();
        public string Address { get; set; }

        public int Age => DateTime.Now.Year - Birth.Year;

        public EmployeeLib() { }

        public EmployeeLib(string name, bool gender, Date birth, string address)
        {
            Name = name;
            Gender = gender;
            Birth = birth;
            Address = address;
        }

        public virtual void Accept()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Gender (M/F): ");
            Gender = Console.ReadLine().ToUpper() == "M";
            Console.WriteLine("Enter Birth Date:");
            Birth.AcceptDate();
            Console.Write("Enter Address: ");
            Address = Console.ReadLine();
        }

        public virtual void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString() => $"Name: {Name}, Gender: {(Gender ? "Male" : "Female")}, Birth: {Birth}, Address: {Address}, Age: {Age}";
    }

    public class Employee : EmployeeLib
    {
        private static int _counter = 1;
        public int Id { get; private set; }
        public double Salary { get; set; }
        public string Designation { get; protected set; }
        public DepartmentType Dept { get; set; }

        public Employee() { Id = _counter++; }

        public Employee(string name, bool gender, Date birth, string address, double salary, DepartmentType dept)
            : base(name, gender, birth, address)
        {
            Id = _counter++;
            Salary = salary;
            Dept = dept;
        }

        public override void Accept()
        {
            base.Accept();
            Console.Write("Enter Salary: ");
            Salary = double.Parse(Console.ReadLine());
            Console.Write("Enter Department (e.g., HR, IT, Finance): ");
            Dept = (DepartmentType)Enum.Parse(typeof(DepartmentType), Console.ReadLine(), true);
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString() => $"{base.ToString()}, ID: {Id}, Salary: {Salary}, Designation: {Designation}, Department: {Dept}";
    }

    public class Manager : Employee
    {
        public double Bonus { get; set; }

        public Manager()
        {
            Designation = "Manager";
        }

        public override void Accept()
        {
            base.Accept();
            Console.Write("Enter Bonus: ");
            Bonus = double.Parse(Console.ReadLine());
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString() => $"{base.ToString()}, Bonus: {Bonus}";
    }

    public class Supervisor : Employee
    {
        public int Subordinates { get; set; }

        public Supervisor()
        {
            Designation = "Supervisor";
        }

        public override void Accept()
        {
            base.Accept();
            Console.Write("Enter Number of Subordinates: ");
            Subordinates = int.Parse(Console.ReadLine());
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString() => $"{base.ToString()}, Subordinates: {Subordinates}";
    }

    public class WageEmp : Employee
    {
        public int Hours { get; set; }
        public int Rate { get; set; }

        public WageEmp()
        {
            Designation = "Wage";
        }

        public override void Accept()
        {
            base.Accept();
            Console.Write("Enter Hours Worked: ");
            Hours = int.Parse(Console.ReadLine());
            Console.Write("Enter Rate per Hour: ");
            Rate = int.Parse(Console.ReadLine());
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString() => $"{base.ToString()}, Hours: {Hours}, Rate: {Rate}";
    }

    public enum DepartmentType
    {
        HR,
        IT,
        Finance,
        Operations,
        Marketing
    }
}
