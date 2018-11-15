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
        void AddBook(Book book);

        [OperationContract]
        void DeleteBook(int id);

        [OperationContract]
        void EditBook(Book book);

        [OperationContract]
        Book GetById(int id);
    }
}
