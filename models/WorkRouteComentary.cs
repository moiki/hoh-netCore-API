namespace hohsys.API.models
{
    public class WorkRouteComentary: MyEntity
    {
        // body of the comentary
        public string Body { get; set; }
        // related WorkRoute
        public virtual WorkRoute WorkRoute { get; set; }
        // User who writes a comentary about the related WorkRoute
        public virtual User User { get; set; }
    }
}