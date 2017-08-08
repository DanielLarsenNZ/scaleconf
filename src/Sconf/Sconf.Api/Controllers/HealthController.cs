using System;
using System.Web.Http;

namespace Sconf.Api.Controllers
{
    public class HealthController : ApiController
    {
        // GET: api/Health
        public dynamic Get()
        {
            return new { Status = "Ok", Version = "1.0.0", Now = DateTime.UtcNow };
        }
    }
}
