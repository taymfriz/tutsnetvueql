using System;
using GoodBooks.Data.Models;
using System.Collections.Generic;



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
