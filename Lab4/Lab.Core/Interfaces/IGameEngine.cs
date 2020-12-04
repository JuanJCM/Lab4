using System;
using System.Collections.Generic;
using System.Text;
using Lab.Models;

namespace Lab.Core.Interfaces
{
    public interface IGameEngine
    {
        void Start();

        void ExecuteMovement(Movement movement);

        void Stop();
    }
}