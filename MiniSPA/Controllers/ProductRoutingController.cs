using System.Web.Mvc;

namespace MiniSPA.Controllers
{
    [Authorize]
    public class ProductRoutingController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
    }
}