using System;

namespace StaticClassesMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day");
            holiday.Duration = 300;

            Song kashmir = new Song("Kashmir", "Led Zeppelin", 500);

            Console.WriteLine(holiday);
            Console.WriteLine(kashmir);

            Console.WriteLine(Song.songCount);


            // static class methods dont need to be initialised like the songs above.
            UsefulTools.SayHi("Mike");
            Console.ReadLine();
        }
    }
}
