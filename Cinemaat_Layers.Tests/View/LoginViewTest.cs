using Cinemaat_layers.DAL.Context_Classes;
using Cinemaat_layers.INTERFACES.Context;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.LOGIC;
using Cinemaat_layers.LOGIC.Models;
using Cinemaat_layers.VIEW.Controllers;
using Cinemaat_Layers.Tests.MockData;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_Layers.Tests.View
{
    public class LoginViewTest
    {
        public static ILoginContext context = new LoginContext(MockConnection.connection);
        public static ILoginLogic logic = new LoginLogic(context);
        public LoginController sut = new LoginController(logic);

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void GetAllFavourites()
        {
            var result = sut.Index();
            Assert.IsNotNull(result);

            MockConnection.CloseConnection();
        }
    }
}
