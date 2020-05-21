using Cinemaat_layers.INTERFACES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cinemaat_layers.LOGIC.Models
{
    public class UserRegistration : IUserRegistration
    {
        [Key]
        public int UserId { get; set; }

        [Display(Name = "Gebruikersnaam")]
        [Required(ErrorMessage = "Dit veld is verplicht.")]
        public string Username { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Dit veld is verplicht.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Wachtwoord")]
        [Required(ErrorMessage = "Dit veld is verplicht.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Herhaal wachtwoord.")]
        [Required(ErrorMessage = "Wachtwoorden zijn niet gelijk.")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
