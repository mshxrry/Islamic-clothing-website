using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Islamic_clothing_website.Models
{
    public class Delievery
    {
        public int DelieveryId { get; set; }
        public DateTime DelieveryDate { get; set; }
        public string DelieveryAddress { get; set; }
        public ICollection<Customer> customers { get; set; }


    }
}

