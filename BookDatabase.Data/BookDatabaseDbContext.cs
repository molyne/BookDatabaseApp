using MovieDatabase.Models;
using System.Data.Entity;

namespace BookDatabase.Data
{
    public class BookDatabaseDbContext : DbContext
    {
        public BookDatabaseDbContext() : base("BookDatabaseDb")
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

    }
}
