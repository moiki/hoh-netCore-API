using System.Collections.Generic;

namespace hohsys.API.models
{
    // Work routes which therapists goes to treat kids
    public class WorkRoute: MyEntity
    {
        public string RouteName { get; set; }
        public string Description { get; set; }
        public string FeaturedImage { get; set; }
        // from place (buildin place)
        public virtual Clinic Clinic { get; set; }
        // Collection of related work route photos 
        public virtual ICollection<WorkRouteMedia> WorkRouteMedia { get; set; }
        // destination places
        public virtual ICollection<Destination> Destinations { get; set; }
        // Days when a team (related employes) travels... (Related entity collection) 
        public virtual ICollection<Schedule> Schedules { get; set; }
        // Doctors and/or teachers included in this work route to treat childern
        public virtual ICollection<Employee> Employees { get; set; }
        // Pacients (children) included in this work route to be treated (Related entity collection) 
        public virtual ICollection<Pacient> Pacients { get; set; }
        // Comentaries about this work route (Related entity collection) 
        public virtual ICollection<WorkRouteComentary> WorkRouteComentaries { get; set; }
    }
}