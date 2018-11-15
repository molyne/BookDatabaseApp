namespace BookDatabase.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Price", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "Genre", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Genre");
            DropColumn("dbo.Books", "Price");
        }
    }
}
