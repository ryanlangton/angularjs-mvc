using System.Linq;
using System.Web.Mvc;
using BusinessLayer;
using MiniSPA.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MiniSPA.Controllers
{
    public class ProductAngularController : Controller
    {
        private readonly IProductRepository _repository;

        public ProductAngularController(IProductRepository repository)
        {
            _repository = repository;
        }

        //[Authorize]
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

        //[Authorize]
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
                    Image = x.Image,
                    Name = x.Name
                }).ToList(),
                Price = product.Price
            };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var serialized = JsonConvert.SerializeObject(model, Formatting.None, settings);
            return View(model: serialized);
        }
    }
}