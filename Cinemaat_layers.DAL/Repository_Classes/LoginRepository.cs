using Cinemaat_layers.INTERFACES.Context;
using Cinemaat_layers.INTERFACES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL.Repository_Classes
{
    public class LoginRepository
    {
        private readonly ILoginContext _context;
        public LoginRepository(ILoginContext context)
        {
            _context = context;
        }

        public bool Login(ILogin user)
        {
            return _context.Login(user);
        }
    }
}
