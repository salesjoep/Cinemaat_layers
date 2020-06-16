using Cinemaat_layers.DAL.Context_Classes;
using Cinemaat_layers.INTERFACES.Context;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.LOGIC;
using Cinemaat_Layers.Tests.MockData;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_Layers.Tests.Logic
{
    public class LoginLogicTest
    {
        public static ILoginContext context = new LoginContext(MockConnection.connection);
        public ILoginLogic sut = new LoginLogic(context);

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void LoginUser1()
        {

            var result = sut.Login(MockUser.testUser);
            Assert.IsTrue(result);

            MockConnection.CloseConnection();
        }

        [Test]
        public void LoginUser2()
        {

            var result2 = sut.Login(MockUser.fakeUser);
            Assert.IsFalse(result2);

            MockConnection.CloseConnection();
        }
    }
}
