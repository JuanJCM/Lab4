using System;
using System.Collections.Generic;
using System.Text;

namespace Lab.Core.Models.Pieces
{
    public abstract class Piezas
    {
        public readonly TipoPiezas Pieza;
        public bool EsPiezaBlanca;

        public Piezas(TipoPiezas tipoPiezas, bool esBlanca)
        {
            Pieza = tipoPiezas;
            EsPiezaBlanca = esBlanca;
        }

    }
}
