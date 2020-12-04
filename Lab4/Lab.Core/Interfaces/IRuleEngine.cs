
using Lab.Core.Models;
using Lab.Core.Models.Pieces;

namespace Lab.Core.Interfaces
{
    public interface IRuleEngine
    {
        void ApplyRules(int[,] board, Pieza piece, Movimiento movement);
    }
}