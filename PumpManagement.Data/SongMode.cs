using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PumpManagement.Data
{
    public class SongMode
    {
        public int SongModeId { get; set; }

        [ForeignKey("SongId")]
        public virtual Song Song { get; set; }
        [ForeignKey("ModeId")]
        public virtual Mode Mode { get; set; }

        public int SongId { get; set; }
        public int ModeId { get; set; }

        public virtual ICollection<PumperSongMode> PumperSongModes { get; set; }

        public int Difficulty { get; set; }
    }
}