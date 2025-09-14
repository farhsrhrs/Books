using System;

namespace BookCollectionModule
{
    // Класс книги
    public class Book
    {
        public Guid Id { get; private set; }      // Уникальный идентификатор
        public string Title { get; set; }         // Название
        public string Author { get; set; }        // Автор
        public int Year { get; set; }             // Год издания

        public Book(string title, string author, int year)
        {
            Id = Guid.NewGuid();  // Автоматически генерируется
            Title = title;
            Author = author;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Title} ({Year}), автор: {Author}, ID: {Id}";
        }
    }
}
