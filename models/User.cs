using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace hohsys.API.models
{
    public class User: IdentityUser<int>
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Profession { get; set; }
        public string FullName { get { return $"{Name} {Lastname}"; } }
        public string ProfilePicture { get; set; }
       public bool IsActive { get; set; }
        public DateTimeOffset DateAdded { get; set; }
        public DateTimeOffset DateUpdated { get; set; }
        public virtual ICollection<MedicalIndication> MedicalIndications { get; set; }
        public virtual ICollection<WorkRouteComentary> WorkRouteComentaries { get; set; }
        public virtual ICollection<PacientComentary> PacientComentaries { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}