using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnStore.Models
{
    public class Operation
    {
        public int Id { get; set; }

        [Required]
        [Range(1, 500000000, ErrorMessage = "Invalid count")]
        [Display(Name = "Sum Goods")]
        public double SumGoods { get; set; }

        [Required]
        [Range(0.0001, 500000000, ErrorMessage = "Invalid count")]
        [Display(Name = "Count Goods")]
        public double CountGoods { get; set; }


        public List<Journal> Journals { get; set; } = new List<Journal>();
        
        public List<Goods> Goods { get; set; } = new List<Goods>();
        
    }
}
