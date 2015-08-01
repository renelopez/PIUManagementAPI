using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PumpManagement.DomainClasses
{
    public class Zone
    {
        private ICollection<Pumper> _pumpers;

        public Zone()
        {
            _pumpers=new List<Pumper>();
        }

        [Key]
        public int ZoneId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Pumper> Pumpers
        {
            get { return _pumpers; }
            set { _pumpers = value; }
        }
    }
}