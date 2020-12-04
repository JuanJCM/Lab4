using Lab.Core.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab.Core.Models.Rules
{
    public class ReglaMovimientoTorre : ReglasBase
    {
        public override bool Match(Pieza pieza)
        {
            return pieza.TipoPieza == TipoPieza.T;
        }

        public override bool MovimientoValido(int[,] board, Pieza pieza, Movimiento movimiento)
        {
            return true;
        }
    }
}
