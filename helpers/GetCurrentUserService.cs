using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace hohsys.API.helpers
{
    public class GetCurrentUserService : IGetCurrentUserService
    {
         private readonly IHttpContextAccessor httpContextAccessor;

            public GetCurrentUserService(IHttpContextAccessor _httpContextAccessor)
            {
                httpContextAccessor = _httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
            }
        public string GetCurrentUserName()
        {
            return httpContextAccessor.HttpContext.User.Identity.Name;
        }
    }
}