﻿using Cinemaat_layers.DAL.Repository_Classes;
using Cinemaat_layers.INTERFACES.Context;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.INTERFACES.Models;
using Cinemaat_layers.LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.LOGIC
{
    public class UserRegistrationLogic : IUserRegistrationLogic
    {
        private UserRegistrationRepository Repository { get; }
        public UserRegistrationLogic(IUserRegistrationContext context)
        {
            Repository = new UserRegistrationRepository(context);
        }
        public void CreateUser(IUserRegistration user)
        {
            var _user = new UserRegistration
            {
                UserId = user.UserId,
                Username = user.Username,
                Email = user.Email,
                Password = user.Password,
                ConfirmPassword = user.ConfirmPassword
            };
            Repository.CreateUser(_user);
        }
        
    }
}
