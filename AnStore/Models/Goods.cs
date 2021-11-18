using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnStore.Models
{
    public class Goods
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "The length Name must be from 1 to 50 symbols")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Range(0.001, 500000000, ErrorMessage = "Invalid count")]
        [Display(Name = "Goods Count")]
        public double GoodsCount { get; set; }

        [StringLength(500, MinimumLength = 1, ErrorMessage = "The length string must be from 1 to 500 symbols")]
        public string Imagine { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 1, ErrorMessage = "The length Description must be from 1 to 500 symbols")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Range(1, 500000000, ErrorMessage = "Invalid price")]
        public double PriceReceivedGoods { get; set; }

        [Range(1, 500000000, ErrorMessage = "Invalid price")]
        public double PriceSellingGoods { get; set; }

        [Required]
        public DateTime DateReceived { get; set; }

        public DateTime? DateSelling { get; set; }
        
        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
