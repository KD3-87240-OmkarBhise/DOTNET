using ConsoleApp_Question1;

namespace ConsoleApp_Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CreateArray();
        }

        static void CreateArray()
        {
            Console.WriteLine("Enter the no. of students: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Student[] students = new Student[num];
            AcceptInfo(students);
        }

        static void AcceptInfo(Student[] students)
        {
          
            for (int i = 0; i < students.Length; i++)
            {
                students[i].AcceptDetails();
            }
            Console.WriteLine();
            PrintInfo(students);
        }

        static void PrintInfo(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                students[i].PrintDetails();
            }
            ReverseArray(students);
        }

        static void ReverseArray(Student[] students)
        {
            for (int i = students.Length - 1; i >= 0; i--)
            {
                students[i].PrintDetails();
                
            }

        }

   

    }
}
