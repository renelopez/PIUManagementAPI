using System.ComponentModel.DataAnnotations.Schema;

namespace PumpManagement.Data
{
    public class PumperTournament
    {
        public int PumperTournamentId { get; set; }
        
        [ForeignKey("PumperId")]
        public virtual Pumper Pumper { get; set; }

        [ForeignKey("TournamentId")]
        public virtual Tournament  Tournament { get; set; }

        public int PumperId { get; set; }
        public int TournamentId { get; set; }


    }
}