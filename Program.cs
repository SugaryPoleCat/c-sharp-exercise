using System;

namespace CSharp_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "";
            int characterAge;
            characterAge = 35;

            // concat the string
            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);
            Console.WriteLine("Hello World!");
        }
    }
}
