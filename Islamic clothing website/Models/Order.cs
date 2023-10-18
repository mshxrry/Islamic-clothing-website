using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Islamic_clothing_website.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        // this code sets the order date to only date and no time
        [DataType(DataType.Date)]
        [Display (Name ="Order Date")]
        public DateTime OrderDate { get;set; }
        [Display (Name ="Order Name")]
        public string OrderName { get; set; }
        public ICollection<Customer> customers { get; set; }

    }
}
