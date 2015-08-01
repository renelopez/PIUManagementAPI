using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PumpManagement.DomainClasses
{
    public class Machine    
    {
        [Key]
        public int MachineId { get; set; }
        public string Name { get; set; }
        public string MK { get; set; }
        public string Model { get; set; }
        public string GameVersion { get; set; }
        public int CreditPrice { get; set; }

        public int? LocalId { get; set; }


        [ForeignKey("LocalId")]
        public virtual Local Local { get; set; }
    }
}