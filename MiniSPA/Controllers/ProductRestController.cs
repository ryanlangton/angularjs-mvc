using System.Linq;
using System.Web.Mvc;
using BusinessLayer;
using MiniSPA.Models;

namespace MiniSPA.Controllers
{
    public class ProductRestController : Controller
    {
        private readonly IProductRepository _repository;

        public ProductRestController(IProductRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            var products = _repository.GetAll();
            var model = products.Select(x => new ProductListViewModel()
            {
                Id = x.Id,
                Image = x.Image,
                InStock = x.InStock,
                Name = x.Name,
                Price = x.Price
            });
            return View(model);
        }

        public ActionResult Detail(int id)
        {
            return View(id);
        }
    }
}