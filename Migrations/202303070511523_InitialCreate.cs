namespace FilmLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.Boolean(nullable: false),
                        City = c.String(),
                        Wealth = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Country = c.String(),
                        Year = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Viewers = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.Boolean(nullable: false),
                        City = c.String(),
                        Wealth = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FilmActors",
                c => new
                    {
                        Film_Id = c.Int(nullable: false),
                        Actor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Film_Id, t.Actor_Id })
                .ForeignKey("dbo.Films", t => t.Film_Id, cascadeDelete: true)
                .ForeignKey("dbo.Actors", t => t.Actor_Id, cascadeDelete: true)
                .Index(t => t.Film_Id)
                .Index(t => t.Actor_Id);
            
            CreateTable(
                "dbo.CountryFilms",
                c => new
                    {
                        Country_Id = c.Int(nullable: false),
                        Film_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Country_Id, t.Film_Id })
                .ForeignKey("dbo.Countries", t => t.Country_Id, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.Film_Id, cascadeDelete: true)
                .Index(t => t.Country_Id)
                .Index(t => t.Film_Id);
            
            CreateTable(
                "dbo.DirectorFilms",
                c => new
                    {
                        Director_Id = c.Int(nullable: false),
                        Film_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Director_Id, t.Film_Id })
                .ForeignKey("dbo.Directors", t => t.Director_Id, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.Film_Id, cascadeDelete: true)
                .Index(t => t.Director_Id)
                .Index(t => t.Film_Id);
            
            CreateTable(
                "dbo.GenreFilms",
                c => new
                    {
                        Genre_Id = c.Int(nullable: false),
                        Film_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genre_Id, t.Film_Id })
                .ForeignKey("dbo.Genres", t => t.Genre_Id, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.Film_Id, cascadeDelete: true)
                .Index(t => t.Genre_Id)
                .Index(t => t.Film_Id);
            
            CreateTable(
                "dbo.LanguageFilms",
                c => new
                    {
                        Language_Id = c.Int(nullable: false),
                        Film_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Language_Id, t.Film_Id })
                .ForeignKey("dbo.Languages", t => t.Language_Id, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.Film_Id, cascadeDelete: true)
                .Index(t => t.Language_Id)
                .Index(t => t.Film_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LanguageFilms", "Film_Id", "dbo.Films");
            DropForeignKey("dbo.LanguageFilms", "Language_Id", "dbo.Languages");
            DropForeignKey("dbo.GenreFilms", "Film_Id", "dbo.Films");
            DropForeignKey("dbo.GenreFilms", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.DirectorFilms", "Film_Id", "dbo.Films");
            DropForeignKey("dbo.DirectorFilms", "Director_Id", "dbo.Directors");
            DropForeignKey("dbo.CountryFilms", "Film_Id", "dbo.Films");
            DropForeignKey("dbo.CountryFilms", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.FilmActors", "Actor_Id", "dbo.Actors");
            DropForeignKey("dbo.FilmActors", "Film_Id", "dbo.Films");
            DropIndex("dbo.LanguageFilms", new[] { "Film_Id" });
            DropIndex("dbo.LanguageFilms", new[] { "Language_Id" });
            DropIndex("dbo.GenreFilms", new[] { "Film_Id" });
            DropIndex("dbo.GenreFilms", new[] { "Genre_Id" });
            DropIndex("dbo.DirectorFilms", new[] { "Film_Id" });
            DropIndex("dbo.DirectorFilms", new[] { "Director_Id" });
            DropIndex("dbo.CountryFilms", new[] { "Film_Id" });
            DropIndex("dbo.CountryFilms", new[] { "Country_Id" });
            DropIndex("dbo.FilmActors", new[] { "Actor_Id" });
            DropIndex("dbo.FilmActors", new[] { "Film_Id" });
            DropTable("dbo.LanguageFilms");
            DropTable("dbo.GenreFilms");
            DropTable("dbo.DirectorFilms");
            DropTable("dbo.CountryFilms");
            DropTable("dbo.FilmActors");
            DropTable("dbo.Languages");
            DropTable("dbo.Genres");
            DropTable("dbo.Directors");
            DropTable("dbo.Countries");
            DropTable("dbo.Films");
            DropTable("dbo.Actors");
        }
    }
}
