using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Sum");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());

            try
            {
                // Load the MathsLib assembly dynamically
                Assembly mathsLibAssembly = Assembly.Load("MathsLib");
                Type mathsType = mathsLibAssembly.GetType("MathsLib.Maths");

                if (mathsType == null)
                {
                    Console.WriteLine("Maths class not found in the MathsLib assembly.");
                    return;
                }

                // Create an instance of the Maths class
                object mathsInstance = Activator.CreateInstance(mathsType);

                // Determine the method name based on the user's choice
                string methodName;
                switch (choice)
                {
                    case 1:
                        methodName = "Sum";
                        break;
                    case 2:
                        methodName = "Subtract";
                        break;
                    case 3:
                        methodName = "Multiply";
                        break;
                    case 4:
                        methodName = "Divide";
                        break;
                    default:
                        throw new ArgumentException("Invalid choice.");
                }

                // Get the method using reflection
                MethodInfo methodInfo = mathsType.GetMethod(methodName);

                if (methodInfo == null)
                {
                    Console.WriteLine($"Method {methodName} not found in the Maths class.");
                    return;
                }

                // Invoke the method
                object result = methodInfo.Invoke(mathsInstance, new object[] { num1, num2 });

                Console.WriteLine($"Result of {methodName}: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
