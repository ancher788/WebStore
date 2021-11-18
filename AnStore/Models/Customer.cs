using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnStore.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "The length Firstname must be from 1 to 50 symbols")]
        [Display(Name = "Firstname")]
        public string FirstnameCustomer { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "The length Lastname must be from 1 to 50 symbols")]
        [Display(Name = "Lastname")]
        public string LastnameCustomer { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "The length Lastname must be from 1 to 10 symbols")]
        [Display(Name = "Phone Number")]
        public string PhoneNumberCustomer { get; set; }

        public int JournalId { get; set; }
        public Journal Journal { get; set; }
    }
}
