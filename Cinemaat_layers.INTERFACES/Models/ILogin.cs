using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cinemaat_layers.INTERFACES.Models
{
    public interface ILogin
    {
        int UserId { get; set; }
        [Required(ErrorMessage = "Dit veld is verplicht")]
        [Display(Name = "Emailadres")]
        string Email { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [Display(Name = "Wachtwoord")]
        [DataType(DataType.Password)]
        string Password { get; set; }
    }
}
