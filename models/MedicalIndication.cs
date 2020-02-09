namespace hohsys.API.models
{
    // Medical indications emited by an user with <<Foreign Doctor Permission>>
    public class MedicalIndication : MyEntity
    {
        public string Body { get; set; }
        public virtual MedicalRecord MedicalRecord { get; set; }
        public virtual User User { get; set; }
    }
}