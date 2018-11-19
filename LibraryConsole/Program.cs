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

                bool keepRunning = true;

                while (keepRunning)
                {
                    Console.WriteLine("Press S to show all books");
                    Console.WriteLine("Press A to add a book");
                    Console.WriteLine("Press D to delete a book");
                    Console.WriteLine("Press E to edit an existing book");
                    Console.WriteLine("Press X to exit");

                    var answer = Console.ReadLine();

                    switch (answer)
                    {
                        case "A":
                            {
                                var book = new Book();

                                Console.WriteLine("Enter title");
                                book.Title = Console.ReadLine();
                                Console.WriteLine("Enter genre");
                                book.Genre = Console.ReadLine();
                                Console.WriteLine("Enter price");
                                book.Price = int.Parse(Console.ReadLine());
                                proxy.AddBookAsync(book);
                                Console.Clear();
                                break;
                            }
                        case "D":
                            {
                                Console.WriteLine("Enter id of which book you've like to delete.");
                                var id = int.Parse(Console.ReadLine());

                                proxy.DeleteBookAsync(id);
                                Console.Clear();


                                break;
                            }
                        case "S":
                            {
                                books.Clear();
                                books = proxy.GetBooks();

                                foreach (var book in books)
                                {
                                    Console.WriteLine(
                                        $"Id:{book.Id}\nTitle: {book.Title} \nPrice: {book.Price} SEK\nGenre: {book.Genre}\n");
                                }

                                break;
                            }
                        case "E":
                            {
                                var book = new Book();

                                Console.WriteLine("Enter id of which book you've like to edit");
                                book.Id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter new title");
                                book.Title = Console.ReadLine();
                                Console.WriteLine("Enter new genre");
                                book.Genre = Console.ReadLine();
                                Console.WriteLine("Enter new price");
                                book.Price = int.Parse(Console.ReadLine());

                                proxy.EditBookAsync(book);
                                Console.Clear();

                                break;
                            }
                        case "X":
                            {
                                keepRunning = false;
                                break;
                            }
                    }
                }
            }
        }
    }
}
