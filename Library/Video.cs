namespace Library
{
    internal class Video : LibraryItem
    {
        private string director;
        private string title;
        private int playtime;


        public Video(string director, string title, int numOfCopies, int playtime)
        {
            this.director = director;
            this.title = title;
            this.NumCopies = numOfCopies;
            this.playtime = playtime;
        }

        public override void Display()
        {
            System.Console.WriteLine("director", director);
            System.Console.WriteLine("title", title);
            System.Console.WriteLine("NumCopies", NumCopies);
            System.Console.WriteLine("playtime", playtime);
        }
    }
}