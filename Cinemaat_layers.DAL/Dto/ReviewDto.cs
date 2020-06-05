using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL.Dto
{
    public class ReviewDto : IReview
    {
        public int ReviewId { get; set; }
        public string Review { get; set; }
        public int Rating { get; set; }
        public int MovieId { get; set; }
    }
}
