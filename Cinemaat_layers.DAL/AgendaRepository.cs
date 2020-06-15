using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public class AgendaRepository
    {
        private readonly IAgendaContext _context;

        public AgendaRepository(IAgendaContext context)
        {
            _context = context;
        }

        public void Add(IAgenda agenda)
        {
            _context.Add(agenda);
        }

        public IEnumerable<IAgenda> GetAll(int movieId)
        {
            return _context.GetAll(movieId);
        }
    }
}
