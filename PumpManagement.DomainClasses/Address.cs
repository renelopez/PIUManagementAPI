using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PumpManagement.DomainClasses
{
    public class Address    
    {
        [Key]
        public int AddressId { get; set; }
        public  string Name { get; set; }
        public  int ExternalNumber { get; set; }
        public  int InternalNumber { get; set; }
        public  string Colony { get; set; }
        public  int PostalCode { get; set; }
        public  string City { get; set; }
        public  string State { get; set; }
        public  string Type { get; set; }

        public int PumperId { get; set; }

        [ForeignKey("PumperId")]
        public Pumper Pumper { get; set; }
    }
}