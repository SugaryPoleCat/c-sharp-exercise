using System;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            // we let user pick to change RED, BLUE and YOU.
            // neeed to store 3 variables;
            // Console.WriteLine("Roses are red");
            // Console.WriteLine("Violets are blue");
            // Console.WriteLine("I love you");

            string color, pluralNoun, celebrity;
            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);

            Console.ReadLine();
        }
    }
}
