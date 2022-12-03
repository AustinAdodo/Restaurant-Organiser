using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant_Menu_Organiser.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Key]
        [Remote (action:"ExistingEmailCheck", controller:"Home")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords Created Must Have a Match with Confirm Password")]
        public string ConfirmPasword { get; set; }
    }
}
