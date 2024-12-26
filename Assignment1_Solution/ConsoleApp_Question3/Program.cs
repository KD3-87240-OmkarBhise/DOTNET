namespace ConsoleApp_Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("1) ADD");
                Console.WriteLine("2) SUB");
                Console.WriteLine("3) MUL");
                Console.WriteLine("4) DIV");
                Console.WriteLine("0) Exit");
                Console.WriteLine("Enter Your Choice: ");
                choice = int.Parse(Console.ReadLine());
                double num1 =0;
                double num2 =0;
                if (choice != 0)
                {
                    Console.WriteLine("Enter Two Numbers: ");
                    num1 = double.Parse(Console.ReadLine());
                    num2 = double.Parse(Console.ReadLine());
                }


                switch (choice)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Result: " + (num1+num2));
                        break;
                    case 2:
                        Console.WriteLine("Result: " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Result: " + (num1 * num2));
                        break;
                    case 4:
                        if (num2 == 0) Console.WriteLine("Dived by zero not allowed!");
                        else Console.WriteLine("Result: " + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("Wrong Choice Entered!");
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
