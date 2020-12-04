using System;
using System.Collections.Generic;
using System.Text;
using Lab.Core.Interfaces;
using Lab.Core.Models.Pieces;
namespace Lab.Core.Models.Rules
{
     public abstract class ReglasBase
    {
        public ReglasBase()
        {

        }

        public abstract bool Match(Pieza pieza);
        public abstract bool MovimientoValido(int[,] board, Pieza pieza, Movimiento movimiento);

    }
}
