using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnStore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "The length Name must be from 1 to 50 symbols")]
        public string Name { get; set; }

        public List<Goods> Goods { get; set; }
    }
}
