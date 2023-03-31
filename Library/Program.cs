using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Wren & Martin", "asdashdjg", 10 );
            book.Display();

            Video video = new Video("Avcii", "ajsdhks", 10, 45);
            Video linkin = new Video("LinkingPark", "ajsdhks", 10, 50);
            video.Display();

            Console.WriteLine("Making the Video borrowable");

            Borrowable borrowable = new Borrowable(video);

            borrowable.BorrowItem("Amit");
            borrowable.BorrowItem("Gyan");
            borrowable.Display();

            Console.WriteLine("Hello World!");
        }
    }
}
