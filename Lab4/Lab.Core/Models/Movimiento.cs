using Lab.Core.Models.Pieces;

namespace Lab.Core.Models
{
    public class Movimiento
    {
        public TipoPieza Piece { get; set; }

        public BoardXCoordinate OriginalXPosition { get; set; }

        private int _originalYPosition;

        public int OriginalYPosition
        {
            get => _originalYPosition;
            set => _originalYPosition = value - 1;
        }

        public BoardXCoordinate NewXPosition { get; set; }

        private int _newYPosition;

        public int NewYPosition
        {
            get => _newYPosition;
            set => _newYPosition = value - 1;
        }

        public bool IsWhitePiece { get; set; }
    }
}