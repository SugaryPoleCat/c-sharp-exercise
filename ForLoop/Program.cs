using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] things = { 545, 488, 55, 54, 5, 54515, 54 };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            foreach (int dat in things)
            {
                Console.WriteLine(dat);
            }
            Console.ReadLine();
        }
    }
}
