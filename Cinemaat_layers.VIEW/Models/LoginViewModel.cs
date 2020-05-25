using Cinemaat_layers.INTERFACES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinemaat_layers.VIEW.Models
{
    public class LoginViewModel : ILogin
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Dit veld is verplicht")]
        [Display(Name = "Emailadres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Dit veld is verplicht")]
        [Display(Name = "Wachtwoord")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
