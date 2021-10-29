using System;

namespace GuessingGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string toGuess = "Cukier";
            string guess = "";
            int tries = 0;
            int limit = 3;
            bool oog = false;

            while (guess != toGuess && !oog)
            {
                if (tries < limit)
                {
                    Console.Write("Guess the word: ");
                    guess = Console.ReadLine();
                    tries++;
                } else
                {
                    oog = true;
                }
            }
            switch (oog) {
                case true:
                    Console.WriteLine("You lose!");
                    break;
                default:
                    Console.WriteLine("You win!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
