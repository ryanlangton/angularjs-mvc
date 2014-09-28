using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniSPA.Models
{
    public class ProductListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool InStock { get; set; }
    }
}