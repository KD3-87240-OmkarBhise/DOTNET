using EmployeeLib;
namespace HRMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Create Manager");
            Console.WriteLine("2. Create Supervisor");
            Console.WriteLine("3. Create Wage Employee");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Manager manager = new Manager();
                    Console.WriteLine("Enter Manager Details:");
                    manager.Accept();
                    Console.WriteLine("Manager Details:");
                    manager.Print();
                    break;

                case 2:
                    Supervisor supervisor = new Supervisor();
                    Console.WriteLine("Enter Supervisor Details:");
                    supervisor.Accept();
                    Console.WriteLine("Supervisor Details:");
                    supervisor.Print();
                    break;

                case 3:
                    WageEmp wageEmp = new WageEmp();
                    Console.WriteLine("Enter Wage Employee Details:");
                    wageEmp.Accept();
                    Console.WriteLine("Wage Employee Details:");
                    wageEmp.Print();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Exiting.");
                    break;
            }
        }
    }
}
