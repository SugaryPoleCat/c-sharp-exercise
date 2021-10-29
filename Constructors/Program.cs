using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // if you dont have a consturcor in class
            // it will just call the class.
            // but if you have constructor, it will call a constructor.
            // if you odnt have a constructor, you cant pass anything in the ( );
            Book book1 = new Book("50 shades of blue", "Grace", 400);

            Console.WriteLine(book1);

            Book book2 = new Book("Down Below", "Kyle", 800);

            Console.WriteLine(book2);

            book2.title = "Kyle's Grace";
            Console.WriteLine(book2);

            Console.ReadLine();
        }
    }
}
