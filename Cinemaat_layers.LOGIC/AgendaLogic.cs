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
        private readonly IAgendaContext agendaContext;
        public AgendaLogic(IAgendaContext context)
        {
            agendaContext = context;
        }


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
            agendaContext.Add(agenda);
        }

        public IEnumerable<IAgenda> GetAllAgendas(int movieId)
        {
            return agendaContext.GetAll(movieId);
        }
    }
}
