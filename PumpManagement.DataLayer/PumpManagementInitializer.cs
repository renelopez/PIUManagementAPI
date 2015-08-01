using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PumpManagement.DomainClasses;

namespace PumpManagement.DataLayer
{
    public class PumpManagementInitializer:DropCreateDatabaseAlways<PumpManagementContext>
    {
        protected override async void Seed(PumpManagementContext context)
        {
            //var pumpers=new List<Pumper>
            //{
            //    new Pumper
            //    {
            //        PumperId = 1,
            //        Name="Rene",
            //        LastName = "Lopez",
            //        NickName = "Renex",
            //        Email = "rene.cano@hotmail.com",
            //        Phone = "360321212",
            //        BirthDate = Convert.ToDateTime("24/04/1988"),
            //        CaloriesBurned = 20,
            //        DebutDate = Convert.ToDateTime("12/12/2006"),
            //        PhotoUrl = "http://www.gravatar.com/avatar/0cf15665a9146ba852bf042b0652780a?s=200"
            //    },
            //     new Pumper
            //    {
            //        PumperId = 2,
            //        Name="Mario",
            //        LastName = "Rodriguez",
            //        NickName = "Hou",
            //        Email = "mario.rodriguez@hotmail.com",
            //        Phone = "360321212",
            //        BirthDate = Convert.ToDateTime("12/04/1989"),
            //        CaloriesBurned = 23432,
            //        DebutDate = Convert.ToDateTime("12/12/1992"),
            //        PhotoUrl = "http://www.iclarified.com/images/news/38136/164976/164976.png"
            //    },
            //      new Pumper
            //    {
            //        PumperId = 3,
            //        Name="Gerardo",
            //        LastName = "Perez",
            //        NickName = "Gerber",
            //        Email = "gerber.perez@hotmail.com",
            //        Phone = "360321212",
            //        BirthDate = Convert.ToDateTime("12/04/1994"),
            //        CaloriesBurned = 23432,
            //        DebutDate = Convert.ToDateTime("12/12/2010"),
            //        PhotoUrl = "http://static.comicvine.com/uploads/original/5/53282/1287026-showcase_ember_0026.jpg"
            //    },
            //       new Pumper
            //    {
            //        PumperId = 4,
            //        Name="Nayeli",
            //        LastName = "Garcia",
            //        NickName = "Naye",
            //        Email = "nayeli.garcia@hotmail.com",
            //        Phone = "360321212",
            //        BirthDate = Convert.ToDateTime("12/04/1989"),
            //        CaloriesBurned = 23432,
            //        DebutDate = Convert.ToDateTime("12/12/1990"),
            //        PhotoUrl = "http://a1849.phobos.apple.com/us/r30/Purple/v4/05/90/6b/05906b08-c2f0-29c8-f75a-4f61706e0fee/mzl.eampfryt.png"
            //    },
            //        new Pumper
            //    {
            //        PumperId = 5,
            //        Name="Carlos",
            //        LastName = "Lopez",
            //        NickName = "xxxy",
            //        Email = "carlos.lopez@hotmail.com",
            //        Phone = "360321212",
            //        BirthDate = Convert.ToDateTime("12/04/1992"),
            //        CaloriesBurned = 23432,
            //        DebutDate = Convert.ToDateTime("12/12/1990"),
            //        PhotoUrl = "http://emberjs.com/images/logos/ember-logo.png"
            //    },

            //};

            //var addresses=new List<Address>
            //{
            //    new Address()
            //    {
            //        AddressId = 1,
            //        Name = "Pablo Valdez",
            //        ExternalNumber = 4069,
            //        InternalNumber = 25,
            //        Colony = "Lomas del Gallo",
            //        PostalCode = 44760,
            //        City = "Guadalajara",
            //        State = "Jalisco"
            //    },
            //    new Address()
            //    {
            //        AddressId = 2,
            //        Name = "Avenida Americas",
            //        ExternalNumber = 1536,
            //        InternalNumber = 1,
            //        Colony = "Country Club",
            //        PostalCode = 44610,
            //        City = "Guadalajara",
            //        State = "Jalisco"
            //    },
            //    new Address()
            //    {
            //        AddressId = 3,
            //        Name = "Jardines de Versalles",
            //        ExternalNumber = 3909,
            //        InternalNumber = 10,
            //        Colony = "Jardines de San Francisco",
            //        PostalCode = 44790,
            //        City = "Guadalajara",
            //        State = "Jalisco"
            //    },
            //    new Address()
            //    {
            //        AddressId = 4,
            //        Name = "Providencia",
            //        ExternalNumber = 2312,
            //        InternalNumber = 0,
            //        Colony = "Terranova",
            //        PostalCode = 44615,
            //        City = "Zapopan",
            //        State = "Jalisco",
            //    },
            //    new Address()
            //    {
            //        AddressId = 5,
            //        Name = "Avenida Patria",
            //        ExternalNumber = 4444,
            //        InternalNumber = 0,
            //        Colony = "Jacarandas",
            //        PostalCode = 440990,
            //        City = "Zapopan",
            //        State = "Jalisco"
            //    },
            //    new Address()
            //    {
            //        AddressId = 6,
            //        Name = "Jose Luis",
            //        ExternalNumber = 68,
            //        InternalNumber = 0,
            //        Colony = "Centro",
            //        PostalCode = 44100,
            //        City = "Guadalajara",
            //        State = "Jalisco"
            //    },
            //    new Address()
            //    {
            //        AddressId = 7,
            //        Name = "Agustin Pagasa",
            //        ExternalNumber = 4444,
            //        InternalNumber = 0,
            //        Colony = "La Aurora",
            //        PostalCode = 44099,
            //        City = "Guadalajara",
            //        State = "Jalisco"
            //    }
            //};

            //var categories=new List<Category>()
            //{
            //    new Category()
            //    {
            //        CategoryId = 1,
            //        Name = "Male Speed",
            //    },
            //     new Category()
            //    {
            //         CategoryId = 2,
            //        Name = "Female Speed",
            //    },
            //      new Category()
            //    {
            //        CategoryId = 3,
            //        Name = "Freestyle",
            //    },

            //};

            //var locals=new List<Local>()
            //{
            //    new Local()
            //    {
            //        LocalId = 1,
            //        Name = "Rockoparty",
            //        StartTime = 900,
            //        EndTime = 2130,
            //        StartDay = "Monday",
            //        EndDay = "Sunday"

            //    },
            //    new Local()
            //    {
            //        LocalId = 2,
            //        Name = "La Aurora",
            //        StartTime = 0900,
            //        EndTime = 2130,
            //        StartDay = "Monday",
            //        EndDay = "Sunday"
            //    }
            //};

            //var machines=new List<Machine>()
            //{
            //    new Machine()
            //    {
            //        LocalId = 1,
            //        Name = "Veronica",
            //        MK = "9",
            //        Model = "GX",
            //        GameVersion = "Prime",
            //        CreditPrice = 5
            //    },
            //     new Machine()
            //    {
            //        LocalId = 2,
            //        Name = "HulkBuster",
            //        MK = "9",
            //        Model = "GX",
            //        GameVersion = "Prime",
            //        CreditPrice = 5
            //    },
            //     new Machine()
            //    {
            //        LocalId = 3,
            //        Name = "Tere",
            //        MK = "9",
            //        Model = "Hybrid",
            //        GameVersion = "Fiesta2",
            //        CreditPrice = 4
            //    },
            //     new Machine()
            //     {
            //         LocalId = 4,
            //         Name = "Tere",
            //         MK = "9",
            //         Model = "Hybrid",
            //         GameVersion = "Fiesta2",
            //         CreditPrice = 4
            //     }

            //};


            //var modes=new List<Mode>()
            //{
            //    new Mode()
            //    {
            //        ModeId = 1,
            //        Name = "Single",
            //    },
            //     new Mode()
            //    {
            //         ModeId = 2,
            //        Name = "Double",
            //    },
            //      new Mode()
            //    {
            //        ModeId = 3,
            //        Name = "Single Performance",
            //    },
            //       new Mode()
            //    {
            //        ModeId = 4,
            //        Name = "Double Performance",
            //    },
            //        new Mode()
            //    {
            //        ModeId = 5,
            //        Name = "Triple Performance",
            //    }
            //};

            //var pumperSongModes=new List<PumperSongMode>()
            //{
            //    new PumperSongMode()
            //    {
            //        PumperSongModeID = 1,
            //        Score = 1243412,
            //        Grade = "A"
            //    },
            //     new PumperSongMode()
            //    {
            //         PumperSongModeID = 2,
            //        Score = 32431,
            //        Grade = "B"
            //    },
            //      new PumperSongMode()
            //    {
            //          PumperSongModeID = 3,
            //        Score = 3254534,
            //        Grade = "B"
            //    }
            //};

            //var pumperTournaments=new List<PumperTournament>()
            //{
            //    new PumperTournament()
            //    {
            //        PumperTournamentId = 1,
            //        Place = 1
            //    },
            //    new PumperTournament()
            //    {
            //        PumperTournamentId = 2,
            //        Place = 2
            //    },
            //    new PumperTournament()
            //    {
            //        PumperTournamentId = 3,
            //        Place = 3
            //    },
            //    new PumperTournament()
            //    {
            //        PumperTournamentId = 4,
            //        Place = 1
            //    },
            //    new PumperTournament()
            //    {
            //        PumperTournamentId = 5,
            //        Place = 2
            //    }
            //};

            //var songs=new List<Song>()
            //{
            //    new Song()
            //    {
            //        SongId = 1,
            //        Name = "I will give you all my love",
            //        Author = "Wax",
            //        Genre = "K-POP",
            //        BPM = 160
            //    },
            //    new Song()
            //    {
            //        SongId = 2,
            //        Name = "Dignity",
            //        Author = "Crash",
            //        Genre = "K-POP"
            //    },
            //    new Song()
            //    {
            //        SongId = 3,
            //        Name = "Slam",
            //        Author = "Novasonic",
            //        Genre = "K-POP"
            //    },

            //};

            //var songModes=new List<SongMode>()
            //{
            //    new SongMode()
            //    {
            //        SongModeId = 1,
            //        Difficulty = 20
            //    },
            //    new SongMode()
            //    {
            //        SongModeId = 2,
            //        Difficulty = 12
            //    },
            //    new SongMode()
            //    {
            //        SongModeId = 3,
            //        Difficulty = 12
            //    },
            //    new SongMode()
            //    {
            //        SongModeId = 4,
            //        Difficulty = 2
            //    },
            //};

            //var tournaments=new List<Tournament>()
            //{
            //    new Tournament()
            //    {
            //        TournamentId = 1,
            //        Name = "PIU International Championship 2015",
            //        Year = 2015,
            //        LogoURL = "http://www.doublepump.com/Content/doublepump/img/tournaments/1.gif"
            //    },
            //     new Tournament()
            //    {
            //        TournamentId = 2,
            //        Name = "PIU International Championship 2014",
            //        Year = 2014,
            //        LogoURL = "http://www.doublepump.com/Content/doublepump/img/tournaments/2.gif"
            //    }
            //};

            //var zones=new List<Zone>()
            //{
            //    new Zone()
            //    {
            //        ZoneId = 1,
            //        Name = "Noroeste"
            //    },
            //     new Zone()
            //    {
            //         ZoneId = 2,
            //        Name = "Centro"
            //    },
            //      new Zone()
            //    {
            //        ZoneId = 3,
            //        Name = "Suroeste"
            //    },
            //       new Zone()
            //    {
            //        ZoneId = 4,
            //        Name = "Sureste"
            //    },
                  
            //};

            //context.Addresses.AddRange(addresses);
            //context.Categories.AddRange(categories);
            //context.Locals.AddRange(locals);
            //context.Machines.AddRange(machines);
            //context.Modes.AddRange(modes);
            //context.Pumpers.AddRange(pumpers);
            //context.PumperSongModes.AddRange(pumperSongModes);
            //context.PumperTournaments.AddRange(pumperTournaments);
            //context.Songs.AddRange(songs);
            //context.SongModes.AddRange(songModes);
            //context.Tournaments.AddRange(tournaments);
            //context.Zones.AddRange(zones);
            //await context.SaveChangesAsync();
        }
    }
}
