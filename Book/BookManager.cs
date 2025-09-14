using System;
using System.Collections.Generic;
using System.Linq;

namespace BookCollectionModule
{
    public class BookManager
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book) => books.Add(book);

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

        public List<Book> FindBookByName(string title) =>
            books.Where(b => b.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

        public List<Book> FindBookByAuthor(string author) =>
            books.Where(b => b.Author.IndexOf(author, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

        public List<Book> GetAllBooks() => new List<Book>(books);
    }
}
