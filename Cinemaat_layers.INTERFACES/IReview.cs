using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.INTERFACES
{
    public interface IReview
    {
        int ReviewId { get; set; }
        string Review { get; set; }
        int Rating { get; set; }
        int MovieId { get; set; }
    }
}
