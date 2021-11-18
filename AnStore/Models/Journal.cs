using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AnStore.Models
{
    public class Journal
    {
        [Key]
        public int Id { get; set; }
        public DateTime? DataSold { get; set; }

        [Range(0, 500000000, ErrorMessage = "Invalid count")]
        public double SoldSum { get; set; }
        public bool IsSendGoods { get; set; }
        public bool IsSold { get; set; }

        [Required]        
        public List<Customer> Customer { get; set; }
        public int MyProperty { get; set; }
    }
}
