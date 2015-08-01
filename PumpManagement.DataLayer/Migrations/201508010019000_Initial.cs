namespace PumpManagement.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ExternalNumber = c.Int(nullable: false),
                        InternalNumber = c.Int(nullable: false),
                        Colony = c.String(),
                        PostalCode = c.Int(nullable: false),
                        City = c.String(),
                        State = c.String(),
                        Type = c.String(),
                        PumperId = c.Int(),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.Pumpers", t => t.PumperId)
                .Index(t => t.PumperId);
            
            CreateTable(
                "dbo.Pumpers",
                c => new
                    {
                        PumperId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        NickName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        CaloriesBurned = c.Int(nullable: false),
                        DebutDate = c.DateTime(nullable: false),
                        PhotoUrl = c.String(),
                        ZoneId = c.Int(),
                    })
                .PrimaryKey(t => t.PumperId)
                .ForeignKey("dbo.Zones", t => t.ZoneId)
                .Index(t => t.ZoneId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Locals",
                c => new
                    {
                        LocalId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartTime = c.Int(nullable: false),
                        EndTime = c.Int(nullable: false),
                        StartDay = c.String(),
                        EndDay = c.String(),
                        AddressId = c.Int(),
                        Pumper_PumperId = c.Int(),
                    })
                .PrimaryKey(t => t.LocalId)
                .ForeignKey("dbo.Addresses", t => t.AddressId)
                .ForeignKey("dbo.Pumpers", t => t.Pumper_PumperId)
                .Index(t => t.AddressId)
                .Index(t => t.Pumper_PumperId);
            
            CreateTable(
                "dbo.Machines",
                c => new
                    {
                        MachineId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MK = c.String(),
                        Model = c.String(),
                        GameVersion = c.String(),
                        CreditPrice = c.Int(nullable: false),
                        LocalId = c.Int(),
                    })
                .PrimaryKey(t => t.MachineId)
                .ForeignKey("dbo.Locals", t => t.LocalId)
                .Index(t => t.LocalId);
            
            CreateTable(
                "dbo.Tournaments",
                c => new
                    {
                        TournamentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Year = c.Int(nullable: false),
                        LogoURL = c.String(),
                        LocalId = c.Int(),
                    })
                .PrimaryKey(t => t.TournamentId)
                .ForeignKey("dbo.Locals", t => t.LocalId)
                .Index(t => t.LocalId);
            
            CreateTable(
                "dbo.PumperTournaments",
                c => new
                    {
                        PumperTournamentId = c.Int(nullable: false, identity: true),
                        Place = c.Int(nullable: false),
                        PumperId = c.Int(nullable: true),
                        TournamentId = c.Int(nullable: true),
                        Tournament_TournamentId = c.Int(),
                        Pumper_PumperId = c.Int(),
                    })
                .PrimaryKey(t => t.PumperTournamentId)
                .ForeignKey("dbo.Pumpers", t => t.PumperId)
                .ForeignKey("dbo.Tournaments", t => t.TournamentId)
                .ForeignKey("dbo.Tournaments", t => t.Tournament_TournamentId)
                .ForeignKey("dbo.Pumpers", t => t.Pumper_PumperId)
                .Index(t => t.PumperId)
                .Index(t => t.TournamentId)
                .Index(t => t.Tournament_TournamentId)
                .Index(t => t.Pumper_PumperId);
            
            CreateTable(
                "dbo.PumperSongModes",
                c => new
                    {
                        PumperSongModeID = c.Int(nullable: false, identity: true),
                        SongModeId = c.Int(),
                        PumperId = c.Int(),
                        Score = c.Int(nullable: false),
                        Grade = c.String(),
                    })
                .PrimaryKey(t => t.PumperSongModeID)
                .ForeignKey("dbo.Pumpers", t => t.PumperId)
                .ForeignKey("dbo.SongModes", t => t.SongModeId)
                .Index(t => t.SongModeId)
                .Index(t => t.PumperId);
            
            CreateTable(
                "dbo.SongModes",
                c => new
                    {
                        SongModeId = c.Int(nullable: false, identity: true),
                        SongId = c.Int(),
                        ModeId = c.Int(),
                        Difficulty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SongModeId)
                .ForeignKey("dbo.Modes", t => t.ModeId)
                .ForeignKey("dbo.Songs", t => t.SongId)
                .Index(t => t.SongId)
                .Index(t => t.ModeId);
            
            CreateTable(
                "dbo.Modes",
                c => new
                    {
                        ModeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ModeId);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        SongId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Author = c.String(),
                        Genre = c.String(),
                        BPM = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SongId);
            
            CreateTable(
                "dbo.Zones",
                c => new
                    {
                        ZoneId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ZoneId);
            
            CreateTable(
                "dbo.CategoryPumpers",
                c => new
                    {
                        Category_CategoryId = c.Int(nullable: false),
                        Pumper_PumperId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Category_CategoryId, t.Pumper_PumperId })
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Pumpers", t => t.Pumper_PumperId, cascadeDelete: true)
                .Index(t => t.Category_CategoryId)
                .Index(t => t.Pumper_PumperId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pumpers", "ZoneId", "dbo.Zones");
            DropForeignKey("dbo.PumperTournaments", "Pumper_PumperId", "dbo.Pumpers");
            DropForeignKey("dbo.SongModes", "SongId", "dbo.Songs");
            DropForeignKey("dbo.PumperSongModes", "SongModeId", "dbo.SongModes");
            DropForeignKey("dbo.SongModes", "ModeId", "dbo.Modes");
            DropForeignKey("dbo.PumperSongModes", "PumperId", "dbo.Pumpers");
            DropForeignKey("dbo.Locals", "Pumper_PumperId", "dbo.Pumpers");
            DropForeignKey("dbo.PumperTournaments", "Tournament_TournamentId", "dbo.Tournaments");
            DropForeignKey("dbo.PumperTournaments", "TournamentId", "dbo.Tournaments");
            DropForeignKey("dbo.PumperTournaments", "PumperId", "dbo.Pumpers");
            DropForeignKey("dbo.Tournaments", "LocalId", "dbo.Locals");
            DropForeignKey("dbo.Machines", "LocalId", "dbo.Locals");
            DropForeignKey("dbo.Locals", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.CategoryPumpers", "Pumper_PumperId", "dbo.Pumpers");
            DropForeignKey("dbo.CategoryPumpers", "Category_CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Addresses", "PumperId", "dbo.Pumpers");
            DropIndex("dbo.CategoryPumpers", new[] { "Pumper_PumperId" });
            DropIndex("dbo.CategoryPumpers", new[] { "Category_CategoryId" });
            DropIndex("dbo.SongModes", new[] { "ModeId" });
            DropIndex("dbo.SongModes", new[] { "SongId" });
            DropIndex("dbo.PumperSongModes", new[] { "PumperId" });
            DropIndex("dbo.PumperSongModes", new[] { "SongModeId" });
            DropIndex("dbo.PumperTournaments", new[] { "Pumper_PumperId" });
            DropIndex("dbo.PumperTournaments", new[] { "Tournament_TournamentId" });
            DropIndex("dbo.PumperTournaments", new[] { "TournamentId" });
            DropIndex("dbo.PumperTournaments", new[] { "PumperId" });
            DropIndex("dbo.Tournaments", new[] { "LocalId" });
            DropIndex("dbo.Machines", new[] { "LocalId" });
            DropIndex("dbo.Locals", new[] { "Pumper_PumperId" });
            DropIndex("dbo.Locals", new[] { "AddressId" });
            DropIndex("dbo.Pumpers", new[] { "ZoneId" });
            DropIndex("dbo.Addresses", new[] { "PumperId" });
            DropTable("dbo.CategoryPumpers");
            DropTable("dbo.Zones");
            DropTable("dbo.Songs");
            DropTable("dbo.Modes");
            DropTable("dbo.SongModes");
            DropTable("dbo.PumperSongModes");
            DropTable("dbo.PumperTournaments");
            DropTable("dbo.Tournaments");
            DropTable("dbo.Machines");
            DropTable("dbo.Locals");
            DropTable("dbo.Categories");
            DropTable("dbo.Pumpers");
            DropTable("dbo.Addresses");
        }
    }
}
