using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinemaat_layers.VIEW.Models
{
    public class ReviewViewModel : IReview
    {
        public int ReviewId { get; set; }
        public string Review { get; set; }
        public int Rating { get; set; }
        public int MovieId { get; set; }
    }
}
