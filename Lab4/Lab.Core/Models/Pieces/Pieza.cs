using System;
using System.Collections.Generic;
using System.Text;

namespace Lab.Core.Models.Pieces
{
    public abstract class Pieza
    {
        public readonly TipoPieza pieza;
        public bool EsPiezaBlanca;

        public Pieza(TipoPieza tipoPiezas, bool esBlanca)
        {
            pieza = tipoPiezas;
            EsPiezaBlanca = esBlanca;
        }

        public virtual void Move(int[,] board, Movimiento movement)
        {
           board[(int)movement.NewXPosition, movement.NewYPosition] = 1;
        }
    }
}
