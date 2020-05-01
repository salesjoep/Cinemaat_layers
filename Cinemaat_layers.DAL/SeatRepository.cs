using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public class SeatRepository
    {
        private readonly ISeatContext _context;

        public SeatRepository(ISeatContext context)
        {
            _context = context;
        }

        public void Add(ISeat seat)
        {
            _context.Add(seat);
        }

        public IEnumerable<ISeat> GetAll()
        {
            return _context.GetAll();
        }
    }
}
