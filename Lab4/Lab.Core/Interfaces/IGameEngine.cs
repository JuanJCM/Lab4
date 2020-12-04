using System;
using System.Collections.Generic;
using System.Text;
using Lab.Core.Models;

namespace Lab.Core.Interfaces
{
    public interface IGameEngine
    {
        void ExecuteMovement(Movimiento movement);

    }
}