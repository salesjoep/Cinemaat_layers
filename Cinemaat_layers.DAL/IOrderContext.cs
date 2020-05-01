using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public interface IOrderContext
    {

        void Add(IOrder order);

        IEnumerable<IOrder> GetAll();

        IOrder GetById(int id);
    }
}
