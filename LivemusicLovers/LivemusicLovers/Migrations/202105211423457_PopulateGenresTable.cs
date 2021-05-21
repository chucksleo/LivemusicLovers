namespace LivemusicLovers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Hip-Hop')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'RnB')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Soundtrack')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Afro-Pop')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Afro-Beat')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Pop')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Hip-Hop/Rap')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Blues')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'Rock')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (11, 'Country')");


        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11");
        }
    }
}
