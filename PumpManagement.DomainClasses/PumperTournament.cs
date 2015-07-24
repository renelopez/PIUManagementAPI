using System.ComponentModel.DataAnnotations.Schema;

namespace PumpManagement.DomainClasses
{
    public class PumperTournament
    {
        public int PumperTournamentId { get; set; }
        
        public virtual Pumper Pumper { get; set; }

        public virtual Tournament  Tournament { get; set; }

        public int PumperId { get; set; }
        public int TournamentId { get; set; }


    }
}