using System;
using System.Collections.Generic;
using System.Linq;

namespace BookCollectionModule
{
    // Класс для управления коллекцией книг
    public class BookManager
    {
        private List<Book> books = new List<Book>();

        // Добавление книги
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        // Удаление книги по ID
        public bool RemoveBook(Guid id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                books.Remove(book);
                return true;
            }
            return false;
        }

        // Поиск книги по названию
        public List<Book> FindBookByName(string title)
        {
            return books
                .Where(b => b.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        // Поиск книги по автору
        public List<Book> FindBookByAuthor(string author)
        {
            return books
                .Where(b => b.Author.IndexOf(author, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        // Вывод всех книг
        public void PrintAllBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Коллекция книг пуста.");
                return;
            }

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
