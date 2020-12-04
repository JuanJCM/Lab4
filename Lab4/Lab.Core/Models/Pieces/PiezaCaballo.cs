using System;
using System.Collections.Generic;
using System.Text;
using Lab.Core.Interfaces;

namespace Lab.Core.Models.Pieces
{
    public class PiezaCaballo : Piezas
    {
        public PiezaCaballo (TipoPiezas tipoPiezas, bool esBlanca)
            : base(tipoPiezas, esBlanca)
        {

        }
    }
}
