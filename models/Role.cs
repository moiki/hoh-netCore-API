using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace hohsys.API.models
{
    public class Role: IdentityRole<int>
    {
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}