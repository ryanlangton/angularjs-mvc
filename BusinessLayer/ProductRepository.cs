using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace BusinessLayer
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        string GetImageById(int id);
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
                    Price = 9.99,
                    Options = GetOptions().Where(x => x.ProductId == 1).ToList()
                },  
                new Product()
                {
                    Id = 2,
                    Price = 299.99,
                    Image = "iPhone6.jpg",
                    Name = "iPhone 6",
                    InStock = false,
                },
                new Product()
                {
                    Id = 3,
                    Price = 21.95,
                    Name = "Lee Jeans",
                    InStock = true
                }
            };
        }

        public Product GetById(int id)
        {
            Thread.Sleep(5000);
            return GetAll().First(x => x.Id == id);
        }

        public string GetImageById(int id)
        {
            return GetOptions().FirstOrDefault(x => x.Id == id).Image;
        }

        public List<ProductOption> GetOptions()
        {
            return new List<ProductOption>()
            {
                new ProductOption() {Id = 1, Image = "gray_shirt1.png", Name = "Gray", ProductId = 1},
                new ProductOption() {Id = 2, Image = "green_shirt1.png", Name = "Green", ProductId = 1},
                new ProductOption() {Id = 3, Image = "blue_shirt1.png", Name = "Blue", ProductId = 1}
            };
        }
    }
}
