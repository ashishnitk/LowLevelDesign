using System;
using System.Collections.Generic;

namespace Library
{

    public abstract class LibraryItem
    {
        private int numCopies;

        public int NumCopies
        {
            get { return numCopies; }
            set { numCopies = value; }
        }
        public abstract void Display();

    }

    internal class Book : LibraryItem
    {
        private string author;
        private string title;
        public Book(string author, string title, int numCopies)
        {
            this.author = author;
            this.title = title;
            this.NumCopies = numCopies;
        }
        public override void Display()
        {
            System.Console.WriteLine("Book: ", author);
            System.Console.WriteLine("title: ", title);
            System.Console.WriteLine("NumCopies: ", NumCopies);
        }
    }

    


   
}