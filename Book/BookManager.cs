using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookCollectionModule
{
    public class BookManager
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book) => books.Add(book);

        public void RemoveBook(int id) => books.RemoveAll(b => b.Id == id);

        public List<Book> GetAllBooks() => new List<Book>(books);

        public List<Book> FindBookByName(string name) =>
            books.Where(b => b.Title.IndexOf(name, System.StringComparison.OrdinalIgnoreCase) >= 0).ToList();

        public List<Book> FindBookByAuthor(string author) =>
            books.Where(b => b.Author.IndexOf(author, System.StringComparison.OrdinalIgnoreCase) >= 0).ToList();

        public List<Book> FindBookByGenre(string genre) =>
            books.Where(b => b.GenreName.IndexOf(genre, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
    }
}
