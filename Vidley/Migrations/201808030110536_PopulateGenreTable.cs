namespace Vidley.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres(Id,Name) values(1,'Action')");
            Sql("insert into Genres(Id,Name) values(2,'Comedy')");
            Sql("insert into Genres(Id,Name) values(3,'Family')");
            Sql("insert into Genres(Id,Name) values(4,'Romance')");
            Sql("insert into Genres(Id,Name) values(5,'Sci-Fi')");
            Sql("insert into Genres(Id,Name) values(6,'Documentary')");
        }
        
        public override void Down()
        {
        }
    }
}
