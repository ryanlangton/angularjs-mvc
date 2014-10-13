using System;
using System.Web.Mvc;

namespace MiniSPA.Controllers
{
    [Authorize]
    public class CartController: Controller
    {
        public CartController()
        {
            ViewBag.AngularModule = "cartModule";
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddToCart()
        {
            throw new NotImplementedException();
        }
    }
}