using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
    }

    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAll()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Image = "gray_shirt1.png",
                    Name = "T-Shirt",
                    InStock = true,
                    Options = new List<ProductOption>()
                    {
                        new ProductOption() {Image = "gray_shirt1.png", Option = "Gray"},
                        new ProductOption() {Image = "green_shirt1.png", Option = "Green"}
                    }
                }
            };
        }

        public Product GetById(int id)
        {
            return GetAll().First(x => x.Id == id);
        }
    }
}
