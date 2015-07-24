using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PumpManagement.DataLayer.DTOs
{
    public class SongListDTO
    {
        public int SongId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int BPM { get; set; }
    }
}
