using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Islamic_clothing_website.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Display(Name ="Category Name")]
        
        public string CategoryName { get; set; }
        [Display(Name ="Product Name")]
        public string ProductName { get; set; }
    }
}
