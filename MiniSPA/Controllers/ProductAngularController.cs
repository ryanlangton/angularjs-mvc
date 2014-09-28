using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using MiniSPA.Models;

namespace MiniSPA.Controllers
{
    public class ProductAngularController : Controller
    {
        private readonly IProductRepository _repository;

        public ProductAngularController(IProductRepository repository)
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
                ImageUrl = x.Options[0].Image,
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
                ImageUrl = product.Options[0].Image,
                InStock = product.InStock,
                Name = product.Name,
                Description = product.Description,
                Options = product.Options.Select(x => new ProductOptionViewModel()
                {
                    ImageUrl = x.Image,
                    Option = x.Option
                }).ToList(),
                Price = product.Price
            };
            return View(model);
        }
    }
}