namespace ConsoleApp_Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            switch (args[2])
            {
                case "+": 
                   Console.WriteLine(int.Parse(args[0]) + int.Parse(args[1]));
                    break;
                case "-":
                    Console.WriteLine(int.Parse(args[0]) - int.Parse(args[1]));
                    break;
                case "*":
                    Console.WriteLine(int.Parse(args[0]) * int.Parse(args[1]));
                    break;
                case "/":
                    Console.WriteLine(int.Parse(args[0]) / int.Parse(args[1]));
                    break;
            }
        }
    }
}
