using Cinemaat_layers.DAL.Repository_Classes;
using Cinemaat_layers.INTERFACES.Context;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.INTERFACES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.LOGIC
{
    public class LoginLogic : ILoginLogic
    {
        private LoginRepository Repository { get; }

        public LoginLogic(ILoginContext context)
        {
            Repository = new LoginRepository(context);
        }
        public bool Login(ILogin user)
        {
            return Repository.Login(user);
        }
    }
}
