using System.Collections.Generic;

namespace hohsys.API.models
{
    public class MediaCategory: MyEntity
    {
        public string CategoryName { get; set; }
        public virtual ICollection<WorkRouteMedia> WorkRouteMedia { get; set; }
        public virtual ICollection<PacientMedia> PacientMedia { get; set; }
    }
}