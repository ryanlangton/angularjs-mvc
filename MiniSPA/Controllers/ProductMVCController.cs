using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using MiniSPA.ActionFilters;
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

        // GET: Product
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
            return View(model);
        }
    }
}