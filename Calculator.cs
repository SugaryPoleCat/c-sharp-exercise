using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number B: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            // doesnt work with decimals becasue we convert to INT.
            Console.WriteLine(numberA + numberB);
            Console.ReadLine();
        }
    }
}
