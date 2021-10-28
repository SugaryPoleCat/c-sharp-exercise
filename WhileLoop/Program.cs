using System;
using System.Threading;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
                Thread.Sleep(1000);
            }
            int index2 = 1;
            do
            {
                Console.WriteLine(index2);
                index2++;
                Thread.Sleep(1000);
            } while (index2 <= 5);

            Console.ReadLine();
        }
    }
}
