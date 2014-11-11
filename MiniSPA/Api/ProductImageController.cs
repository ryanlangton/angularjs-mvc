using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer;

namespace MiniSPA.Api
{
    [Authorize]
    public class ProductImageController : ApiController
    {
        private readonly IProductRepository _repository;

        public ProductImageController(IProductRepository repository)
        {
            _repository = repository;
        }

        public HttpResponseMessage Get(int id)
        {
            var image = _repository.GetImageById(id);
            return Request.CreateResponse(HttpStatusCode.OK, image);
        }
    }
}
