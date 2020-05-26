using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.INTERFACES.Logic
{
    public interface IAgendaLogic
    {
        void AddAgenda(int movieId, string movieName, int movieHallId, bool isValid, DateTime time);
        IEnumerable<IAgenda> GetAllAgendas();
    }
}
