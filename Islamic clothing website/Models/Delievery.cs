using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Islamic_clothing_website.Models
{
    public class Delievery
    {
        public int DelieveryId { get; set; }
        // Changes the display name 
        [Display(Name = "Delievery Date")]
        public DateTime DelieveryDate { get; set; }
        [Required(ErrorMessage = "Delievery Address is required")]
        [Display(Name = "Delievery Address")]
        public string DelieveryAddress { get; set; }
        public ICollection<Customer> customers { get; set; }


    }
}

