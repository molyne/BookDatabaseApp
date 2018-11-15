using MovieDatabase.Models;

namespace BookDatabase.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<BookDatabase.Data.BookDatabaseDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookDatabase.Data.BookDatabaseDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Books.AddOrUpdate(b => b.Title,
                new Book { Title = "Woman in black", Genre = "Horror", Price = 99 });

            context.SaveChanges();
        }
    }
}
