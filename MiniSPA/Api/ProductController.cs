using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using BusinessLayer;
using MiniSPA.Models;

namespace MiniSPA.Api
{
    public class ProductController : ApiController
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public HttpResponseMessage Get()
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
            return Request.CreateResponse(HttpStatusCode.OK, model);
        }

        [HttpGet]
        public HttpResponseMessage Get(int id)
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
            return Request.CreateResponse(HttpStatusCode.OK, model);
        }
    }
}
