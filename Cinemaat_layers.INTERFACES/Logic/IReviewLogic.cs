using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.INTERFACES.Logic
{
    public interface IReviewLogic
    {
        void CreateReview(IReview _review);
        IEnumerable<IReview> GetAllReviews(int movieId);
    }
}
