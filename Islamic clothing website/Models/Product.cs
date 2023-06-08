using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Islamic_clothing_website.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
    }
}
