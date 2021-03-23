using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebSiteValidation.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Please enter Name.")]
        [RegularExpression("[a-zA-Z]+", ErrorMessage = "Can only contain letters.")]
        [StringLength(20, ErrorMessage = "Name cannot be longer than 20 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Address.")]
        [StringLength(30, ErrorMessage = "Address cannot be longer than 30 characters.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter Phone Number.")]
        [Range(1000000000, 9999999999, ErrorMessage = "Phone Number must be 10 Numbers Long without dashes.")]
        public Int64 PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter Phone Number.")]
        [Range(18, 117, ErrorMessage = "Age must be between 18 and 117.")]
        public int Age { get; set; }





    }
}
