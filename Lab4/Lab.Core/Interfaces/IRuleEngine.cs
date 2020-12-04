
using Lab.Models;
using Lab.Models.Pieces;

namespace Chess.Core.Interfaces
{
    public interface IRuleEngine
    {
        void ApplyRules(int[,] board, Piece piece, Movement movement);
    }
}