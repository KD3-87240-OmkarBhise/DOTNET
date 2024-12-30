using System.Data;

namespace ConsoleApp_Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.AcceptDetails();
            student.PrintDetails();
            
        }

        
    }

    public struct Student
    {
        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;


        string Name
        {
            get { return name; }
            set { name = value; }
        }

        bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        int Age
        {
            get { return age; }
            set { age = value; }
        }

        int Std
        {
            get { return std; }
            set { std = value; }
        }

        char Div
        {
            get { return div; }
            set { div = value; }
        }

        double Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Name: ");
            this.Name = Console.ReadLine();

            Console.WriteLine("Enter Gender: ");
            this.Gender = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter Age: ");
            this.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Std: ");
            this.Std = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Div: ");
            this.Div = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter Marks: ");
            this.Marks = Convert.ToDouble(Console.ReadLine());
        }

        public void PrintDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Students data: ");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Gender: " + (this.gender ? "Male" : "Female"));
            Console.WriteLine("Age: " + this.Age);
            Console.WriteLine("Std: " + this.Std);
            Console.WriteLine("Div: " + this.Div);
            Console.WriteLine("Marks: " + this.Marks);
        }

    }
}
