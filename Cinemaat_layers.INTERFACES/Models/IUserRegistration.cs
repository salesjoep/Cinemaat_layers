using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cinemaat_layers.INTERFACES.Models
{
    public interface IUserRegistration
    {
        [Key]
        int UserId { get; set; }

        [Display(Name = "Gebruikersnaam")]
        [Required(ErrorMessage = "Dit veld is verplicht.")]
        string Username { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Dit veld is verplicht.")]
        [DataType(DataType.EmailAddress)]
        string Email { get; set; }

        [Display(Name = "Wachtwoord")]
        [Required(ErrorMessage = "Dit veld is verplicht.")]
        [DataType(DataType.Password)]
        string Password { get; set; }

        [Display(Name = "Herhaal wachtwoord.")]
        [Required(ErrorMessage = "Wachtwoorden zijn niet gelijk.")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        string ConfirmPassword { get; set; }
    }
}
