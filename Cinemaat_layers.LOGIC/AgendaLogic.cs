using Cinemaat_layers.DAL;
using Cinemaat_layers.INTERFACES;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.LOGIC
{
    public class AgendaLogic : IAgendaLogic
    {
        public AgendaLogic(IAgendaContext context)
        {
            Repository = new AgendaRepository(context);
        }

        private AgendaRepository Repository { get; }

        public void AddAgenda(int agendaId, int movieId, string movieName,int movieHallId, bool isValid, DateTime time, double price)
        {
            var agenda = new Agenda
            {
                AgendaId = agendaId,
                MovieId = movieId,
                MovieName = movieName,
                MovieHallId = movieHallId,
                IsValid = isValid,
                Time = time,
                Price = price
            };
            Repository.Add(agenda);
        }

        public IEnumerable<IAgenda> GetAllAgendas()
        {
            return Repository.GetAll();
        }
    }
}
