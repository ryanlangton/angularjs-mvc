using System.Linq;
using System.Web.Mvc;
using BusinessLayer;
using MiniSPA.Models;

namespace MiniSPA.Controllers
{
    [Authorize]
    public class ProductMvcController : Controller
    {
        private readonly IProductRepository _repository;

        public ProductMvcController(IProductRepository repository)
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

        [Authorize(Roles="Admin")]
        public ActionResult Detail(int id)
        {
            var product = _repository.GetById(id);
            var model = new ProductViewModel()
            {
                Id = product.Id,
                Image = product.Image,
                InStock = product.InStock,
                Name = product.Name,
                Description = product.Description,
                Options = product.Options.Select(x => new ProductOptionViewModel()
                {
                    Id = x.Id,
                    Image = x.Image,
                    Name = x.Name
                }).ToList(),
                Price = product.Price
            };
            return View(model);
        }
    }
}