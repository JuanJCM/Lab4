using Lab.Core.Models;

namespace Lab.Core.Interfaces
{
    public interface IMovementSerializer
    {
        Movimiento SerializeMovement(string data);
    }
}