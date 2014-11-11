using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;

namespace MiniSPA.Api
{
    [Authorize]
    public class RoleController: ApiController
    {
        public HttpResponseMessage Get()
        {
            var roles = Roles.GetRolesForUser();
            var user = new
            {
                IsAdmin = roles.Contains("Admin"),
                IsUser = roles.Contains("User")
            };
            return Request.CreateResponse(HttpStatusCode.OK, user);
        }
    }
}