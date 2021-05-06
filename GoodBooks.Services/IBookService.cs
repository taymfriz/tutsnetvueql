using System;
using System.Collections.Generic;
using GoodBooks.Data.Models;

namespace GoodBooks.Services
{
    public interface IBookService
    {
        public void AddBook(Book book);
        public void DeleteBook(int id);
        public Book GetBook(int id);
        public List<Book> GetAllBooks();
        
    }
}
