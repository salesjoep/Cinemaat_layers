using Cinemaat_layers.INTERFACES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.INTERFACES.Context
{
    public interface ILoginContext
    {
        void Login(ILogin user);
    }
}
