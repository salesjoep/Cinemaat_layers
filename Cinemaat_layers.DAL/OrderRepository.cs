using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public class OrderRepository
    {
        private readonly IOrderContext _context;

        public OrderRepository(IOrderContext context)
        {
            _context = context;
        }

        public void Add(IOrder order)
        {
            _context.Add(order);
        }

        public IEnumerable<IOrder> GetAll()
        {
            return _context.GetAll();
        }
    }
}
