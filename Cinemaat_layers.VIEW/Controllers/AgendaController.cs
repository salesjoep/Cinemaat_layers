using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.LOGIC;
using Cinemaat_layers.VIEW.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinemaat_layers.VIEW.Controllers
{
    public class AgendaController : Controller
    {
        private readonly IAgendaLogic _agendaLogic;

        public AgendaController(IAgendaLogic agendaLogic)
        {
            _agendaLogic = agendaLogic;
        }
        public ActionResult Avengers_Endgame(int movieId)
        {
            var allRecords = _agendaLogic.GetAllAgendas(movieId);
            var agendas = new List<AgendaViewModel>();

            foreach (var agenda in allRecords)
            {
                agendas.Add(new AgendaViewModel
                {
                    AgendaId = agenda.AgendaId,
                    MovieId = agenda.MovieId,
                    MovieName = agenda.MovieName,
                    MovieHallId = agenda.MovieHallId,
                    IsValid = agenda.IsValid,
                    Time = agenda.Time,
                    Price = agenda.Price
                });
            }
            return View(agendas);
        }

        public ActionResult Agenda(int movieId)
        {
            var allRecords = _agendaLogic.GetAllAgendas(movieId);
            var agendas = new List<AgendaViewModel>();

            foreach (var agenda in allRecords)
            {
                agendas.Add(new AgendaViewModel
                {
                    AgendaId = agenda.AgendaId,
                    MovieId = agenda.MovieId,
                    MovieName = agenda.MovieName,
                    MovieHallId = agenda.MovieHallId,
                    IsValid = agenda.IsValid,
                    Time = agenda.Time,
                    Price = agenda.Price
                });
            }
            return View(agendas);
        }
    }
}