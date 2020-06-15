using Cinemaat_layers.DAL.Context_Classes;
using Cinemaat_layers.DAL.Dto;
using Cinemaat_layers.INTERFACES.Context;
using Cinemaat_layers.INTERFACES.Models;
using Cinemaat_Layers.Tests.MockData;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_Layers.Tests
{
    public class LoginContextTest
    {
        public ILoginContext sut = new LoginContext(MockConnection.connection);
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void LoginTest1()
        {
            ILogin user = new LoginDto()
            {
                UserId = 18,
                Email = "asp@gmail.com",
                Password = "asp"
            };
            var result = sut.Login(user);
            Assert.IsTrue(result);


        }

        [Test]
        public void LoginTest2()
        {
            ILogin user2 = new LoginDto()
            {
                UserId = 18,
                Email = "fake@gmail.com",
                Password = "Fake"
            };
            var result2 = sut.Login(user2);
            Assert.IsFalse(result2);


        }

    }
}
