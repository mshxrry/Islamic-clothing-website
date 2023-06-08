using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Islamic_clothing_website.Models
{
    public class TransactionReport
    {
        public int ReportId { get; set; }
        public ICollection<Customer> customers { get; set; }
        public ICollection<Product> products { get; set; }
        public ICollection<Order> orders { get; set; }
        public ICollection<Payment> payments { get; set; }


    }
}
