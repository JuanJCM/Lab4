using System;
using System.Collections.Generic;
using System.Text;
using Lab.Core.Interfaces;
using Lab.Core.Models;
using Lab.Core.Models.Pieces;

namespace Lab.Core
{
    public class GameEngine : IGameEngine
    {
        private readonly PieceFactory _pieceFactory;
        private readonly IRuleEngine _ruleEngine;
        private readonly int[,] _board;

        public GameEngine(
            PieceFactory pieceFactory,
            IRuleEngine ruleEngine)
        {
            _pieceFactory = pieceFactory;
            _ruleEngine = ruleEngine;
            _board = new[,]
            {
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 }
            };
        }

        public void ExecuteMovement(Movimiento movement)
        {
            try
            {
                var piece = _pieceFactory.Create(movement);
                _ruleEngine.ApplyRules(_board, piece, movement);
                piece.Move(_board, movement);
            }
            catch (Exception e)
            {
                throw;
            }
        }

    }
}