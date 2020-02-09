namespace hohsys.API.models
{
    public class PacientMedia: MyEntity
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public virtual MediaCategory MediaCategory { get; set; }
        public virtual Pacient Pacient { get; set; }
    }
}