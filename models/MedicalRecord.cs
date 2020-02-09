using System.Collections.Generic;

namespace hohsys.API.models
{
    public class MedicalRecord: MyEntity
    {   
        public virtual Pacient Pacient { get; set; }
        public virtual ICollection<MedicalIndication> MedicalIndications { get; set; }
    }
}