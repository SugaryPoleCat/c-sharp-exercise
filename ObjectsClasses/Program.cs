using System;

namespace ObjectsClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // how to call the Boook class and use it.
            // this is what we call, an object.
            Book book1 = new Book();

            book1.title = "Poop";
            book1.author = "me";
            book1.pages = 400;

            // you can print out the entire object
            Console.WriteLine(book1);

            // or specific thing.
            Console.WriteLine(book1.author);

            Book book2 = new Book();

            book2.title = "Shit";
            book2.author = "You";
            book2.pages = 700;

            Console.WriteLine(book2);

            Console.ReadLine();
        }
    }
}
