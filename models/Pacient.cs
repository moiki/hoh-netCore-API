using System;
using System.Collections.Generic;

namespace hohsys.API.models
{
    public class Pacient: MyEntity
    {
        public string FirstName1 { get; set; }
        public string FirstName2 { get; set; }
        public string LastName1 { get; set; }
        public string LastName2 { get; set; }
        public string FullName { get { return $"{FirstName1} {FirstName2} {LastName1} {LastName2}";}}
        public DateTime Birth { get; set; }
        public Boolean Gender { get; set; }
        // In data base it is taken like 1 for Male and 0 for Female
        public string StringGender { get { return Gender == true ? "M": "F";} }
        public string Address { get; set; }
        public virtual Clinic Clinic { get; set; }
        public virtual WorkRoute WorkRoute { get; set; }
        public virtual ICollection<MedicalRecord> MedicalRecords { get; set; }
        public virtual ICollection<PacientMedia> PacientMedia { get; set; }
        public virtual IEnumerable<PacientComentary> PacientComentaries { get; set; }

    }
}