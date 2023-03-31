using Library;
using System;
using System.Collections.Generic;

namespace Library
{
    public abstract class Decorator : LibraryItem
    {

        protected LibraryItem libraryItem;

        public Decorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        public override void Display()
        {
            libraryItem.Display();
        }
    }

    public class Borrowable : Operations
    {
        protected readonly List<string> borrowers = new List<string>();

        public Borrowable(LibraryItem libraryItem) : base(libraryItem)
        {

        }

        internal void BorrowItem(string name)
        {
            borrowers.Add(name);
            libraryItem.NumCopies--;
        }

        internal void ReturnItem(string name)
        {
            borrowers.Remove(name);
            libraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();
            foreach (var item in borrowers)
            {
                Console.WriteLine("Borrower: " + item);
            }
        }

    }
}