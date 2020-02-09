using System.Collections.Generic;

namespace hohsys.API.models
{
    // Treatment center of House of Hope
    public class Clinic: MyEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Pacient> Pacients { get; set; }
    }
}