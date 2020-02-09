namespace hohsys.API.models
{
        // Medical indications emited by an user with F_Doctor, Admin, or Sponsor permission
    public class PacientComentary : MyEntity
    {
        // body of the comentary
        public string Body { get; set; }
        // related pacient
        public virtual Pacient Pacient { get; set; }
        // User who writes a comentary about the related pacient
        public virtual User User { get; set; }
    }
}