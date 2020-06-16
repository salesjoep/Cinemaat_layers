using Cinemaat_layers.INTERFACES.Models;
using Cinemaat_layers.LOGIC.Models;
using Cinemaat_layers.VIEW.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_Layers.Tests.MockData
{
    public static class MockUser
    {
        public static ILogin testUser = new Login()
        {
            UserId = 18,
            Email = "asp@gmail.com",
            Password = "asp"            
        };

        public static ILogin fakeUser = new Login()
        {
            UserId = 120,
            Email = "fakeUser@gmail.com",
            Password = "fake"
        };

        public static LoginViewModel testUserViewModel = new LoginViewModel()
        {
            UserId = 18,
            Email = "asp@gmail.com",
            Password = "asp"
        };
    }
}
