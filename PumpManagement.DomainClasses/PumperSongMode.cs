using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PumpManagement.DomainClasses
{
    public class PumperSongMode
    {
        [Key]
        public int PumperSongModeID { get; set; }

        [ForeignKey("SongModeId")]
        public virtual SongMode SongMode { get; set; }

        [ForeignKey("PumperId")]
        public virtual Pumper Pumper { get; set; }

        public int? SongModeId { get; set; }
        public int? PumperId { get; set; }

        public int Score { get; set; }
        public string Grade { get; set; }


    }
}