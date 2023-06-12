using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Islamic_clothing_website.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; }
        public int AmountPaid { get; set; }
        public string PaymentType { get; set; }
    }
}
