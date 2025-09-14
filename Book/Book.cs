namespace BookCollectionModule
{
    public class Book
    {
        private static int _nextId = 1; // автоинкремент

        public int Id { get; private set; } // уникальный ID
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }

        public Book(string title, string author, int year, string genre)
        {
            Id = _nextId++;
            Title = title;
            Author = author;
            Year = year;
            Genre = genre;
        }
    }
}
