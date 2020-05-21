using Cinemaat_layers.INTERFACES.Context;
using Cinemaat_layers.INTERFACES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL.Repository_Classes
{
    public class UserRegistrationRepository
    {
        private readonly IUserRegistrationContext _context;
        

        public UserRegistrationRepository(IUserRegistrationContext context)
        {
            _context = context;
        }

        public void CreateUser(IUserRegistration user)
        {
            _context.CreateUser(user);            
        }
    }
}
