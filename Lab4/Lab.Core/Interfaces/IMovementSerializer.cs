using Lab.Core.Models;

namespace Lab.Core.Interfaces
{
    public interface IMovementSerializer
    {
        Movimientos SerializeMovement(string data);
    }
}