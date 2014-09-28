using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniSPA.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [Display(Name = "Select Option:")]
        public IList<ProductOptionViewModel> Options { get; set; }
        public bool InStock { get; set; }
    }

    public class ProductOptionViewModel
    {
        public string Option { get; set; }
        public string ImageUrl { get; set; }
    }
}