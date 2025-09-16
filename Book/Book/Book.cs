using System.Diagnostics;

namespace Book
{
    public class Book
    {
        private static int _nextId = 1;

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int GenreId { get; set; }       // id жанра
        public string GenreName { get; set; }
        public decimal Price { get; set; } // название жанра

        // Конструктор для режима без БД

        // Конструктор для загрузки из БД
        public Book(int id, string title, string author, int year, int genreId, decimal price, string genreName)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;
            GenreId = genreId;
            Price = price;
            GenreName = genreName;
        }
    }
}
