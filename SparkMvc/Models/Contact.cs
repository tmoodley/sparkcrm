using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SparkMvc.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "The First Name is required")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "The Last Name is required")] 
        public string LastName { get; set; }
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Your must provide a Phone Number")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string Phone { get; set; }
        [Display(Name = "Address")]
        [Required(ErrorMessage = "The Address is required")]
        public string Address { get; set; }
        [Display(Name = "City")]
        [Required(ErrorMessage = "The City is required")]
        public string City { get; set; }
        [Display(Name = "Postal Code")]
        [Required(ErrorMessage = "The Postal Code is required")]
        [DataType(DataType.PostalCode)] 
        public string PostalCode { get; set; }
        public string Image { get; set; }
    }
}