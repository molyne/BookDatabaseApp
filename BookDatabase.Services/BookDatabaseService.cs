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

        public List<Book> GetBooks()
        {
            return _Context.Books.ToList();
        }

        public List<Author> GetAuthors()
        {
            return _Context.Authors.ToList();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void AddBook(Book book)
        {
            _Context.Books.Add(book);
            _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}