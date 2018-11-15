//using LibraryConsole.ServiceReference1;


using LibraryConsole.BookDatabaseService;
using System;
using System.Linq;

namespace LibraryConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (BookDatabaseService.BookDatabaseServiceClient proxy = new BookDatabaseServiceClient())
            {

                var books = proxy.GetBooks();
                Console.WriteLine(books.Select(t => t.Title).First());
                Console.ReadKey();



            }
        }
    }
}
