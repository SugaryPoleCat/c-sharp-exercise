using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // doesnt work with decimals becasue we convert to INT.
            // so now i converted it to double
            // now we can work with decimals
            Console.Write("Enter number A: ");
            double numberA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number B: ");
            double numberB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(numberA + numberB);
            Console.ReadLine();
        }
    }
}
