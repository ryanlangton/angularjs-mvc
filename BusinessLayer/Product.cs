using System.Collections;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class Product
    {
        public Product()
        {
            Options = new List<ProductOption>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public IList<ProductOption> Options { get; set; }
        public bool InStock { get; set; }
    }
}