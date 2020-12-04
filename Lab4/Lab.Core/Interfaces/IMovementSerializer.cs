using Lab.Core.Models;

namespace Chess.Core.Interfaces
{
    public interface IMovementSerializer
    {
        Movimientos SerializeMovement(string data);
    }
}