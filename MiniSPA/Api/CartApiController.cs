using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using MiniSPA.Models;

namespace MiniSPA.Api
{
    public class CartApiController : ApiController
    {
        [HttpPost]
        [Authorize]
        public HttpResponseMessage Add(CartItemViewModel item)
        {
            var userId = User.Identity.GetUserId();
            // store in db tied to userId
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPost]
        [Authorize]
        public HttpResponseMessage Remove(CartItemViewModel item)
        {
            var userId = User.Identity.GetUserId();
            // remove items from db
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
