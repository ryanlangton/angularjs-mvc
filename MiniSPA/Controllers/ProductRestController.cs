using System.Web.Mvc;

namespace MiniSPA.Controllers
{
    [Authorize]
    public class ProductRestController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            return View(id);
        }
    }
}