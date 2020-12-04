using Lab.Core.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Text;
using Lab.Core.Models.Pieces;
using Lab.Core.Interfaces;

namespace Lab.Core.Models.Rules
{
    public class ReglaMovimientoCaballo : ReglasBase
    {
        public override bool Match(Pieza pieza)
        {
            return pieza.TipoPieza == TipoPieza.C;
        }

        public override bool MovimientoValido(int[,] board, Pieza pieza, Movimiento movement)
        {
            var movimientoValido = new List<(int, int)>
            {
                (1, 2),
                (1, -2),
                (2, 1),
                (2, -1),
                (-1, -2),
                (-1, 2),
                (-2, -1),
                (-2, 1)
            };

            return movimientoValido.Any(c => 
            (int)movement.OriginalXPosition + c.Item1 == (int)movement.NewXPosition &&
             movement.OriginalYPosition + c.Item2 == movement.NewYPosition);
 
        }
    }
}
