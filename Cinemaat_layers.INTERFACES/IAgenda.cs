using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.INTERFACES
{
    public interface IAgenda
    {
        int AgendaId { get; set; }
        int MovieId { get; set; }
        string MovieName { get; set; }
        int MovieHallId { get; set; }
        bool IsValid { get; set; }
        DateTime Time { get; set; }
    }
}
