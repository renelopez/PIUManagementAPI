using System.Collections.Generic;

namespace PumpManagement.DomainClasses
{
    public class Song
    {
        private ICollection<SongMode> _songModes;

        public Song()
        {
            _songModes=new List<SongMode>();
        }
        public int SongId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int BPM { get; set; }
        public virtual ICollection<SongMode> SongModes
        {
            get { return _songModes; }
            set { _songModes = value; }
        }
    }
}