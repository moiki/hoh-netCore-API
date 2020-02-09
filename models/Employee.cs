using System.Collections.Generic;

namespace hohsys.API.models
{
    // Member of house of Hope who works with children
    public class Employee: MyEntity
    {
        public string FirstName1 { get; set; }
        public string FirstName2 { get; set; }
        public string LastName1 { get; set; }
        public string LastName2 { get; set; }
        public string ProfilePicture { get; set; }
        public string FullName { get { return $"{FirstName1} {FirstName2} {LastName1} {LastName2}";}}
        public string Address { get; set; }
        public virtual Clinic Clinic { get; set; }
        public virtual WorkRoute WorkRoute { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }

    }
}