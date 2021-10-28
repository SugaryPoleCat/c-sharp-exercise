using System;

namespace Methods
{
    class Program
    {
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + "/nYou are: " + age);
        }
        // this is a method!
        static void Main(string[] args)
        {
            // call the method SayHi
            Console.Write("Your name: ");
            string name = Console.ReadLine();
            Console.Write("Your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            SayHi(name, age);

            // exercise: make it print out your name;
            // based on what you learned in MadLib, CSHarpBasics, Calculator.
            // You need: a string. 

            // MAKE SOMETHING LKE THAT FOR SEB
            // what i need to do is make a repo, where he can do that .
            Console.ReadLine();
        }
    }
}
