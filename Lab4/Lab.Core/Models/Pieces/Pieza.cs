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

    }
}
