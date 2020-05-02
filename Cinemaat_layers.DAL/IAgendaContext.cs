using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public interface IAgendaContext
    {
        void Add(IAgenda agenda);

        IEnumerable<IAgenda> GetAll();

        IAgenda GetById(int id);
    }
}
