using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PumpManagement.DomainClasses;

namespace PumpManagement.DataLayer
{
    public class PumpManagementContext : DbContext
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PumperTournament>()
                .HasRequired(a=>a.Pumper)
                .WithMany()
                .HasForeignKey(u=>u.PumperId).WillCascadeOnDelete(false);

            modelBuilder.Entity<PumperTournament>()
                .HasRequired(a => a.Tournament)
                .WithMany()
                .HasForeignKey(u => u.TournamentId).WillCascadeOnDelete(false);
        }
    }
}