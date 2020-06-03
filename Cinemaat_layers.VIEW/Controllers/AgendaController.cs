using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaat_layers.DAL;
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
        public ActionResult Avengers_Endgame()
        {
            var allRecords = _agendaLogic.GetAllAgendas();
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
                    Time = agenda.Time
                });
            }
            return View(agendas);
        }

        public ActionResult Agenda()
        {
            return View();
        }
    }
}