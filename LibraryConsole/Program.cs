using LibraryConsole.ServiceReference1;
using System;
using System.Linq;

namespace LibraryConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (ServiceReference1.BookDatabaseServiceClient proxy = new BookDatabaseServiceClient())
            {
                var books = proxy.GetBooks();
                Console.WriteLine(books.Select(t => t.Title).First());
                Console.ReadKey();
            }
        }
    }
}
