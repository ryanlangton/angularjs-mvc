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
        public double Price { get; set; }
        public string Image { get; set; }
        public bool InStock { get; set; }
    }
}