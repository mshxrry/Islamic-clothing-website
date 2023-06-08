using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Islamic_clothing_website.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get;set; }
        public string OrderName { get; set; }
        public ICollection<Customer> customers { get; set; }

    }
}
