using System;

namespace ExponentMethod
{
    class Program
    {
        // exponent method : pass in 2 numbers, a base and power and return the base to the power of pownum;
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;
            for (int x = 0; x < powNum; x++)
            {
                result *= baseNum;
            }
            return result;
        }
        // this is a method, aka FUNCTION
        static void Main(string[] args)
        {
            Console.Write("Basenum: ");
            int baseNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("PowNum: ");
            int powNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The power of basenum: " + GetPow(baseNum, powNum));
            Console.WriteLine("you could have used Math.Pow instead.");
            Console.ReadLine();
        }
    }
}
