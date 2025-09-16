using System;
using System.Collections.Generic;
using System.Linq;
using Npgsql;

namespace Book.Services
{
    public class BookService
    {
        private readonly string connectionString;

        public BookService(string connStr)
        {
            connectionString = connStr;
        }
        public Book GetBookById(int id)
        {
            return GetAllBooks().FirstOrDefault(b => b.Id == id);
        }

        public List<Book> GetAllBooks()
        {
            var books = new List<Book>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(
                    "SELECT b.id, b.title, b.author, b.year, b.genre_id, b.price, g.name " +
                    "FROM book b JOIN genre g ON b.genre_id = g.id ORDER BY b.id", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book(
                                reader.GetInt32(0),   // b.id
                                reader.GetString(1),  // b.title
                                reader.GetString(2),  // b.author
                                reader.GetInt32(3),   // b.year
                                reader.GetInt32(4),   // b.genre_id
                                reader.GetDecimal(5), // b.price
                                reader.GetString(6)
                            ));
                        }
                    }
                }
            }
            return books;
        }


        public List<Genre> GetAllGenres()
        {
            var genres = new List<Genre>();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT id, name FROM genre", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        genres.Add(new Genre
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        });
                    }
                }
            }

            return genres;
        }

        public void AddBook(string title, string author, int year, int genreId, decimal price)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(
                    "INSERT INTO book(title, author, year, genre_id, price ) VALUES (@title,@author,@year,@genre,@price)",
                    conn))
                {
                    cmd.Parameters.AddWithValue("title", title);
                    cmd.Parameters.AddWithValue("author", author);
                    cmd.Parameters.AddWithValue("year", year);
                    cmd.Parameters.AddWithValue("genre", genreId);
                    cmd.Parameters.AddWithValue("price", price);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool RemoveBook(int id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("DELETE FROM book WHERE id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<Genre> GetGenres()
        {
            var genres = new List<Genre>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT id, name FROM genre ORDER BY name", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            genres.Add(new Genre
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            return genres;
        }

        public List<Book> SearchBooks(string criteria, string query)
        {
            var books = new List<Book>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string sql = "1=0";
                if (criteria == "Название") sql = "b.title ILIKE @q";
                else if (criteria == "Автор") sql = "b.author ILIKE @q";
                else if (criteria == "Год") sql = "b.year = @q";
                else if (criteria == "Жанр") sql = "g.name ILIKE @q";
                else if (criteria == "Цена") sql = "b.price ILIKE @q";


                using (var cmd = new NpgsqlCommand(
                    "SELECT b.id, b.title, b.author, b.year, b.genre_id, b.price, g.name " +
                    "FROM book b JOIN genre g ON b.genre_id=g.id WHERE " + sql, conn))
                {
                    if (criteria == "Год")
                        cmd.Parameters.AddWithValue("q", int.Parse(query));
                    else
                        cmd.Parameters.AddWithValue("q", "%" + query + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book(
                        reader.GetInt32(0),   // b.id
                        reader.GetString(1),  // b.title
                        reader.GetString(2),  // b.author
                        reader.GetInt32(3),   // b.year
                        reader.GetInt32(4),   // b.genre_id
                        reader.GetDecimal(5), // b.price
                         reader.GetString(6)
                            ));
                        }
                    }
                }
            }
            return books;
        }
    }
}
