using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BiblioWorld.Models;

namespace BiblioWorld.DAL
{
    public class BookRepository
    {
        private readonly Database _database = new Database();

        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            using (MySqlConnection conn = _database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM books"; // Mise à jour ici
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book
                            {
                                BookID = reader.GetInt32("BookID"),
                                Title = reader.GetString("Title"),
                                AuthorID = reader.GetInt32("AuthorID"),
                                GenreID = reader.GetInt32("GenreID"),
                                PublishedYear = reader.GetInt32("PublishedYear"),
                                Summary = reader.GetString("Summary")
                            });
                        }
                    }
                }
            }
            return books;
        }

        public Book GetBookById(int id)
        {
            Book book = null;
            using (MySqlConnection conn = _database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM books WHERE BookID = @id"; // Mise à jour ici
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            book = new Book
                            {
                                BookID = reader.GetInt32("BookID"),
                                Title = reader.GetString("Title"),
                                AuthorID = reader.GetInt32("AuthorID"),
                                GenreID = reader.GetInt32("GenreID"),
                                PublishedYear = reader.GetInt32("PublishedYear"),
                                Summary = reader.GetString("Summary")
                            };
                        }
                    }
                }
            }
            return book;
        }
    }
}