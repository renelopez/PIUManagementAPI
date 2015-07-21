using System.ComponentModel.DataAnnotations.Schema;

namespace PumpManagement.DomainClasses
{
    public class PumperSongMode
    {
        public int PumperSongModeID { get; set; }

        [ForeignKey("SongModeId")]
        public virtual SongMode SongMode { get; set; }

        [ForeignKey("PumperId")]
        public virtual Pumper Pumper { get; set; }

        public int SongModeID { get; set; }
        public int PumperID { get; set; }

        public int Score { get; set; }
        public string Grade { get; set; }


    }
}