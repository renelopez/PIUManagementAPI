using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PumpManagement.DomainClasses
{
    public class Local
    {
        private ICollection<Machine> _machines;
        private ICollection<Tournament> _tournaments;

        public Local()
        {
            _machines=new List<Machine>();
            _tournaments=new List<Tournament>();
        }
        [Key]
        public int LocalId { get; set; }
        public string Name { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public string StartDay { get; set; }
        public string EndDay { get; set; }

        public int? AddressId { get; set; }

        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }
        public virtual ICollection<Machine> Machines
        {
            get { return _machines; }
            set { _machines = value; }
        }
        public virtual ICollection<Tournament> Tournaments
        {
            get { return _tournaments; }
            set { _tournaments = value; }
        }

    }
}