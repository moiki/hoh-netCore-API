namespace hohsys.API.models
{
    // Collection of phone numbers
    public class PhoneNumber: MyEntity
    {
        public string number { get; set; }
        public string Extention { get; set; }
        public virtual Employee Employee { get; set; }
    }
}