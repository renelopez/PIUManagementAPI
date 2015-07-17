using System.Collections.Generic;

namespace PumpManagement.Data
{
    public class Zone
    {
        private ICollection<Pumper> _pumpers;

        public Zone()
        {
            _pumpers=new List<Pumper>();
        }

 
        public int ZoneId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Pumper> Pumpers
        {
            get { return _pumpers; }
            set { _pumpers = value; }
        }
    }
}