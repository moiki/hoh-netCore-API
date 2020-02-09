namespace hohsys.API.models
{
    public class Email: MyEntity
    {
        // Collection of email addresses
        public string EmailAddress { get; set; }
        public virtual Employee Employee { get; set; }
    }
}