using System;

namespace GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            // rating is only: G, PG, PG-13, M
            Movie avengers = new Movie("The avengers", "Poopster", "PG-13");
            Movie shrek = new Movie("Shrek", "cock", "pg-18");

            Console.WriteLine(avengers);
            Console.WriteLine(shrek);

            // cant access raitng becasue its private;
            // Console.WriteLine(avengers.rating);
            // thats why you need getters and setters.

            shrek.Rating = "R";
            Console.WriteLine(shrek);

            Console.ReadLine();
        }
    }
}
