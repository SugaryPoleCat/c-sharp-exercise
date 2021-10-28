using System;

namespace CSBasics
{
    class Arrays
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 1, 2, 3, 5, 8, 13, 27 };

            // prints the number at index [];
            Console.WriteLine(luckyNumbers[1]);

            luckyNumbers[1] = 666;

            Console.WriteLine(luckyNumbers[1]);

            // sometimes you dont know the names/numbers.
            // the problem is you need to tell the array how big its gonna be.
            string[] friends = new string[5];

            friends[0] = "Frank";
            friends[1] = "Kate";
            friends[2] = "Pooper";
            friends[3] = "Peter";
            friends[4] = "jorge";
            friends[5] = "aAsd";

            Console.ReadLine();
        }
    }
}
