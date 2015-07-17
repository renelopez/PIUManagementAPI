using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PumpManagement.Data
{
    public class Tournament
    {

        private ICollection<PumperTournament> _pumperTournaments;

        public Tournament()
        {
            _pumperTournaments=new List<PumperTournament>();
        }
        public int TournamentId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string LogoURL { get; set; }

        [ForeignKey("LocalId")]
        public Local Local { get; set; }

        public int LocalId { get; set; }
        public virtual ICollection<PumperTournament> PumperTournaments
        {
            get { return _pumperTournaments; }
            set { _pumperTournaments = value; }
        }


    }
}