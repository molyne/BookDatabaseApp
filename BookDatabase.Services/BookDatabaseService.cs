using BookDatabase.Data;
using MovieDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace BookDatabase.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class BookDatabaseService : IBookDatabaseService, IDisposable
    {
        readonly BookDatabaseDbContext _Context = new BookDatabaseDbContext();

        [OperationBehavior(TransactionScopeRequired = true)]
        public List<Book> GetBooks()
        {
            return _Context.Books.ToList();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void AddBook(Book book)
        {
            _Context.Books.Add(book);
            _Context.SaveChanges();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void DeleteBook(int id)
        {
            var book = GetById(id);
            _Context.Books.Remove(book);
            _Context.SaveChanges();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void EditBook(Book model)
        {
            var book = GetById(model.Id);

            if (book == null) throw new Exception("Book doesn't exist in the database");

            book.Title = model.Title;
            book.Genre = model.Genre;
            book.Price = model.Price;
            _Context.SaveChanges();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public Book GetById(int id)
        {
            var book = _Context.Books.Single(x => x.Id == id);
            return book;
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}