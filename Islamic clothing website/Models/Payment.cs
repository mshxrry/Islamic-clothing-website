using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Islamic_clothing_website.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; }
        // this data annotation adds the currency sign to the amount paid column
        [DataType(DataType.Currency)]
        [Range (1,1000, ErrorMessage = "Please enter between $1 and $1000")]
        public decimal AmountPaid { get; set; }
        public string PaymentType { get; set; }
    }
}
