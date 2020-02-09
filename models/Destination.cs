namespace hohsys.API.models
{
    public class Destination: MyEntity
    {
        public string DestinationName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string GoogleMapEmbedUrl { get; set; }
        public virtual WorkRoute WorkRoute { get; set; }
    }
}