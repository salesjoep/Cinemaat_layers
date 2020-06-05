using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public interface IReviewContext
    {
        void CreateReview(IReview review);
        IEnumerable<IReview> GetAll();
    }
}
