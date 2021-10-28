using System;

namespace BetterCalculator
{
    class Program
    {
        static void calculate(double num1, double num2, string op)
        {
            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 + num2);
            }
            else
            {
                Console.WriteLine("invalid operator");
            }
        }
        static void Main(string[] args)
        {
            double numberA, numberB;
            // get all information from the user;
            Console.Write("Enter numberA: ");
            numberA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter numberB: ");
            numberB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operator: ");
            string op = Console.ReadLine();

            calculate(numberA, numberB, op);
            // exercise:
            // do this in a method.
            Console.ReadLine();
        }
    }
}
