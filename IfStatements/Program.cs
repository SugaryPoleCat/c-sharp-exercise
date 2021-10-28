using System;

namespace IfStatements
{
    class Program
    {
        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }


            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Number a: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number b: ");
            int numberB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number c: ");
            int numberC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetMax(numberA, numberB, numberC));

            // this will be exercise for seb.
            // Get input from user, print out result like: if numberA biggerand such blablabala.
            Console.ReadLine();
        }
    }
}
