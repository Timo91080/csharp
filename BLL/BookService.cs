using System.Collections.Generic;
using BiblioWorld.DAL;
using BiblioWorld.Models;

namespace BiblioWorld.BLL
{
    public class BookService
    {
        private readonly BookRepository _repository = new BookRepository();

        public List<Book> GetBooks()
        {
            return _repository.GetAllBooks();
        }

        public Book GetBookById(int id)
        {
            return _repository.GetBookById(id);
        }
    }
}