using System.Collections.Generic;

namespace PumpManagement.DomainClasses
{
    public class Category
    {
        private ICollection<Pumper> _pumpers; 
        public Category()
        {
            _pumpers=new List<Pumper>();
        }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Pumper> Pumpers
        {
            get { return _pumpers; }
            set { _pumpers = value; }
        }
    }
}