using System.ComponentModel.DataAnnotations;

namespace PumpManagement.DomainClasses
{
    public class Mode
    {
        [Key]
        public int ModeId { get; set; }
        public string Name { get; set; }
    }
}