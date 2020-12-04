using System;
using System.Collections.Generic;
using Lab.Core.Interfaces;
using Lab.Core.Models;
using Lab.Core.Models.Pieces;

namespace Lab.Core
{
    public class PieceFactory
    {

        private readonly Dictionary<TipoPieza, string> _pieces;
        public PieceFactory()
        {
            _pieces = new Dictionary<TipoPieza, string>()
            {
                { TipoPieza.C, "Knight" },
                { TipoPieza.T, "Rook"}
            };
        }

        public Pieza Create(Movimiento movement)
        {
            try
            {
                return (Pieza)Activator.CreateInstance(
                    Type.GetType($"Chess.Core.Models.Pieces.{_pieces[movement.Piece]}Piece"), new object[]
                    {
                        movement.Piece,
                        movement.IsWhitePiece
                    });
            }
            catch
            {
                return new PeonPieza(TipoPieza.P,movement.IsWhitePiece);
            }
        }
    }
}