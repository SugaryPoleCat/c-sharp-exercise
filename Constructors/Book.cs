using System;

namespace Constructors
{
    class Book
    {
        // public things are accessible by OTHER classes in project.
        public string title;
        public string author;
        public int pages;

        // this is a constructor
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

        // cna have multiple constructors with multiple names that get multiple things.
        public Book()
        {
            Console.WriteLine("Creating book...");
        }
    }
}
