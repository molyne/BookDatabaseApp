using MovieDatabase.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace BookDatabase.Services
{
    [ServiceContract]
    public interface IBookDatabaseService
    {
        [OperationContract]
        List<Book> GetBooks();

        [OperationContract]
        List<Author> GetAuthors();

        [OperationContract]
        void AddBook(Book book);
    }
}
