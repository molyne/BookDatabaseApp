//using LibraryConsole.ServiceReference1;


using LibraryConsole.BookDatabaseService;
using MovieDatabase.Models;
using System;
using System.Collections.Generic;

namespace LibraryConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>();
            using (BookDatabaseService.BookDatabaseServiceClient proxy = new BookDatabaseServiceClient())
            {
                books.Clear();
                books = proxy.GetBooks();

                foreach (var book in books)
                {
                    Console.WriteLine($"Title: {book.Title} \nPrice: {book.Price}\nGenre: {book.Genre}");

                }

                Console.ReadKey();
            }
        }
    }
}
