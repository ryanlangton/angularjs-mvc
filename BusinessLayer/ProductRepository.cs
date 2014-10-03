using System;
using System.Collections.Generic;
using System.Linq;

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
                    Price = 9.99,
                    Options = new List<ProductOption>()
                    {
                        new ProductOption() {Image = "gray_shirt1.png", Name = "Gray"},
                        new ProductOption() {Image = "green_shirt1.png", Name = "Green"},
                        new ProductOption() {Image = "blue_shirt1.png", Name = "Blue"}
                    }
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
            return GetAll().First(x => x.Id == id);
        }
    }
}
