﻿using Cinemaat_layers.INTERFACES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cinemaat_layers.LOGIC.Models
{
    public class Login : ILogin
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
