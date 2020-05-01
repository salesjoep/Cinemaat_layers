using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public interface ISeatContext
    {
        void Add(ISeat seat);

        IEnumerable<ISeat> GetAll();

        ISeat GetById(int id);
    }
}
