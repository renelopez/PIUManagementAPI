using System.ComponentModel.DataAnnotations.Schema;

namespace PumpManagement.Data
{
    public class Address    
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public  int ExternalNumber { get; set; }
        public  int InternalNumber { get; set; }
        public  string Colony { get; set; }
        public  int PostalCode { get; set; }
        public  string City { get; set; }
        public  string State { get; set; }
        public  string Type { get; set; }

        public int LocalId { get; set; }
        public int PumperId { get; set; }

        [ForeignKey("LocalId")]
        public virtual Local Local { get; set; }

        [ForeignKey("PumperId")]
        public Pumper Pumper { get; set; }
    }
}