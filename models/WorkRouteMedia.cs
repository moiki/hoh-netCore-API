namespace hohsys.API.models
{
    public class WorkRouteMedia : MyEntity
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public virtual MediaCategory MediaCategory { get; set; }
        public virtual WorkRoute WorkRoute { get; set; }
    }
}