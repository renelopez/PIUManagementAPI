using System.ComponentModel.DataAnnotations.Schema;

namespace PumpManagement.Data
{
    public class Machine    
    {
        public int Id { get; set; }
        public string MK { get; set; }
        public string Model { get; set; }
        public string GameVersion { get; set; }
        public int CreditPrice { get; set; }

        public int LocalId { get; set; }


        [ForeignKey("LocalId")]
        public virtual Local Local { get; set; }
    }
}