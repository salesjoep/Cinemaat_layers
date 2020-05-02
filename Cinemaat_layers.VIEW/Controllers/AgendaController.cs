using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaat_layers.DAL;
using Cinemaat_layers.LOGIC;
using Cinemaat_layers.VIEW.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinemaat_layers.VIEW.Controllers
{
    public class AgendaController : Controller
    {
        private readonly IAgendaContext _agendaContext;

        public AgendaController(IAgendaContext agendaContext)
        {
            _agendaContext = agendaContext;
        }
        public ActionResult Index()
        {
            var agendaLogic = new AgendaLogic(_agendaContext);
            var agendas = new List<AgendaViewModel>();

            foreach (var agenda in agendaLogic.GetAllAgendas())
            {
                agendas.Add(new AgendaViewModel
                {
                    MovieId = agenda.MovieId,
                    MovieHallId = agenda.MovieHallId,
                    IsValid = agenda.IsValid,
                    Time = agenda.Time
                });
            }
            return View(agendas);
        }
    }
}