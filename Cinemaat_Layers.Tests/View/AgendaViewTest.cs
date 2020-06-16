using Cinemaat_layers.DAL;
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
    public class AgendaViewTest
    {
        public static IAgendaContext context = new AgendaContext(MockConnection.connection);
        public static IAgendaLogic logic = new AgendaLogic(context);
        public AgendaController sut = new AgendaController(logic);

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void GetAgenda()
        {
            var result = sut.Agenda(1);
            Assert.IsNotNull(result);

            MockConnection.CloseConnection();
        }
    }
}
