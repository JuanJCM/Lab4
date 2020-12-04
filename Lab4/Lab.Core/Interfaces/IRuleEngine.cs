
using Lab.Core.Models;
using Lab.Core.Models.Pieces;

namespace Chess.Core.Interfaces
{
    public interface IRuleEngine
    {
        void ApplyRules(int[,] board, Piezas piece, Movimientos movement);
    }
}