using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericServices;
using PumpManagement.DomainClasses;

namespace PumpManagement.DataLayer
{
    public class PumpManagementContext : DbContext,IGenericServicesDbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Local> Locals { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<Mode> Modes { get; set; }
        public DbSet<Pumper> Pumpers { get; set; }
        public DbSet<PumperSongMode> PumperSongModes { get; set; }
        public DbSet<PumperTournament> PumperTournaments { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<SongMode> SongModes { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Zone> Zones { get; set; }
    }
}
