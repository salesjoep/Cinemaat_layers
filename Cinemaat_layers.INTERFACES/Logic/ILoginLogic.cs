using Cinemaat_layers.INTERFACES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.INTERFACES.Logic
{
    public interface ILoginLogic
    {
        bool Login(ILogin user);
    }
}
