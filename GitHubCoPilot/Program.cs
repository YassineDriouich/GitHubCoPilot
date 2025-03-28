using System;

namespace GitHubCoPilot
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            Console.WriteLine("Addition: " + Add(a, b));
            Console.WriteLine("Subtraction: " + Subtract(a, b));
            Console.WriteLine("Multiplication: " + Multiply(a, b));
            Console.WriteLine("Division: " + Divide(a, b));
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static double Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return (double)x / y;
        }
    }
}
