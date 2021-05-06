using System;
using System.Linq;
using GoodBooks.Data;
using GoodBooks.Data.Models;
using GoodBooks.Services;
using System.Collections.Generic;

namespace GoodBooks.Services
{
    public class BookService : IBookService
    {
        private readonly GoodBooksDbContext _db;

        public BookService(GoodBooksDbContext db){
            _db = db;
        }

        public void AddBook(Book book)
        {
           _db.Add(book);
           _db.SaveChanges();
        }
        public void DeleteBook(int id)
        {
            var bookToDelete = _db.Books.Find(id);
            if(bookToDelete != null){
                _db.Books.Remove(bookToDelete);
            }
        }
        public Book GetBook(int id)
        {
            // return _db.Books.Find(id);
            return _db.Books.First((book)=> book.Id == id);
            // return _db.Books.FirstOrDefault((book)=> book.Id == id);
        }
        public List<Book> GetAllBooks()
        {
            return _db.Books.ToList();
            throw new NotImplementedException();
        }

    }
}
