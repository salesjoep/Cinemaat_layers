﻿using Cinemaat_layers.DAL;
using Cinemaat_layers.INTERFACES;
using Cinemaat_layers.LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.LOGIC
{
    public class AgendaLogic
    {
        public AgendaLogic(IAgendaContext context)
        {
            Repository = new AgendaRepository(context);
        }

        private AgendaRepository Repository { get; }

        public void AddAgenda(int movieId, int movieHallId, bool isValid, DateTime time)
        {
            var agenda = new Agenda
            {
                MovieId = movieId,
                MovieHallId = movieHallId,
                IsValid = isValid,
                Time = time
            };
            Repository.Add(agenda);
        }

        public IEnumerable<IAgenda> GetAllAgendas()
        {
            return Repository.GetAll();
        }
    }
}