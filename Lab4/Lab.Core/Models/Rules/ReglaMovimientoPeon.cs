using Lab.Core.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab.Core.Models.Rules
{
    class ReglaMovimientoPeon : ReglasBase
    {
        public override bool Match(Pieza _pieza)
        {
            return _pieza.pieza == TipoPieza.P;
        }

        public override bool MovimientoValido(int[,] board, Pieza piece, Movimiento movement)
        {

            var validXPositionAfterMove = (int)movement.OriginalXPosition;
            var validYPositionsAfterMove =
                GetWhiteValidResults(piece, movement).Union(GetBlackValidResults(piece, movement));
            return validXPositionAfterMove == (int)movement.NewXPosition &&
                   validYPositionsAfterMove.Contains(movement.NewYPosition);
        }

        private object GetBlackValidResults(Pieza piece, Movimiento movement)
        {
            var validResults = new List<int>();
            if (piece.EsPiezaBlanca)
            {
                return Enumerable.Empty<int>();
            }

            if (movement.OriginalYPosition == 6)
            {
                validResults.Add(5);
                validResults.Add(4);
            }
            validResults.Add(++movement.OriginalYPosition);
            return validResults;
        }

        private object GetWhiteValidResults(Pieza piece, Movimiento movement)
        {
            var validResults = new List<int>();
            if (!piece.EsPiezaBlanca)
            {
                return Enumerable.Empty<int>();
            }

            if (movement.OriginalYPosition == 1)
            {
                validResults.Add(2);
                validResults.Add(3);
            }
            validResults.Add(++movement.OriginalYPosition);
            return validResults;
        }
    }
}
