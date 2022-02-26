using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Services
{

    public class ServicesIdentityService : IServicesIdentityService
    {
        private IHttpContextAccessor _httpContextAccessor;

        public ServicesIdentityService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetUserId =>
            _httpContextAccessor.HttpContext.User.FindFirst("nameidentifier").Value;
    }
}
