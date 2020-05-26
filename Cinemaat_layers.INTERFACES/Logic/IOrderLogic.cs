using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.INTERFACES.Logic
{
    public interface IOrderLogic
    {
        void CreateOrder(IOrder _order);
        IEnumerable<IOrder> GetAllOrders();
    }
}
